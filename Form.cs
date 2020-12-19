using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace WebTraffic {
  public struct Round	{
    public int	Start;
    public int  Current;
    public int	Stop;
  };

  public struct MouseStatus	{
    public bool   Pressed;
    public Point  LastPosition;
  };

  public enum Browser : int	{
    None    = -1,
    Chrome  = 0,
    Opera   = 1,
    Firefox = 2,
    IE      = 3
  };


  public partial class WebTraffic : Form {
    WebTraffic		window;
    Thread        threadExec;
    List<string>	listURL;
    Round				round;
    Browser     browser;
    List<Process>	browserProc;
    string[]      browserParam;
    string[]      browserName;
    string[]      browserPath;
    bool          browserForceClose;
    bool          execPaused;
    int           stayTime;
    int           nextTime;
    int           browserCount;
    string        settingsFile;
    MouseStatus	mouseStatus;

    // create new form instance
    public WebTraffic () {
      string[] strTemp = new string[4];

      InitializeComponent();
      window = this;
      browserProc = new List<Process>();
      listURL = new List<string>();
      threadExec = null;
      browserParam = new string[4];
      browserParam[(int) Browser.Chrome] = "--new-window ";
      browserParam[(int) Browser.Opera] = "-newprivatetab ";
      browserParam[(int) Browser.Firefox] = "-private -new-tab ";
      browserParam[(int) Browser.IE] = "-private ";
      browserName = new string[4];
      browserName[(int) Browser.Chrome] = "chrome";
      browserName[(int) Browser.Opera] = "opera";
      browserName[(int) Browser.Firefox] = "firefox";
      browserName[(int) Browser.IE] = "iexplore";
      browser = Browser.None;
      // get browser path settings
      settingsFile = "settings.ini";
      try { strTemp = File.ReadAllLines( settingsFile ); }
      catch (Exception) { }
      browserPath = new string[4];
      for (int i=0 ; i < 4 ; i++) {
        if (strTemp.Length > i && strTemp[i] != null) browserPath[i] = strTemp[i];
        else browserPath[i] = "";
      }
      execPaused = false;
      fPause.Enabled = false;
      mouseStatus.Pressed = false;
      mouseStatus.LastPosition = MousePosition;
      browserForceClose = fBrowserForceClose.Checked;
    }

    // start thread execution
    private int StartExec () {
      if (browser == Browser.None) return -1;
      // update changing parameters
      round.Start = 0;
      round.Current = 0;
      try {
        round.Stop = int.Parse( fRounds.Text );
        stayTime = (int) ( double.Parse( fStayTime.Text ) * 1000 );
        nextTime = (int) ( double.Parse( fNextTime.Text ) * 1000 );
        browserCount = int.Parse( fBrowserCount.Text );
      }
      catch (Exception) { }
      UpdateProgress();
      fStart.Enabled = false;
      fPause.Enabled = true;
      // start exec thread
      if (threadExec == null || threadExec.ThreadState == System.Threading.ThreadState.Stopped) {
        CloseBrowsers(true);
        threadExec = new Thread( () => Exec( listURL ) );
        threadExec.Name = "WebTraffic_Exec";
        threadExec.IsBackground = true;
        threadExec.Start();
        return 0;
      }
      return -1;
    }

    // stop thread execution
    private int StopExec () {
      // stop exec thread
      if (threadExec == null) return -1;
      threadExec.Abort();
      threadExec = null;
      CloseBrowsers(true);
      fPause.Enabled = false;
      fStart.Enabled = true;
      return 0;
    }

    // execution thread
    private void Exec (List<string> list_url) {
      int i, j;

      while (round.Current < round.Stop) {
        while (execPaused || list_url.Count == 0) { Thread.Sleep( 2000 ); }
        for (i = 0, j = 0 ; i < listURL.Count ; i++) {
          j += ( AccessURL( listURL[i] ) == 0 ) ? 1 : 0;
        }
        if (listURL.Count > 0 && j == listURL.Count) {
          round.Current++;
          UpdateProgress();
        }
      }
      CloseBrowsers(false);
      RefreshExec();
    }

    // close all running browsers
    private int CloseBrowsers (bool quick_close) {
      int i;
      Process[] p;

      if (browser == Browser.None) return -1;
      if(!quick_close) Thread.Sleep( stayTime );
      // close all browser processes forcibly
      if (browserForceClose) {
        p = Process.GetProcessesByName( browserName[(int) browser] );
        for (i = 0 ; i < p.Length ; i++) {
          p[i].Kill();
          p[i].Dispose();
        }
      }
      // close all browser processes normally (through repeated trying)
      else {
        while (( p = Process.GetProcessesByName( browserName[(int) browser] ) ).Length > 0) {
          for (i = 0 ; i < p.Length ; i++) {
            p[i].CloseMainWindow();
            p[i].Dispose();
          }
        }
      }
      // free browser process resources
      for (i = 0 ; i < browserProc.Count ; i++) {
        browserProc[i].Dispose();
      }
      browserProc.RemoveAll( browser => true );
      return 0;
    }

    // access a particular url for a duration using browser
    private int AccessURL (string url) {
      Process p = new Process();

      if (browser == Browser.None) return -1;
      p.StartInfo.FileName = browserPath[(int) browser];
      p.StartInfo.Arguments = browserParam[(int) browser] + url;
      p.StartInfo.CreateNoWindow = true;
      p.StartInfo.UseShellExecute = false;
      p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
      try { p.Start(); }
      catch (Exception) { }
      if (p != null) browserProc.Add( p );
      if (browserProc.Count < browserCount) Thread.Sleep( nextTime );
      else CloseBrowsers(false);
      return 0;
    }

    // upon start, start thread
    private void fStartExec_Click (object sender, EventArgs e) {
      StartExec();
    }

    // upon stop, stop thread
    private void fStopExec_Click (object sender, EventArgs e) {
      StopExec();
    }

    // upon pause, stop thread, upon resume, start thread
    private void fPauseExec_Click (object sender, EventArgs e) {
      execPaused = !execPaused;
      if (execPaused) fPause.Text = "Resume";
      else fPause.Text = "Pause";
    }

    // updates the list url
    public void UpdateListURL () {
      int i;
      string str = "";

      for (i = 0 ; i < listURL.Count ; i++) {
        str += listURL[i] + "\r\n";
      }
      if(fListURL.Text != str) fListURL.Text = str;
    }

    // update progress bar
    public void UpdateProgress () {
      if (this.InvokeRequired) {
        this.Invoke( new MethodInvoker( UpdateProgress ) );
      }
      else {
        // update progress bar
        if (fProgress.Minimum != round.Start) fProgress.Minimum = round.Start;
        if (fProgress.Maximum != round.Stop) fProgress.Maximum = round.Stop;
        if (fProgress.Value != round.Current) fProgress.Value = round.Current;
      }
    }

    // hide pause button
    public void RefreshExec () {
      if (this.InvokeRequired) {
        this.Invoke( new MethodInvoker( RefreshExec ) );
      }
      else {
        fPause.Text = "Pause";
        fPause.Enabled = false;
        fStart.Enabled = true;
      }
    }

    // add url to list
    private void fAddListURL_Click (object sender, EventArgs e) {
      if (fURL.Text.Length > 0)
      {
        listURL.Add( fURL.Text );
        fURL.Text = "";
        UpdateListURL();
      }
    }

    // remove url from list
    private void fRemoveListURL_Click (object sender, EventArgs e) {
      if (fURL.Text.Length > 0)
      {
        listURL.Remove( fURL.Text );
        UpdateListURL();
      }
    }

    // load url list from a text file
    private void fLoadListURL_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgLoadListURL.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      string[] list = File.ReadAllLines( dlgLoadListURL.FileName );
      listURL.RemoveAll( url => true );
      listURL.AddRange( list );
      UpdateListURL();
    }

    // save url list to a text file
    private void fSaveListURL_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgSaveListURL.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      File.WriteAllLines( dlgSaveListURL.FileName, listURL );
    }

    // update access rounds upon focus change
    private void fRounds_Leave (object sender, EventArgs e) {
      int.TryParse( fRounds.Text, out round.Stop );
      UpdateProgress();
    }

    // update stay time upon focus change
    private void fStayTime_Leave (object sender, EventArgs e) {
      double temp;

      double.TryParse( fStayTime.Text, out temp );
      stayTime = (int) ( temp * 1000 );
      stayTime = ( stayTime <= 0 ) ? 4000 : stayTime;
    }

    // update next time upon focus change
    private void fNextTime_Leave (object sender, EventArgs e) {
      double temp;

      double.TryParse( fNextTime.Text, out temp );
      nextTime = (int) ( temp * 1000 );
      nextTime = ( nextTime <= 0 ) ? 4000 : nextTime;
    }

    // update browser count upon focus change
    private void fBrowserCount_Leave (object sender, EventArgs e) {
      int.TryParse( fBrowserCount.Text, out browserCount );
    }

    // internal minimize button
    private void fWinMinimize_Click (object sender, EventArgs e) {
      window.WindowState = FormWindowState.Minimized;
    }

    // internal close button
    private void fWinClose_Click (object sender, EventArgs e) {
      window.Close();
    }

    // select path for chrome browser
    private void fBrowserPath_Chrome_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgSelectBrowser.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      browserPath[(int) Browser.Chrome] = dlgSelectBrowser.FileName;
      File.WriteAllLines( settingsFile, browserPath );
    }

    // select path for opera browser
    private void fBrowserPath_Opera_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgSelectBrowser.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      browserPath[(int) Browser.Opera] = dlgSelectBrowser.FileName;
      File.WriteAllLines( settingsFile, browserPath );
    }

    // select path for firefox browser
    private void fBrowserPath_Firefox_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgSelectBrowser.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      browserPath[(int) Browser.Firefox] = dlgSelectBrowser.FileName;
      File.WriteAllLines( settingsFile, browserPath );
    }

    // select path for ie browser
    private void fBrowserPath_IE_Click (object sender, EventArgs e) {
      DialogResult dRslt = dlgSelectBrowser.ShowDialog();
      if (dRslt != System.Windows.Forms.DialogResult.OK) return;
      browserPath[(int) Browser.IE] = dlgSelectBrowser.FileName;
      File.WriteAllLines( settingsFile, browserPath );
    }

    // select chrome browser (if path available)
    private void fBrowserSelect_Chrome_Click (object sender, EventArgs e) {
      if (browserPath[(int) Browser.Chrome] == "") return;
      browser = Browser.Chrome;
      fBrowserSelect_Chrome.BackColor = Color.DimGray;
      fBrowserSelect_Opera.BackColor = Color.White;
      fBrowserSelect_Firefox.BackColor = Color.White;
      fBrowserSelect_IE.BackColor = Color.White;
    }

    // select opera browser (if path available)
    private void fBrowserSelect_Opera_Click (object sender, EventArgs e) {
      if (browserPath[(int) Browser.Opera] == "") return;
      browser = Browser.Opera;
      fBrowserSelect_Opera.BackColor = Color.DimGray;
      fBrowserSelect_Chrome.BackColor = Color.White;
      fBrowserSelect_Firefox.BackColor = Color.White;
      fBrowserSelect_IE.BackColor = Color.White;
    }

    // select firefox browser (if path available)
    private void fBrowserSelect_Firefox_Click (object sender, EventArgs e) {
      if (browserPath[(int) Browser.Firefox] == "") return;
      browser = Browser.Firefox;
      fBrowserSelect_Firefox.BackColor = Color.DimGray;
      fBrowserSelect_Chrome.BackColor = Color.White;
      fBrowserSelect_Opera.BackColor = Color.White;
      fBrowserSelect_IE.BackColor = Color.White;
    }

    // select ie browser (if path available)
    private void fBrowserSelect_IE_Click (object sender, EventArgs e) {
      if (browserPath[(int) Browser.IE] == "") return;
      browser = Browser.IE;
      fBrowserSelect_IE.BackColor = Color.DimGray;
      fBrowserSelect_Chrome.BackColor = Color.White;
      fBrowserSelect_Opera.BackColor = Color.White;
      fBrowserSelect_Firefox.BackColor = Color.White;
    }

    // updates mouse status to pressed
    private void WebTraffic_MouseDown (object sender, MouseEventArgs e) {
      mouseStatus.Pressed = true;
      mouseStatus.LastPosition = MousePosition;
    }

    // updates mouse status to left
    private void WebTraffic_MouseUp (object sender, MouseEventArgs e) {
      mouseStatus.Pressed = false;
    }

    // moves the window
    private void WebTraffic_MouseMove (object sender, MouseEventArgs e) {
      if (mouseStatus.Pressed) {
        Top += ( MousePosition.Y - mouseStatus.LastPosition.Y );
        Left += ( MousePosition.X - mouseStatus.LastPosition.X );
      }
      mouseStatus.LastPosition = MousePosition;
    }

    // select force close option or not
    private void fBrowserForceClose_CheckedChanged (object sender, EventArgs e) {
      browserForceClose = fBrowserForceClose.Checked;
    }

    // if enter key is pressed, add to url list
    private void fURL_KeyPress (object sender, KeyPressEventArgs e) {
      if (e.KeyChar == '\r' && fURL.Text.Length > 0) {
        listURL.Add( fURL.Text );
        fURL.Text = "";
        UpdateListURL();
      }
    }
  }
}
