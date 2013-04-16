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
	public struct hkActivityStatus
	{
		public int	Start;
		public int	Current;
		public int	Stop;
	};

	public partial class WebTraffic : Form
	{
		// delegate void DelUpdateProgress ();
		// DelUpdateProgress UpdateDisplay;
		WebTraffic Window;
		List<Process> Browser;
		hkActivityStatus Access;
		List<string> ListURL;
		Thread thLoop;
		int StayTime, NextTime, BrowserCount;
		string LocalBrowser = @"C:\Users\Subhajit\AppData\Local\Google\Chrome\Application\chrome.exe";

		// create new form instance
		public WebTraffic ()
		{
			InitializeComponent();
			fProgress.Maximum = 1024;
			fProgress.Minimum = 0;
			fProgress.Value = 0;
			Window = this;
			Start();
		}

		// start web traffic process (call only once)
		private int Start ()
		{
			double temp = 0.0;

			// initialize List URL
			ListURL = new List<string>();
			Browser = new List<Process>();
			Access.Start = 0;
			Access.Current = 0;
			int.TryParse( fRounds.Text, out Access.Stop );
			Access.Stop = ( Access.Stop <= 0 ) ? 20 : Access.Stop;
			double.TryParse( fStayTime.Text, out temp );
			StayTime = (int) ( temp * 1000 );
			StayTime = ( StayTime <= 0 ) ? 4000 : StayTime;
			double.TryParse( fNextTime.Text, out temp );
			NextTime = (int) ( temp * 1000 );
			NextTime = ( NextTime <= 0 ) ? 4000 : NextTime;
			int.TryParse( fBrowserCount.Text, out BrowserCount );
			return 0;
		}

		// start thread execution
		private int StartExec ()
		{
			// start exec thread
			if (thLoop != null) return -1;
			thLoop = new Thread( () => Exec( ListURL ) );
			thLoop.Name = "WebTraffic_Exec";
			thLoop.IsBackground = true;
			thLoop.Start();
			return 0;
		}

		// stop thread execution
		private int StopExec ()
		{
			// stop exec thread
			if (thLoop == null) return -1;
			thLoop.Abort();
			thLoop = null;
			return 0;
		}

		// execution thread
		private void Exec (List<string> list_url)
		{
			int i, j;

			while (Access.Current < Access.Stop)
			{
				for (i = 0, j = 0 ; i < ListURL.Count ; i++)
				{
					j += ( AccessURL( ListURL[i] ) == 0 ) ? 1 : 0;
				}
				if (ListURL.Count > 0 && j == ListURL.Count)
				{
					Access.Current++;
					UpdateProgress();
				}
			}
		}

		// access a particular url for a duration using opera
		private int AccessURL (string url)
		{
			int i, n;
			Process p = null;
			
			ProcessStartInfo psInfo = new ProcessStartInfo( LocalBrowser, "--new-window " + url );
			psInfo.CreateNoWindow = false;
			psInfo.UseShellExecute = false;
			psInfo.WindowStyle = ProcessWindowStyle.Normal;
			try { p = Process.Start( psInfo ); }
			catch (Exception) { }
			if (p != null) Browser.Add( p );
			if (Browser.Count < BrowserCount) Thread.Sleep( NextTime );
			else
			{
				Thread.Sleep( StayTime );
				n = Browser.Count;
				for (i = 0 ; i < n ; i++)
				{
					try { Browser[i].Kill(); }
					catch (Exception) { }
				}
				Browser.RemoveAll( browser => true );
			}
			return 0;
		}

		// access a particular url for a duration using webbrowser
		private int AccessURL_WebBrowser (string url)
		{
			if (Browser.Count == 0) return -1;
			// Browser[0].ScriptErrorsSuppressed = true;
			// Browser[0].Navigate( url );
			Thread.Sleep( StayTime );
			return 0;
		}

		// access an url using webrequest
		private int AccessURL_WebRequest (string web_page)
		{
			WebRequest wrq = WebRequest.Create( web_page );
			WebResponse wrs = wrq.GetResponse();
			Stream rcv = wrs.GetResponseStream();
			Encoding encd = System.Text.Encoding.GetEncoding( "utf-8" );
			StreamReader rdStrm = new StreamReader( rcv, encd );
			string sResp = rdStrm.ReadToEnd();
			rdStrm.Close();
			wrs.Close();
			return 0;
		}

		// upon start, start thread
		private void fStart_Click (object sender, EventArgs e)
		{
			// start progress bar
			fProgress.Value = 0;
			StartExec();
		}

		// upon stop, stop thread
		private void fStop_Click (object sender, EventArgs e)
		{
			//stop run thread
			StopExec();
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
			fListURL.Text = str;
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
				fProgress.Minimum = Access.Start;
				fProgress.Maximum = Access.Stop;
				fProgress.Value = Access.Current;
			}
		}

		// paint window
		private void WebTraffic_Paint (object sender, PaintEventArgs e)
		{
			UpdateProgress();
		}

		// add url to list
		private void fAdd_Click (object sender, EventArgs e)
		{
			ListURL.Add( fURL.Text );
			UpdateListURL();
		}

		// remove url from list
		private void fRemove_Click (object sender, EventArgs e)
		{
			ListURL.Remove( fURL.Text );
			UpdateListURL();
		}

		// update access rounds upon focus change
		private void fRounds_Leave (object sender, EventArgs e)
		{
			int.TryParse( fRounds.Text, out Access.Stop );
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
	}
}
