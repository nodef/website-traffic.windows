using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebTraffic
{
	public partial class WebTraffic : Form
	{

		public WebTraffic()
		{
			InitializeComponent();
			// initialize progress bar
			fProgress.Maximum = 1024;
			fProgress.Minimum = 0;
			fProgress.Value = 0;
			// hkWebTraffic.Start();
		}

		private void wbtnStart_Click(object sender, EventArgs e)
		{
			// start progress bar
			fProgress.Value = 0;
			hkWebTraffic.StartExec();
		}

		private void wbtnStop_Click(object sender, EventArgs e)
		{
			//stop run thread
			hkWebTraffic.StopExec();
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
		public void UpdateListURL()
		{
			int i;
			string str = "";

			for (i = 0; i < hkWebTraffic.ListURL.Count; i++)
			{
				str += hkWebTraffic.ListURL[i] + "\r\n";
			}
			fListURL.Text = str;
		}

		// update progress bar
		public void UpdateProgress ()
		{
			// update progress bar
			fProgress.Minimum = hkWebTraffic.Access.Start;
			fProgress.Maximum = hkWebTraffic.Access.Stop;
			fProgress.Value = hkWebTraffic.Access.Current;
		}

		// paint window
		private void WebTraffic_Paint(object sender, PaintEventArgs e)
		{
			UpdateProgress();
		}

		// add url to list
		private void fAdd_Click (object sender, EventArgs e)
		{
			hkWebTraffic.ListURL.Add( fURL.Text );
			UpdateListURL();
		}

		// remove url from list
		private void fRemove_Click (object sender, EventArgs e)
		{
			hkWebTraffic.ListURL.Remove( fURL.Text );
			UpdateListURL();
		}

		// update access rounds upon focus change
		private void fRounds_Leave (object sender, EventArgs e)
		{
			int.TryParse( fRounds.Text, out hkWebTraffic.Access.Stop );
			UpdateProgress();
		}
	}
}
