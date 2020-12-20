using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace WebsiteTraffic {
  public struct RoundDetails {
    public int	Start;
    public int  Current;
    public int	Stop;
  };

  public struct MouseStatus	{
    public bool   Pressed;
    public Point  LastPosition;
  };

  public enum BrowserType : int	{
    None    = -1,
    Chrome  = 0,
    Opera   = 1,
    Firefox = 2,
    Edge    = 3
  };


  public partial class MainForm : Form {

    Thread        ExecThread;
    BrowserType   Browser;
    bool          ForceClose;
    bool          Hidden;
    RoundDetails	Round;
    bool          Paused;
    int           StayTime;
    int           NextTime;
    int           BrowserCount;
    MouseStatus	  Mouse;

    readonly string SettingsFile;
    readonly Button[] BPick;
    readonly Button[] BPath;
    readonly string[] BrowserParam;
    readonly string[] BrowserName;
    readonly string[] BrowserPath;
    readonly List<Process>  Browsers;
    readonly List<string>   URLs;


    // Create new Form.
    public MainForm () {
      InitializeComponent();
      SettingsFile = "settings.ini";
      Browser = BrowserType.None;
      Browsers = new List<Process>();
      BrowserPath = new string[4];
      URLs = new List<string>();
      ExecThread = null;
      Paused = false;
      BPause.Enabled = false;
      Mouse.Pressed = false;
      Mouse.LastPosition = MousePosition;
      ForceClose = CForceClose.Checked;
      BPick = new Button[] {
        BPickChrome,
        BPickOpera,
        BPickFirefox,
        BPickEdge
      };
      BPath = new Button[] {
        BPathChrome,
        BPathOpera,
        BPathFirefox,
        BPathEdge
      };
      BrowserParam = new string[] {
        "-incognito --new-window ", // chrome
        "--private --remote ",      // opera
        "-private-window ",         // firefox
        "-inprivate "               // edge
      };
      BrowserName = new string[] {
        "chrome",
        "opera",
        "firefox",
        "msedge"
      };
      LoadSettings();
      HighlightBrowserPath();
    }


    // Start thread execution.
    private int StartExecThread() {
      int i = (int) Browser;
      if (i == -1) { Log("Browser not selected!"); return -1; }
      // update parameters
      Round.Start = 0;
      Round.Current = 0;
      ReadParameters();
      // update buttons
      BStart.Enabled = false;
      BPause.Enabled = true;
      UpdateProgress();
      // start thread
      if (!ThreadIsStopped(ExecThread)) { Log("Still running!"); return -1; }
      CloseBrowsers(0);
      ExecThread = StartThread(() => Exec(URLs));
      return 0;
    }


    // Stop thread execution.
    private int StopExecThread() {
      // stop thread
      if (ExecThread == null) { Log("Not running!"); return -1; }
      ExecThread.Abort();
      ExecThread = null;
      CloseBrowsers(0);
      // update buttons
      BPause.Enabled = false;
      BStart.Enabled = true;
      return 0;
    }

    // Execution thread.
    private void Exec(List<string> urls) {
      while (Round.Current < Round.Stop) {
        while (Paused || urls.Count == 0 || Browser == BrowserType.None)
          Thread.Sleep(2000);
        int i = (int) Browser, n = 0;
        foreach (var url in urls) {
          var p = OpenBrowserProcess(url, i, Hidden);
          if (p == null) continue;
          Browsers.Add(p);
          if (Browsers.Count >= BrowserCount) CloseBrowsers(StayTime);
          else Thread.Sleep(NextTime);
          n++;
        }
        if (urls.Count > 0 && n >= urls.Count) {
          Round.Current++;
          UpdateProgress();
        }
      }
      CloseBrowsers(StayTime);
      RefreshActions();
    }

    // Start thread.
    private void BStart_Click(object sender, EventArgs e) {
      StartExecThread();
    }

    // Stop thread.
    private void BStop_Click(object sender, EventArgs e) {
      StopExecThread();
    }

    // Upon Pause -> stop thread, upon resume -> start thread.
    private void BPause_Click(object sender, EventArgs e) {
      Paused = !Paused;
      BPause.Text = Paused ? "Resume" : "Pause";
    }

    // Updates URL list.
    public void UpdateURLs() {
      string urls = "";
      foreach (var url in URLs)
        urls += url + "\r\n";
      if (TURLs.Text != urls) TURLs.Text = urls;
    }

    // Update Progress bar.
    public void UpdateProgress() {
      if (InvokeRequired) {
        Invoke(new MethodInvoker(UpdateProgress));
        return;
      }
      if (LProgress.Minimum != Round.Start)   LProgress.Minimum = Round.Start;
      if (LProgress.Maximum != Round.Stop)    LProgress.Maximum = Round.Stop;
      if (LProgress.Value   != Round.Current) LProgress.Value   = Round.Current;
    }

    // hide pause button
    public void RefreshActions() {
      if (InvokeRequired) {
        Invoke(new MethodInvoker(RefreshActions));
        return;
      }
      BPause.Text = "Pause";
      BPause.Enabled = false;
      BStart.Enabled = true;
    }

    // Add URL to list.
    private void BURLAdd_Click(object sender, EventArgs e) {
      string url = TURL.Text;
      if (url == "") return;
      URLs.Add(url);
      TURL.Text = "";
      UpdateURLs();
    }

    // Remove URL from list.
    private void BURLRemove_Click(object sender, EventArgs e) {
      string url = TURL.Text;
      if (url == "") return;
      URLs.Remove(url);
      UpdateURLs();
    }

    // Load URLs from a text file.
    private void BURLsLoad_Click(object sender, EventArgs e) {
      DialogResult res = DURLsLoad.ShowDialog();
      if (res != DialogResult.OK) return;
      string file = DURLsLoad.FileName;
      string[] urls = File.ReadAllLines(file);
      URLs.Clear();
      URLs.AddRange(urls);
      UpdateURLs();
      Log("Loaded URLs from " + file);
    }

    // Save URLs to a text file.
    private void BURLsSave_Click(object sender, EventArgs e) {
      DialogResult res = DURLsSave.ShowDialog();
      if (res != DialogResult.OK) return;
      string file = DURLsSave.FileName;
      File.WriteAllLines(file, URLs);
      Log("Saved URLs to "+ file);
    }

    // Set Number of rounds.
    private void TRounds_Leave(object sender, EventArgs e) {
      int.TryParse(TRounds.Text, out Round.Stop);
      UpdateProgress();
    }

    // Set time a browser is kept open.
    private void TStayTime_Leave(object sender, EventArgs e) {
      double.TryParse(TStayTime.Text, out double t);
      StayTime = (int) (t * 1000);
      StayTime = StayTime <= 0 ? 4000 : StayTime;
    }

    // Set time after which a new browser can be opened.
    private void TNextTime_Leave(object sender, EventArgs e) {
      double.TryParse(TNextTime.Text, out double t);
      NextTime = (int) (t * 1000);
      NextTime = NextTime <= 0 ? 4000 : NextTime;
    }

    // Set Maximum browsers.
    private void TBrowserCount_Leave(object sender, EventArgs e) {
      int.TryParse(TBrowserCount.Text, out BrowserCount);
    }


    // Minimize application.
    private void BMin_Click(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }

    // Close application.
    private void BClose_Click(object sender, EventArgs e) {
      Close();
    }


    // Set path for Chrome.
    private void BPathChrome_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Chrome;
      SetOpenFilePath(DPickBrowser, BrowserPath[i]);
      DialogResult res = DPickBrowser.ShowDialog();
      if (res != DialogResult.OK) return;
      BrowserPath[i] = DPickBrowser.FileName;
      HighlightBrowserPath();
      SaveSettings();
    }

    // Set path for Opera.
    private void BPathOpera_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Opera;
      SetOpenFilePath(DPickBrowser, BrowserPath[i]);
      DialogResult res = DPickBrowser.ShowDialog();
      if (res != DialogResult.OK) return;
      BrowserPath[i] = DPickBrowser.FileName;
      HighlightBrowserPath();
      SaveSettings();
    }

    // Set path for Firefox.
    private void BPathFirefox_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Firefox;
      SetOpenFilePath(DPickBrowser, BrowserPath[i]);
      DialogResult res = DPickBrowser.ShowDialog();
      if (res != DialogResult.OK) return;
      BrowserPath[i] = DPickBrowser.FileName;
      HighlightBrowserPath();
      SaveSettings();
    }

    // Set path for Edge.
    private void BPathEdge_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Edge;
      SetOpenFilePath(DPickBrowser, BrowserPath[i]);
      DialogResult res = DPickBrowser.ShowDialog();
      if (res != DialogResult.OK) return;
      BrowserPath[i] = DPickBrowser.FileName;
      HighlightBrowserPath();
      SaveSettings();
    }


    // Pick Chrome (if path available).
    private void BPickChrome_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Chrome;
      if (BrowserPath[i] == "") { Log("Chrome path not given!"); return; }
      Browser = BrowserType.Chrome;
      HighlightBrowserPick(i);
    }

    // Pick Opera (if path available).
    private void BPickOpera_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Opera;
      if (BrowserPath[i] == "") { Log("Opera path not given!"); return; }
      Browser = BrowserType.Opera;
      HighlightBrowserPick(i);
    }

    // Pick Firefox (if path available).
    private void BPickFirefox_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Firefox;
      if (BrowserPath[i] == "") { Log("Firefox path not given!"); return; }
      Browser = BrowserType.Firefox;
      HighlightBrowserPick(i);
    }

    // Pick Edge (if path available).
    private void BPickEdge_Click(object sender, EventArgs e) {
      int i = (int) BrowserType.Edge;
      if (BrowserPath[i] == "") { Log("Edge path not given!"); return; }
      Browser = BrowserType.Edge;
      HighlightBrowserPick(i);
    }

    // Force Close browser?
    private void CForceClose_CheckedChanged(object sender, EventArgs e) {
      ForceClose = CForceClose.Checked;
    }
    
    // Hidden browser?
    private void CHidden_CheckedChanged(object sender, EventArgs e) {
      Hidden = CHidden.Checked;
    }


    // On Enter, add to URL list.
    private void TURL_KeyPress(object sender, KeyPressEventArgs e) {
      string url = TURL.Text;
      if (e.KeyChar == '\r' && url != "") {
        URLs.Add(url);
        UpdateURLs();
        TURL.Text = "";
        Log("Added URL.");
      }
    }


    // Update Mouse status to pressed.
    private void MainForm_MouseDown(object sender, MouseEventArgs e) {
      Mouse.LastPosition = MousePosition;
      Mouse.Pressed = true;
    }

    // Update Mouse status to unpressed.
    private void MainForm_MouseUp(object sender, MouseEventArgs e) {
      Mouse.Pressed = false;
    }

    // Move the Window.
    private void MainForm_MouseMove(object sender, MouseEventArgs e) {
      if (Mouse.Pressed) {
        Top += (MousePosition.Y - Mouse.LastPosition.Y);
        Left += (MousePosition.X - Mouse.LastPosition.X);
      }
      Mouse.LastPosition = MousePosition;
    }


    private void LoadSettings() {
      string[] ls = new string[0];
      try { ls = File.ReadAllLines(SettingsFile); }
      catch (Exception) {}
      for (int i=0; i<BrowserPath.Length; i++)
        BrowserPath[i] = ls.Length > i && ls[i] != null ? ls[i] : "";
      Log("Settings loaded.");
    }

    private void SaveSettings() {
      File.WriteAllLines(SettingsFile, BrowserPath);
      Log("Settings saved.");
    }


    private void ReadParameters() {
      int.TryParse(TRounds.Text, out Round.Stop);
      int.TryParse(TBrowserCount.Text, out BrowserCount);
      double.TryParse(TStayTime.Text, out double ts);
      double.TryParse(TNextTime.Text, out double tn);
      StayTime = (int) (ts * 1000);
      NextTime = (int) (tn * 1000);
    }


    private Process OpenBrowserProcess(string url, int i, bool hidden) {
      var p = new Process();
      var pi = p.StartInfo;
      pi.FileName = BrowserPath[i];
      pi.Arguments = BrowserParam[i] + url;
      pi.UseShellExecute = false;
      if (hidden) {
        pi.CreateNoWindow = true;
        pi.WindowStyle = ProcessWindowStyle.Hidden;
      }
      try { p.Start(); }
      catch (Exception) {}
      return p;
    }

    private int CloseBrowsers(int wait) {
      int b = (int) Browser;
      if (b == -1) return -1;
      if (wait > 0) Thread.Sleep(wait);
      if (ForceClose) CloseProcesses(BrowserName[b], true);
      else CloseProcesses(BrowserName[b], false);
      ClearBrowsers();
      return 0;
    }

    private void CloseProcesses(string name, bool kill) {
      while (true) {
        var ps = Process.GetProcessesByName(name);
        if (ps.Length == 0) break;
        foreach (var p in ps) {
          if (kill) p.Kill();
          else p.CloseMainWindow();
          p.Dispose();
        }
      }
    }

    private void ClearBrowsers() {
      foreach (var b in Browsers)
        b.Dispose();
      Browsers.Clear();
    }


    private void HighlightBrowserPick(int i) {
      foreach (var B in BPick)
        B.BackColor = Color.White;
      BPick[i].BackColor = Color.DimGray;
      Log("Using `"+BrowserName[i]+"`.");
    }

    private void HighlightBrowserPath() {
      for (int i=0; i<BPath.Length; i++)
        BPath[i].BackColor = BrowserPath[i] != "" ? Color.LightGreen : Color.White;
    }


    private void Log(string m) {
      LLog.Text = m;
    }


    private static void SetOpenFilePath(OpenFileDialog d, string p) {
      d.InitialDirectory = Path.GetDirectoryName(p);
      d.FileName = p;
    }


    private static bool ThreadIsStopped(Thread t) {
      return t == null || t.ThreadState == System.Threading.ThreadState.Stopped;
    }

    private static Thread StartThread(ThreadStart start) {
      var t = new Thread(start);
      t.IsBackground = true;
      t.Start();
      return t;
    }
  }
}
