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
			// initialize weblist
			WebList = new List<string>();
			// initialize progress bar
			fProgress.Maximum = 1024;
			fProgress.Minimum = 0;
		}

		private void wbtnStart_Click(object sender, EventArgs e)
		{
			// start progress bar
			fProgress.Value = 0;
			// start run thread
			thWebTraffic = new Thread(() => tRunWebTraffic(WebList));
			thWebTraffic.Name = "WebTraffic";
			thWebTraffic.IsBackground = true;
			thWebTraffic.Start();
		}

		private void wbtnStop_Click(object sender, EventArgs e)
		{
			//stop run thread
			if(thWebTraffic != null) thWebTraffic.Abort();
			// stop progress bar
			fProgress.Value = 0;
		}

		private int fAccessPage(string web_page)
		{
			// WebBrowser wb = new WebBrowser();
			wbrsrStatus = true;
			// wb.Navigate(web_page);
			// Thread.Sleep(10000);
			wbrsrIE0.ScriptErrorsSuppressed = true;
			wbrsrIE0.Navigate(web_page);
			do
			{
				Thread.Sleep(10000);
			} while (wbrsrStatus) ;
			return 0;
		}

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

		private void tRunWebTraffic(List<string> web_list)
		{
			int i;

			while (true)
			{
				// if (wAccessCount > 0) continue;
				for (i = 0; i < web_list.Count; i++)
				{
					fAccessPage(web_list[i]);
					wAccessProgress = (i * 1024) / web_list.Count;
				}
				if(web_list.Count > 0) wAccessCount++;
			}
		}

		private void fShowWebList()
		{
			int i;
			string str = "";

			for (i = 0; i < WebList.Count; i++)
			{
				str += WebList[i] + "\n";
			}
			fListURL.Text = str;
		}

		private void wbtnAdd_Click(object sender, EventArgs e)
		{
			WebList.Add(wtxtWebAddress.Text);
			fShowWebList();
		}

		private void wbtnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				WebList.Remove(wtxtWebAddress.Text);
			}
			catch (Exception) { }
			fShowWebList();
		}

		private void WebTraffic_Paint(object sender, PaintEventArgs e)
		{
			fProgress.Value = wAccessProgress;
			wlblAccessCount.Text = wAccessCount.ToString();
		}

		private void WebTraffic_FormClosed(object sender, FormClosedEventArgs e)
		{
			//stop run thread
			if(thWebTraffic != null) thWebTraffic.Abort();
		}

		private void wbrsrIE0_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			wbrsrStatus = false;
		}
	}
}
