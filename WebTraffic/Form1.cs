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
		List<WebBrowser> Browser;
		hkActivityStatus Access;
		List<string> ListURL;
		Thread thLoop;
		int StayTime;

		public WebTraffic()
		{
			InitializeComponent();
			// initialize progress bar
			fProgress.Maximum = 1024;
			fProgress.Minimum = 0;
			fProgress.Value = 0;
			// set delegate
			// UpdateDisplay = new DelUpdateProgress( UpdateProgress );
			Window = this;
			// start web traffic
			Start();
			Browser.Add( fBrowser );
		}

		// start web traffic process (call only once)
		private int Start ()
		{
			double temp = 0.0;

			// initialize List URL
			ListURL = new List<string>();
			Browser = new List<WebBrowser>();
			Access.Start = 0;
			Access.Current = 0;
			int.TryParse( fRounds.Text, out Access.Stop );
			Access.Stop = (Access.Stop <= 0)? 20: Access.Stop;
			double.TryParse( fStayTime.Text, out temp );
			StayTime = (int) (temp * 1000);
			StayTime = ( StayTime <= 0 ) ? 4000 : StayTime;
			return 0;
		}

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

		private int StopExec ()
		{
			// stop exec thread
			if (thLoop == null) return -1;
			thLoop.Abort();
			thLoop = null;
			return 0;
		}

		private void Exec (List<string> list_url)
		{
			int i, j;

			while (Access.Current < Access.Stop)
			{
				for (i = 0, j = 0 ; i < ListURL.Count ; i++)
				{
					j += (AccessURL( ListURL[i] ) == 0)? 1 : 0;
				}
				if (ListURL.Count > 0 && j == ListURL.Count)
				{
					Access.Current++;
					// Window.Invoke( UpdateDisplay );
					UpdateProgress();
				}
			}
		}

		// access a particular url for a duration
		private int AccessURL (string url)
		{
			if (Browser.Count == 0) return -1;
			Browser[0].ScriptErrorsSuppressed = true;
			Browser[0].Navigate( url );
			Thread.Sleep( StayTime );
			return 0;
		}

		private void wbtnStart_Click (object sender, EventArgs e)
		{
			// start progress bar
			fProgress.Value = 0;
			StartExec();
		}

		private void wbtnStop_Click (object sender, EventArgs e)
		{
			//stop run thread
			StopExec();
			// stop progress bar
			fProgress.Value = 0;
		}

		/*
		private int fAccessPage_webresp(string web_page)
		{
			WebRequest wrq = WebRequest.Create(web_page);
			WebResponse wrs = wrq.GetResponse();
			Stream rcv = wrs.GetResponseStream();
			Encoding encd = System.Text.Encoding.GetEncoding("utf-8");
			StreamReader rdStrm = new StreamReader(rcv, encd);
			string sResp = rdStrm.ReadToEnd();
			rdStrm.Close();
			wrs.Close();
			return 0;
		}
		*/

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

		private void fStayTime_Leave (object sender, EventArgs e)
		{
			double temp;

			double.TryParse( fStayTime.Text, out temp );
			StayTime = (int) ( temp * 1000 );
			StayTime = ( StayTime <= 0 ) ? 4000 : StayTime;
		}
	}
}
