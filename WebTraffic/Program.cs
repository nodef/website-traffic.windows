using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace WebTraffic
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new WebTraffic());
		}
	}
	
	static class hkWebTraffic
	{
		List<string> WebList;
		Thread thWebTraffic;
		bool wbrsrStatus;
		int wAccessCount = 0, wAccessProgress = 0;

	}
}
