using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WebTraffic
{
	public struct hkRound
	{
		public int	Start;
		public int	Current;
		public int	Stop;
	};
	public struct hkMouseStatus
	{
		public bool		Pressed;
		public Point	LastPosition;
	};
	public enum hkBrowser:int
	{
		None = -1,
		Chrome = 0,
		Opera = 1,
		Firefox = 2,
		IE = 3
	};


	public partial class WebTraffic : Form
	{
		WebTraffic		Window;
		List<Process>	BrowserProc;
		hkRound			Round;
		List<string>	ListURL;
		Thread			thExec;
		string[]		BrowserParam, BrowserName, BrowserPath;
		int				StayTime, NextTime, BrowserCount;
		hkBrowser		Browser;
		string			SettingsFile;
		bool			ExecPaused;
		hkMouseStatus	MouseStatus;

		// create new form instance
		public WebTraffic ()
		{
			string[] strTemp = new string[4];

			InitializeComponent();
			Window = this;
			BrowserProc = new List<Process>();
			ListURL = new List<string>();
			thExec = null;
			BrowserParam = new string[4];
			BrowserParam[(int) hkBrowser.Chrome] = "--new-window ";
			BrowserParam[(int) hkBrowser.Opera] = "-newprivatetab ";
			BrowserParam[(int) hkBrowser.Firefox] = "-private -new-tab ";
			BrowserParam[(int) hkBrowser.IE] = "-private ";
			BrowserName = new string[4];
			BrowserName[(int) hkBrowser.Chrome] = "chrome";
			BrowserName[(int) hkBrowser.Opera] = "opera";
			BrowserName[(int) hkBrowser.Firefox] = "firefox";
			BrowserName[(int) hkBrowser.IE] = "iexplore";
			Browser = hkBrowser.None;
			// get browser path settings
			SettingsFile = "settings.ini";
			try { strTemp = File.ReadAllLines( SettingsFile ); }
			catch (Exception) { }
			BrowserPath = new string[4];
			for (int i=0 ; i < 4 ; i++)
			{
				if (strTemp.Length > i && strTemp[i] != null) BrowserPath[i] = strTemp[i];
				else BrowserPath[i] = "";
			}
			ExecPaused = false;
			fPauseExec.Enabled = false;
			MouseStatus.Pressed = false;
			MouseStatus.LastPosition = MousePosition;
		}

		// start thread execution
		private int StartExec ()
		{
			if (Browser == hkBrowser.None) return -1;
			// update changing parameters
			Round.Start = 0;
			Round.Current = 0;
			try
			{
				Round.Stop = int.Parse( fRounds.Text );
				StayTime = (int) ( double.Parse( fStayTime.Text ) * 1000 );
				NextTime = (int) ( double.Parse( fNextTime.Text ) * 1000 );
				BrowserCount = int.Parse( fBrowserCount.Text );
			}
			catch (Exception) { }
			UpdateProgress();
			fStartExec.Enabled = false;
			fPauseExec.Enabled = true;
			// start exec thread
			if (thExec == null || thExec.ThreadState == System.Threading.ThreadState.Stopped)
			{
				CloseBrowsers(true);
				thExec = new Thread( () => Exec( ListURL ) );
				thExec.Name = "WebTraffic_Exec";
				thExec.IsBackground = true;
				thExec.Start();
				return 0;
			}
			return -1;
		}

		// stop thread execution
		private int StopExec ()
		{
			// stop exec thread
			if (thExec == null) return -1;
			thExec.Abort();
			thExec = null;
			CloseBrowsers(true);
			fPauseExec.Enabled = false;
			fStartExec.Enabled = true;
			return 0;
		}

		// execution thread
		private void Exec (List<string> list_url)
		{
			int i, j;

			while (Round.Current < Round.Stop)
			{
				while (ExecPaused || list_url.Count == 0) { Thread.Sleep( 2000 ); }
				for (i = 0, j = 0 ; i < ListURL.Count ; i++)
				{
					j += ( AccessURL( ListURL[i] ) == 0 ) ? 1 : 0;
				}
				if (ListURL.Count > 0 && j == ListURL.Count)
				{
					Round.Current++;
					UpdateProgress();
				}
			}
			CloseBrowsers(false);
			RefreshExec();
		}

		// close all running browsers
		private int CloseBrowsers (bool quick_close)
		{
			int i;
			Process[] p;

			if (Browser == hkBrowser.None) return -1;
			if(!quick_close) Thread.Sleep( StayTime );
			// close all browser processes normally (through repeated trying)
			while (( p = Process.GetProcessesByName( BrowserName[(int) Browser] ) ).Length > 0)
			{
				for (i = 0 ; i < p.Length ; i++)
				{
					p[i].CloseMainWindow();
					p[i].Dispose();
				}
			}
			// free browser process resources
			for (i = 0 ; i < BrowserProc.Count ; i++)
			{
				BrowserProc[i].Dispose();
			}
			BrowserProc.RemoveAll( browser => true );
			return 0;
		}

		// access a particular url for a duration using browser
		private int AccessURL (string url)
		{
			Process p = new Process();

			if (Browser == hkBrowser.None) return -1;
			p.StartInfo.FileName = BrowserPath[(int) Browser];
			p.StartInfo.Arguments = BrowserParam[(int) Browser] + url;
			p.StartInfo.CreateNoWindow = true;
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			try { p.Start(); }
			catch (Exception) { }
			if (p != null) BrowserProc.Add( p );
			if (BrowserProc.Count < BrowserCount) Thread.Sleep( NextTime );
			else CloseBrowsers(false);
			return 0;
		}

		// upon start, start thread
		private void fStartExec_Click (object sender, EventArgs e)
		{
			StartExec();
		}

		// upon stop, stop thread
		private void fStopExec_Click (object sender, EventArgs e)
		{
			StopExec();
		}

		// upon pause, stop thread, upon resume, start thread
		private void fPauseExec_Click (object sender, EventArgs e)
		{
			ExecPaused = !ExecPaused;
			if (ExecPaused) fPauseExec.Text = "Resume";
			else fPauseExec.Text = "Pause";
		}

		// updates the list url
		public void UpdateListURL ()
		{
			int i;
			string str = "";

			for (i = 0 ; i < ListURL.Count ; i++)
			{
				str += ListURL[i] + "\r\n";
			}
			if(fListURL.Text != str) fListURL.Text = str;
		}

		// update progress bar
		public void UpdateProgress ()
		{
			if (this.InvokeRequired)
			{
				this.Invoke( new MethodInvoker( UpdateProgress ) );
			}
			else
			{
				// update progress bar
				if (fProgress.Minimum != Round.Start) fProgress.Minimum = Round.Start;
				if (fProgress.Maximum != Round.Stop) fProgress.Maximum = Round.Stop;
				if (fProgress.Value != Round.Current) fProgress.Value = Round.Current;
			}
		}

		// hide pause button
		public void RefreshExec ()
		{
			if (this.InvokeRequired)
			{
				this.Invoke( new MethodInvoker( RefreshExec ) );
			}
			else
			{
				fPauseExec.Text = "Pause";
				fPauseExec.Enabled = false;
				fStartExec.Enabled = true;
			}
		}

		// add url to list
		private void fAddListURL_Click (object sender, EventArgs e)
		{
			if (fURL.Text.Length > 0)
			{
				ListURL.Add( fURL.Text );
				UpdateListURL();
			}
		}

		// remove url from list
		private void fRemoveListURL_Click (object sender, EventArgs e)
		{
			if (fURL.Text.Length > 0)
			{
				ListURL.Remove( fURL.Text );
				UpdateListURL();
			}
		}

		// load url list from a text file
		private void fLoadListURL_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgLoadListURL.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			string[] list = File.ReadAllLines( dlgLoadListURL.FileName );
			ListURL.RemoveAll( url => true );
			ListURL.AddRange( list );
			UpdateListURL();
		}

		// save url list to a text file
		private void fSaveListURL_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgSaveListURL.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			File.WriteAllLines( dlgSaveListURL.FileName, ListURL );
		}

		// update access rounds upon focus change
		private void fRounds_Leave (object sender, EventArgs e)
		{
			int.TryParse( fRounds.Text, out Round.Stop );
			UpdateProgress();
		}

		// update stay time upon focus change
		private void fStayTime_Leave (object sender, EventArgs e)
		{
			double temp;

			double.TryParse( fStayTime.Text, out temp );
			StayTime = (int) ( temp * 1000 );
			StayTime = ( StayTime <= 0 ) ? 4000 : StayTime;
		}

		// update next time upon focus change
		private void fNextTime_Leave (object sender, EventArgs e)
		{
			double temp;

			double.TryParse( fNextTime.Text, out temp );
			NextTime = (int) ( temp * 1000 );
			NextTime = ( NextTime <= 0 ) ? 4000 : NextTime;
		}

		// update browser count upon focus change
		private void fBrowserCount_Leave (object sender, EventArgs e)
		{
			int.TryParse( fBrowserCount.Text, out BrowserCount );
		}

		// internal minimize button
		private void fWinMinimize_Click (object sender, EventArgs e)
		{
			Window.SendToBack();
		}

		// internal close button
		private void fWinClose_Click (object sender, EventArgs e)
		{
			Window.Close();
		}

		// select path for chrome browser
		private void fBrowserPath_Chrome_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgSelectBrowser.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			BrowserPath[(int) hkBrowser.Chrome] = dlgSelectBrowser.FileName;
			File.WriteAllLines( SettingsFile, BrowserPath );
		}

		// select path for opera browser
		private void fBrowserPath_Opera_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgSelectBrowser.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			BrowserPath[(int) hkBrowser.Opera] = dlgSelectBrowser.FileName;
			File.WriteAllLines( SettingsFile, BrowserPath );
		}

		// select path for firefox browser
		private void fBrowserPath_Firefox_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgSelectBrowser.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			BrowserPath[(int) hkBrowser.Firefox] = dlgSelectBrowser.FileName;
			File.WriteAllLines( SettingsFile, BrowserPath );
		}

		// select path for ie browser
		private void fBrowserPath_IE_Click (object sender, EventArgs e)
		{
			DialogResult dRslt = dlgSelectBrowser.ShowDialog();
			if (dRslt != System.Windows.Forms.DialogResult.OK) return;
			BrowserPath[(int) hkBrowser.IE] = dlgSelectBrowser.FileName;
			File.WriteAllLines( SettingsFile, BrowserPath );
		}

		// select chrome browser (if path available)
		private void fBrowserSelect_Chrome_Click (object sender, EventArgs e)
		{
			if (BrowserPath[(int) hkBrowser.Chrome] == "") return;
			Browser = hkBrowser.Chrome;
			fBrowserSelect_Chrome.BackColor = Color.DimGray;
			fBrowserSelect_Opera.BackColor = Color.White;
			fBrowserSelect_Firefox.BackColor = Color.White;
			fBrowserSelect_IE.BackColor = Color.White;
		}

		// select opera browser (if path available)
		private void fBrowserSelect_Opera_Click (object sender, EventArgs e)
		{
			if (BrowserPath[(int) hkBrowser.Opera] == "") return;
			Browser = hkBrowser.Opera;
			fBrowserSelect_Opera.BackColor = Color.DimGray;
			fBrowserSelect_Chrome.BackColor = Color.White;
			fBrowserSelect_Firefox.BackColor = Color.White;
			fBrowserSelect_IE.BackColor = Color.White;
		}

		// select firefox browser (if path available)
		private void fBrowserSelect_Firefox_Click (object sender, EventArgs e)
		{
			if (BrowserPath[(int) hkBrowser.Firefox] == "") return;
			Browser = hkBrowser.Firefox;
			fBrowserSelect_Firefox.BackColor = Color.DimGray;
			fBrowserSelect_Chrome.BackColor = Color.White;
			fBrowserSelect_Opera.BackColor = Color.White;
			fBrowserSelect_IE.BackColor = Color.White;
		}

		// select ie browser (if path available)
		private void fBrowserSelect_IE_Click (object sender, EventArgs e)
		{
			if (BrowserPath[(int) hkBrowser.IE] == "") return;
			Browser = hkBrowser.IE;
			fBrowserSelect_IE.BackColor = Color.DimGray;
			fBrowserSelect_Chrome.BackColor = Color.White;
			fBrowserSelect_Opera.BackColor = Color.White;
			fBrowserSelect_Firefox.BackColor = Color.White;
		}

		// updates mouse status to pressed
		private void WebTraffic_MouseDown (object sender, MouseEventArgs e)
		{
			MouseStatus.Pressed = true;
			MouseStatus.LastPosition = MousePosition;
		}

		// updates mouse status to left
		private void WebTraffic_MouseUp (object sender, MouseEventArgs e)
		{
			MouseStatus.Pressed = false;
		}

		// moves the window
		private void WebTraffic_MouseMove (object sender, MouseEventArgs e)
		{
			if (MouseStatus.Pressed)
			{
				Top += ( MousePosition.Y - MouseStatus.LastPosition.Y );
				Left += ( MousePosition.X - MouseStatus.LastPosition.X );
			}
			MouseStatus.LastPosition = MousePosition;
		}
	}
}
