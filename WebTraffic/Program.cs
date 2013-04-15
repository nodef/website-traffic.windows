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
			hkWebTraffic.Window = new WebTraffic();
			Application.Run(hkWebTraffic.Window);
		}
	}

	public struct hkActivityStatus
	{
		public int	Start;
		public int	Current;
		public int	Stop;
	};

	public static class hkWebTraffic
	{
		delegate void DelUpdateProgress ();
		static DelUpdateProgress UpdateProgress = new DelUpdateProgress( Window.UpdateProgress );
		public static WebTraffic Window;
		public static List<WebBrowser> Browser;
		public static hkActivityStatus Access;
		public static List<string> ListURL;
		static Thread thLoop;

		// start web traffic process (call only once)
		public static int Start ()
		{
			// initialize List URL
			ListURL = new List<string>();
			Browser = new List<WebBrowser>();
			Access.Start = 0;
			Access.Current = 0;
			Access.Stop = 20;
			return 0;
		}

		public static int StartExec ()
		{
			// start exec thread
			thLoop = new Thread( () => Exec( ListURL ) );
			thLoop.Name = "WebTraffic_Exec";
			thLoop.IsBackground = true;
			thLoop.Start();
			return 0;
		}

		public static int StopExec ()
		{
			// stop exec thread
			if(thLoop != null) thLoop.Abort();
			return 0;
		}

		public static void Exec (List<string> list_url)
		{
			int i, j;

			while (Access.Current < Access.Stop)
			{
				for (i = 0, j = 0 ; i < ListURL.Count ; i++)
				{
					j = AccessURL( ListURL[i] );
				}
				if (ListURL.Count > 0 && j == ListURL.Count) Access.Current++;
				Window.Invoke( UpdateProgress );
			}
		}

		// access a particular url for a duration
		static int AccessURL (string url)
		{
			if (Browser.Count == 0) return -1;
			Browser[0].ScriptErrorsSuppressed = true;
			Browser[0].Navigate( url );
			Thread.Sleep( 10000 );
			return 0;
		}
	}
}
