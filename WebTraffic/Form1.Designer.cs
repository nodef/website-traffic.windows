namespace WebTraffic
{
	partial class WebTraffic
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( WebTraffic ) );
			this.fURL = new System.Windows.Forms.TextBox();
			this.dListURL = new System.Windows.Forms.Label();
			this.fStartExec = new System.Windows.Forms.Button();
			this.fProgress = new System.Windows.Forms.ProgressBar();
			this.fRounds = new System.Windows.Forms.TextBox();
			this.dRounds = new System.Windows.Forms.Label();
			this.fListURL = new System.Windows.Forms.TextBox();
			this.fStayTime = new System.Windows.Forms.TextBox();
			this.fBrowserCount = new System.Windows.Forms.TextBox();
			this.fNextTime = new System.Windows.Forms.TextBox();
			this.dWinTitle = new System.Windows.Forms.Label();
			this.fLoadListURL = new System.Windows.Forms.Button();
			this.fSaveListURL = new System.Windows.Forms.Button();
			this.fAddListURL = new System.Windows.Forms.Button();
			this.fRemoveListURL = new System.Windows.Forms.Button();
			this.dParameters = new System.Windows.Forms.Label();
			this.dStayTime = new System.Windows.Forms.Label();
			this.dNextTime = new System.Windows.Forms.Label();
			this.dBrowserCount = new System.Windows.Forms.Label();
			this.dBrowserSelect = new System.Windows.Forms.Label();
			this.fBrowserSelect_Chrome = new System.Windows.Forms.Button();
			this.fBrowserSelect_Opera = new System.Windows.Forms.Button();
			this.fBrowserSelect_Firefox = new System.Windows.Forms.Button();
			this.fBrowserSelect_IE = new System.Windows.Forms.Button();
			this.fPauseExec = new System.Windows.Forms.Button();
			this.fStopExec = new System.Windows.Forms.Button();
			this.dlgLoadListURL = new System.Windows.Forms.OpenFileDialog();
			this.dlgSaveListURL = new System.Windows.Forms.SaveFileDialog();
			this.dlgSelectBrowser = new System.Windows.Forms.OpenFileDialog();
			this.fWinMinimize = new System.Windows.Forms.Button();
			this.fWinClose = new System.Windows.Forms.Button();
			this.fBrowserPath_IE = new System.Windows.Forms.Button();
			this.fBrowserPath_Firefox = new System.Windows.Forms.Button();
			this.fBrowserPath_Opera = new System.Windows.Forms.Button();
			this.fBrowserPath_Chrome = new System.Windows.Forms.Button();
			this.dWinLogo = new System.Windows.Forms.PictureBox();
			( (System.ComponentModel.ISupportInitialize) ( this.dWinLogo ) ).BeginInit();
			this.SuspendLayout();
			// 
			// fURL
			// 
			this.fURL.Font = new System.Drawing.Font( "Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fURL.Location = new System.Drawing.Point( 445, 76 );
			this.fURL.Name = "fURL";
			this.fURL.Size = new System.Drawing.Size( 492, 21 );
			this.fURL.TabIndex = 0;
			// 
			// dListURL
			// 
			this.dListURL.AutoSize = true;
			this.dListURL.Font = new System.Drawing.Font( "Trebuchet MS", 12F, ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dListURL.Location = new System.Drawing.Point( 441, 51 );
			this.dListURL.Name = "dListURL";
			this.dListURL.Size = new System.Drawing.Size( 71, 22 );
			this.dListURL.TabIndex = 1;
			this.dListURL.Text = "URL List";
			// 
			// fStartExec
			// 
			this.fStartExec.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fStartExec.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.fStartExec.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fStartExec.Location = new System.Drawing.Point( 12, 428 );
			this.fStartExec.Name = "fStartExec";
			this.fStartExec.Size = new System.Drawing.Size( 132, 40 );
			this.fStartExec.TabIndex = 4;
			this.fStartExec.Text = "Start";
			this.fStartExec.UseVisualStyleBackColor = false;
			this.fStartExec.Click += new System.EventHandler( this.fStartExec_Click );
			// 
			// fProgress
			// 
			this.fProgress.Location = new System.Drawing.Point( 15, 383 );
			this.fProgress.Name = "fProgress";
			this.fProgress.Size = new System.Drawing.Size( 405, 23 );
			this.fProgress.TabIndex = 9;
			// 
			// fRounds
			// 
			this.fRounds.Font = new System.Drawing.Font( "Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fRounds.Location = new System.Drawing.Point( 116, 159 );
			this.fRounds.Name = "fRounds";
			this.fRounds.Size = new System.Drawing.Size( 161, 21 );
			this.fRounds.TabIndex = 12;
			this.fRounds.Text = "20";
			this.fRounds.Leave += new System.EventHandler( this.fRounds_Leave );
			// 
			// dRounds
			// 
			this.dRounds.AutoSize = true;
			this.dRounds.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dRounds.Location = new System.Drawing.Point( 12, 159 );
			this.dRounds.Name = "dRounds";
			this.dRounds.Size = new System.Drawing.Size( 55, 18 );
			this.dRounds.TabIndex = 13;
			this.dRounds.Text = "Rounds:";
			// 
			// fListURL
			// 
			this.fListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fListURL.Font = new System.Drawing.Font( "Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fListURL.Location = new System.Drawing.Point( 445, 144 );
			this.fListURL.Multiline = true;
			this.fListURL.Name = "fListURL";
			this.fListURL.ReadOnly = true;
			this.fListURL.Size = new System.Drawing.Size( 492, 278 );
			this.fListURL.TabIndex = 14;
			// 
			// fStayTime
			// 
			this.fStayTime.Font = new System.Drawing.Font( "Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fStayTime.Location = new System.Drawing.Point( 116, 211 );
			this.fStayTime.Name = "fStayTime";
			this.fStayTime.Size = new System.Drawing.Size( 161, 21 );
			this.fStayTime.TabIndex = 16;
			this.fStayTime.Text = "4";
			this.fStayTime.Leave += new System.EventHandler( this.fStayTime_Leave );
			// 
			// fBrowserCount
			// 
			this.fBrowserCount.Font = new System.Drawing.Font( "Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserCount.Location = new System.Drawing.Point( 116, 315 );
			this.fBrowserCount.Name = "fBrowserCount";
			this.fBrowserCount.Size = new System.Drawing.Size( 161, 21 );
			this.fBrowserCount.TabIndex = 18;
			this.fBrowserCount.Text = "4";
			this.fBrowserCount.Leave += new System.EventHandler( this.fBrowserCount_Leave );
			// 
			// fNextTime
			// 
			this.fNextTime.Font = new System.Drawing.Font( "Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fNextTime.Location = new System.Drawing.Point( 116, 263 );
			this.fNextTime.Name = "fNextTime";
			this.fNextTime.Size = new System.Drawing.Size( 161, 21 );
			this.fNextTime.TabIndex = 20;
			this.fNextTime.Text = "4";
			this.fNextTime.Leave += new System.EventHandler( this.fNextTime_Leave );
			// 
			// dWinTitle
			// 
			this.dWinTitle.AutoSize = true;
			this.dWinTitle.Font = new System.Drawing.Font( "Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dWinTitle.Location = new System.Drawing.Point( 84, 13 );
			this.dWinTitle.Name = "dWinTitle";
			this.dWinTitle.Size = new System.Drawing.Size( 193, 40 );
			this.dWinTitle.TabIndex = 26;
			this.dWinTitle.Text = "Web Traffic";
			// 
			// fLoadListURL
			// 
			this.fLoadListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fLoadListURL.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fLoadListURL.Location = new System.Drawing.Point( 445, 428 );
			this.fLoadListURL.Name = "fLoadListURL";
			this.fLoadListURL.Size = new System.Drawing.Size( 243, 40 );
			this.fLoadListURL.TabIndex = 29;
			this.fLoadListURL.Text = "Load URL List";
			this.fLoadListURL.UseVisualStyleBackColor = false;
			this.fLoadListURL.Click += new System.EventHandler( this.fLoadListURL_Click );
			// 
			// fSaveListURL
			// 
			this.fSaveListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fSaveListURL.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fSaveListURL.Location = new System.Drawing.Point( 694, 428 );
			this.fSaveListURL.Name = "fSaveListURL";
			this.fSaveListURL.Size = new System.Drawing.Size( 243, 40 );
			this.fSaveListURL.TabIndex = 30;
			this.fSaveListURL.Text = "Save URL List";
			this.fSaveListURL.UseVisualStyleBackColor = false;
			this.fSaveListURL.Click += new System.EventHandler( this.fSaveListURL_Click );
			// 
			// fAddListURL
			// 
			this.fAddListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fAddListURL.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fAddListURL.Location = new System.Drawing.Point( 445, 103 );
			this.fAddListURL.Name = "fAddListURL";
			this.fAddListURL.Size = new System.Drawing.Size( 243, 33 );
			this.fAddListURL.TabIndex = 31;
			this.fAddListURL.Text = "Add URL";
			this.fAddListURL.UseVisualStyleBackColor = false;
			this.fAddListURL.Click += new System.EventHandler( this.fAddListURL_Click );
			// 
			// fRemoveListURL
			// 
			this.fRemoveListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fRemoveListURL.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fRemoveListURL.Location = new System.Drawing.Point( 694, 103 );
			this.fRemoveListURL.Name = "fRemoveListURL";
			this.fRemoveListURL.Size = new System.Drawing.Size( 243, 33 );
			this.fRemoveListURL.TabIndex = 32;
			this.fRemoveListURL.Text = "Remove URL";
			this.fRemoveListURL.UseVisualStyleBackColor = false;
			this.fRemoveListURL.Click += new System.EventHandler( this.fRemoveListURL_Click );
			// 
			// dParameters
			// 
			this.dParameters.AutoSize = true;
			this.dParameters.Font = new System.Drawing.Font( "Trebuchet MS", 12F, ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dParameters.Location = new System.Drawing.Point( 8, 107 );
			this.dParameters.Name = "dParameters";
			this.dParameters.Size = new System.Drawing.Size( 96, 22 );
			this.dParameters.TabIndex = 33;
			this.dParameters.Text = "Parameters";
			// 
			// dStayTime
			// 
			this.dStayTime.AutoSize = true;
			this.dStayTime.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dStayTime.Location = new System.Drawing.Point( 12, 211 );
			this.dStayTime.Name = "dStayTime";
			this.dStayTime.Size = new System.Drawing.Size( 71, 18 );
			this.dStayTime.TabIndex = 34;
			this.dStayTime.Text = "Stay Time:";
			// 
			// dNextTime
			// 
			this.dNextTime.AutoSize = true;
			this.dNextTime.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dNextTime.Location = new System.Drawing.Point( 12, 263 );
			this.dNextTime.Name = "dNextTime";
			this.dNextTime.Size = new System.Drawing.Size( 74, 18 );
			this.dNextTime.TabIndex = 35;
			this.dNextTime.Text = "Next Time:";
			// 
			// dBrowserCount
			// 
			this.dBrowserCount.AutoSize = true;
			this.dBrowserCount.Font = new System.Drawing.Font( "Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dBrowserCount.Location = new System.Drawing.Point( 12, 315 );
			this.dBrowserCount.Name = "dBrowserCount";
			this.dBrowserCount.Size = new System.Drawing.Size( 98, 18 );
			this.dBrowserCount.TabIndex = 36;
			this.dBrowserCount.Text = "Browser Count:";
			// 
			// dBrowserSelect
			// 
			this.dBrowserSelect.AutoSize = true;
			this.dBrowserSelect.Font = new System.Drawing.Font( "Trebuchet MS", 12F, ( (System.Drawing.FontStyle) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.dBrowserSelect.Location = new System.Drawing.Point( 304, 107 );
			this.dBrowserSelect.Name = "dBrowserSelect";
			this.dBrowserSelect.Size = new System.Drawing.Size( 121, 22 );
			this.dBrowserSelect.TabIndex = 37;
			this.dBrowserSelect.Text = "Browser Select";
			// 
			// fBrowserSelect_Chrome
			// 
			this.fBrowserSelect_Chrome.BackColor = System.Drawing.Color.White;
			this.fBrowserSelect_Chrome.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserSelect_Chrome.Location = new System.Drawing.Point( 308, 144 );
			this.fBrowserSelect_Chrome.Name = "fBrowserSelect_Chrome";
			this.fBrowserSelect_Chrome.Size = new System.Drawing.Size( 30, 45 );
			this.fBrowserSelect_Chrome.TabIndex = 38;
			this.fBrowserSelect_Chrome.UseVisualStyleBackColor = false;
			this.fBrowserSelect_Chrome.Click += new System.EventHandler( this.fBrowserSelect_Chrome_Click );
			// 
			// fBrowserSelect_Opera
			// 
			this.fBrowserSelect_Opera.BackColor = System.Drawing.Color.White;
			this.fBrowserSelect_Opera.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserSelect_Opera.Location = new System.Drawing.Point( 308, 196 );
			this.fBrowserSelect_Opera.Name = "fBrowserSelect_Opera";
			this.fBrowserSelect_Opera.Size = new System.Drawing.Size( 30, 45 );
			this.fBrowserSelect_Opera.TabIndex = 39;
			this.fBrowserSelect_Opera.UseVisualStyleBackColor = false;
			this.fBrowserSelect_Opera.Click += new System.EventHandler( this.fBrowserSelect_Opera_Click );
			// 
			// fBrowserSelect_Firefox
			// 
			this.fBrowserSelect_Firefox.BackColor = System.Drawing.Color.White;
			this.fBrowserSelect_Firefox.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserSelect_Firefox.Location = new System.Drawing.Point( 308, 248 );
			this.fBrowserSelect_Firefox.Name = "fBrowserSelect_Firefox";
			this.fBrowserSelect_Firefox.Size = new System.Drawing.Size( 30, 45 );
			this.fBrowserSelect_Firefox.TabIndex = 40;
			this.fBrowserSelect_Firefox.UseVisualStyleBackColor = false;
			this.fBrowserSelect_Firefox.Click += new System.EventHandler( this.fBrowserSelect_Firefox_Click );
			// 
			// fBrowserSelect_IE
			// 
			this.fBrowserSelect_IE.BackColor = System.Drawing.Color.White;
			this.fBrowserSelect_IE.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserSelect_IE.Location = new System.Drawing.Point( 308, 300 );
			this.fBrowserSelect_IE.Name = "fBrowserSelect_IE";
			this.fBrowserSelect_IE.Size = new System.Drawing.Size( 30, 45 );
			this.fBrowserSelect_IE.TabIndex = 41;
			this.fBrowserSelect_IE.UseVisualStyleBackColor = false;
			this.fBrowserSelect_IE.Click += new System.EventHandler( this.fBrowserSelect_IE_Click );
			// 
			// fPauseExec
			// 
			this.fPauseExec.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fPauseExec.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.fPauseExec.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fPauseExec.Location = new System.Drawing.Point( 150, 428 );
			this.fPauseExec.Name = "fPauseExec";
			this.fPauseExec.Size = new System.Drawing.Size( 132, 40 );
			this.fPauseExec.TabIndex = 46;
			this.fPauseExec.Text = "Pause";
			this.fPauseExec.UseVisualStyleBackColor = false;
			this.fPauseExec.Click += new System.EventHandler( this.fPauseExec_Click );
			// 
			// fStopExec
			// 
			this.fStopExec.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fStopExec.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.fStopExec.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fStopExec.Location = new System.Drawing.Point( 288, 428 );
			this.fStopExec.Name = "fStopExec";
			this.fStopExec.Size = new System.Drawing.Size( 132, 40 );
			this.fStopExec.TabIndex = 47;
			this.fStopExec.Text = "Stop";
			this.fStopExec.UseVisualStyleBackColor = false;
			this.fStopExec.Click += new System.EventHandler( this.fStopExec_Click );
			// 
			// dlgLoadListURL
			// 
			this.dlgLoadListURL.DefaultExt = "txt";
			this.dlgLoadListURL.Filter = "URL List files|*.txt";
			this.dlgLoadListURL.Title = "Load URL List";
			// 
			// dlgSaveListURL
			// 
			this.dlgSaveListURL.DefaultExt = "txt";
			this.dlgSaveListURL.Filter = "URL List files|*.txt";
			this.dlgSaveListURL.Title = "Save URL List";
			// 
			// dlgSelectBrowser
			// 
			this.dlgSelectBrowser.DefaultExt = "exe";
			this.dlgSelectBrowser.Filter = "Browser Executables|*.exe";
			this.dlgSelectBrowser.Title = "Select Browser";
			// 
			// fWinMinimize
			// 
			this.fWinMinimize.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fWinMinimize.BackgroundImage = global::WebTraffic.Properties.Resources.minimize_btn;
			this.fWinMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fWinMinimize.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fWinMinimize.Location = new System.Drawing.Point( 895, 0 );
			this.fWinMinimize.Name = "fWinMinimize";
			this.fWinMinimize.Size = new System.Drawing.Size( 25, 25 );
			this.fWinMinimize.TabIndex = 49;
			this.fWinMinimize.UseVisualStyleBackColor = false;
			this.fWinMinimize.Click += new System.EventHandler( this.fWinMinimize_Click );
			// 
			// fWinClose
			// 
			this.fWinClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fWinClose.BackgroundImage = global::WebTraffic.Properties.Resources.close;
			this.fWinClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fWinClose.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fWinClose.Location = new System.Drawing.Point( 926, 0 );
			this.fWinClose.Name = "fWinClose";
			this.fWinClose.Size = new System.Drawing.Size( 25, 25 );
			this.fWinClose.TabIndex = 48;
			this.fWinClose.UseVisualStyleBackColor = false;
			this.fWinClose.Click += new System.EventHandler( this.fWinClose_Click );
			// 
			// fBrowserPath_IE
			// 
			this.fBrowserPath_IE.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fBrowserPath_IE.BackgroundImage = global::WebTraffic.Properties.Resources.Internet_Explorer_7_Logo_small;
			this.fBrowserPath_IE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fBrowserPath_IE.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserPath_IE.Location = new System.Drawing.Point( 343, 300 );
			this.fBrowserPath_IE.Name = "fBrowserPath_IE";
			this.fBrowserPath_IE.Size = new System.Drawing.Size( 45, 45 );
			this.fBrowserPath_IE.TabIndex = 45;
			this.fBrowserPath_IE.UseVisualStyleBackColor = false;
			this.fBrowserPath_IE.Click += new System.EventHandler( this.fBrowserPath_IE_Click );
			// 
			// fBrowserPath_Firefox
			// 
			this.fBrowserPath_Firefox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fBrowserPath_Firefox.BackgroundImage = global::WebTraffic.Properties.Resources.Firefox_icon_small;
			this.fBrowserPath_Firefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fBrowserPath_Firefox.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserPath_Firefox.Location = new System.Drawing.Point( 343, 248 );
			this.fBrowserPath_Firefox.Name = "fBrowserPath_Firefox";
			this.fBrowserPath_Firefox.Size = new System.Drawing.Size( 45, 45 );
			this.fBrowserPath_Firefox.TabIndex = 44;
			this.fBrowserPath_Firefox.UseVisualStyleBackColor = false;
			this.fBrowserPath_Firefox.Click += new System.EventHandler( this.fBrowserPath_Firefox_Click );
			// 
			// fBrowserPath_Opera
			// 
			this.fBrowserPath_Opera.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fBrowserPath_Opera.BackgroundImage = global::WebTraffic.Properties.Resources.Icon_Browser_Opera_small;
			this.fBrowserPath_Opera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fBrowserPath_Opera.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserPath_Opera.Location = new System.Drawing.Point( 343, 196 );
			this.fBrowserPath_Opera.Name = "fBrowserPath_Opera";
			this.fBrowserPath_Opera.Size = new System.Drawing.Size( 45, 45 );
			this.fBrowserPath_Opera.TabIndex = 43;
			this.fBrowserPath_Opera.UseVisualStyleBackColor = false;
			this.fBrowserPath_Opera.Click += new System.EventHandler( this.fBrowserPath_Opera_Click );
			// 
			// fBrowserPath_Chrome
			// 
			this.fBrowserPath_Chrome.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fBrowserPath_Chrome.BackgroundImage = global::WebTraffic.Properties.Resources.Chrome_small;
			this.fBrowserPath_Chrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fBrowserPath_Chrome.Font = new System.Drawing.Font( "Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.fBrowserPath_Chrome.Location = new System.Drawing.Point( 343, 144 );
			this.fBrowserPath_Chrome.Name = "fBrowserPath_Chrome";
			this.fBrowserPath_Chrome.Size = new System.Drawing.Size( 45, 45 );
			this.fBrowserPath_Chrome.TabIndex = 42;
			this.fBrowserPath_Chrome.UseVisualStyleBackColor = false;
			this.fBrowserPath_Chrome.Click += new System.EventHandler( this.fBrowserPath_Chrome_Click );
			// 
			// dWinLogo
			// 
			this.dWinLogo.BackgroundImage = global::WebTraffic.Properties.Resources.web_icon;
			this.dWinLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.dWinLogo.Location = new System.Drawing.Point( 0, 0 );
			this.dWinLogo.Name = "dWinLogo";
			this.dWinLogo.Size = new System.Drawing.Size( 77, 74 );
			this.dWinLogo.TabIndex = 25;
			this.dWinLogo.TabStop = false;
			// 
			// WebTraffic
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 952, 480 );
			this.Controls.Add( this.fWinMinimize );
			this.Controls.Add( this.fWinClose );
			this.Controls.Add( this.fStopExec );
			this.Controls.Add( this.fPauseExec );
			this.Controls.Add( this.fBrowserPath_IE );
			this.Controls.Add( this.fBrowserPath_Firefox );
			this.Controls.Add( this.fBrowserPath_Opera );
			this.Controls.Add( this.fBrowserPath_Chrome );
			this.Controls.Add( this.fBrowserSelect_IE );
			this.Controls.Add( this.fBrowserSelect_Firefox );
			this.Controls.Add( this.fBrowserSelect_Opera );
			this.Controls.Add( this.fBrowserSelect_Chrome );
			this.Controls.Add( this.dBrowserSelect );
			this.Controls.Add( this.dBrowserCount );
			this.Controls.Add( this.dNextTime );
			this.Controls.Add( this.dStayTime );
			this.Controls.Add( this.dParameters );
			this.Controls.Add( this.fRemoveListURL );
			this.Controls.Add( this.fAddListURL );
			this.Controls.Add( this.fSaveListURL );
			this.Controls.Add( this.fLoadListURL );
			this.Controls.Add( this.dWinTitle );
			this.Controls.Add( this.dWinLogo );
			this.Controls.Add( this.fNextTime );
			this.Controls.Add( this.fBrowserCount );
			this.Controls.Add( this.fStayTime );
			this.Controls.Add( this.fListURL );
			this.Controls.Add( this.dRounds );
			this.Controls.Add( this.fRounds );
			this.Controls.Add( this.fProgress );
			this.Controls.Add( this.fStartExec );
			this.Controls.Add( this.dListURL );
			this.Controls.Add( this.fURL );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.Name = "WebTraffic";
			this.Opacity = 0.95D;
			this.Text = "WebTraffic";
			this.TransparencyKey = System.Drawing.Color.Navy;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.WebTraffic_MouseDown );
			this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.WebTraffic_MouseMove );
			this.MouseUp += new System.Windows.Forms.MouseEventHandler( this.WebTraffic_MouseUp );
			( (System.ComponentModel.ISupportInitialize) ( this.dWinLogo ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fURL;
		private System.Windows.Forms.Label dListURL;
		private System.Windows.Forms.Button fStartExec;
		private System.Windows.Forms.ProgressBar fProgress;
		private System.Windows.Forms.TextBox fRounds;
		private System.Windows.Forms.Label dRounds;
		private System.Windows.Forms.TextBox fListURL;
		private System.Windows.Forms.TextBox fStayTime;
		private System.Windows.Forms.TextBox fBrowserCount;
		private System.Windows.Forms.TextBox fNextTime;
		private System.Windows.Forms.PictureBox dWinLogo;
		private System.Windows.Forms.Label dWinTitle;
		private System.Windows.Forms.Button fLoadListURL;
		private System.Windows.Forms.Button fSaveListURL;
		private System.Windows.Forms.Button fAddListURL;
		private System.Windows.Forms.Button fRemoveListURL;
		private System.Windows.Forms.Label dParameters;
		private System.Windows.Forms.Label dStayTime;
		private System.Windows.Forms.Label dNextTime;
		private System.Windows.Forms.Label dBrowserCount;
		private System.Windows.Forms.Label dBrowserSelect;
		private System.Windows.Forms.Button fBrowserSelect_Chrome;
		private System.Windows.Forms.Button fBrowserSelect_Opera;
		private System.Windows.Forms.Button fBrowserSelect_Firefox;
		private System.Windows.Forms.Button fBrowserSelect_IE;
		private System.Windows.Forms.Button fBrowserPath_Chrome;
		private System.Windows.Forms.Button fBrowserPath_Opera;
		private System.Windows.Forms.Button fBrowserPath_Firefox;
		private System.Windows.Forms.Button fBrowserPath_IE;
		private System.Windows.Forms.Button fPauseExec;
		private System.Windows.Forms.Button fStopExec;
		private System.Windows.Forms.Button fWinClose;
		private System.Windows.Forms.Button fWinMinimize;
		private System.Windows.Forms.OpenFileDialog dlgLoadListURL;
		private System.Windows.Forms.SaveFileDialog dlgSaveListURL;
		private System.Windows.Forms.OpenFileDialog dlgSelectBrowser;
	}
}

