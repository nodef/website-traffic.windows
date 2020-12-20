namespace WebsiteTraffic
{
	partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.TURL = new System.Windows.Forms.TextBox();
      this.LURLs = new System.Windows.Forms.Label();
      this.BStart = new System.Windows.Forms.Button();
      this.LProgress = new System.Windows.Forms.ProgressBar();
      this.TRounds = new System.Windows.Forms.TextBox();
      this.LRounds = new System.Windows.Forms.Label();
      this.TURLs = new System.Windows.Forms.TextBox();
      this.TStayTime = new System.Windows.Forms.TextBox();
      this.TBrowserCount = new System.Windows.Forms.TextBox();
      this.TNextTime = new System.Windows.Forms.TextBox();
      this.LTitle = new System.Windows.Forms.Label();
      this.BURLsLoad = new System.Windows.Forms.Button();
      this.BURLsSave = new System.Windows.Forms.Button();
      this.BURLAdd = new System.Windows.Forms.Button();
      this.BURLRemove = new System.Windows.Forms.Button();
      this.LParameters = new System.Windows.Forms.Label();
      this.LStayTime = new System.Windows.Forms.Label();
      this.LNextTime = new System.Windows.Forms.Label();
      this.LBrowserCount = new System.Windows.Forms.Label();
      this.LBrowsers = new System.Windows.Forms.Label();
      this.BPickChrome = new System.Windows.Forms.Button();
      this.BPickOpera = new System.Windows.Forms.Button();
      this.BPickFirefox = new System.Windows.Forms.Button();
      this.BPickEdge = new System.Windows.Forms.Button();
      this.BPause = new System.Windows.Forms.Button();
      this.BStop = new System.Windows.Forms.Button();
      this.DURLsLoad = new System.Windows.Forms.OpenFileDialog();
      this.DURLsSave = new System.Windows.Forms.SaveFileDialog();
      this.DPickBrowser = new System.Windows.Forms.OpenFileDialog();
      this.BMin = new System.Windows.Forms.Button();
      this.BClose = new System.Windows.Forms.Button();
      this.BPathEdge = new System.Windows.Forms.Button();
      this.BPathFirefox = new System.Windows.Forms.Button();
      this.BPathOpera = new System.Windows.Forms.Button();
      this.BPathChrome = new System.Windows.Forms.Button();
      this.LLogo = new System.Windows.Forms.PictureBox();
      this.CForceClose = new System.Windows.Forms.CheckBox();
      this.CHidden = new System.Windows.Forms.CheckBox();
      this.LLog = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.LLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // TURL
      // 
      this.TURL.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TURL.Location = new System.Drawing.Point(445, 76);
      this.TURL.Name = "TURL";
      this.TURL.Size = new System.Drawing.Size(492, 21);
      this.TURL.TabIndex = 0;
      this.TURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TURL_KeyPress);
      // 
      // LURLs
      // 
      this.LURLs.AutoSize = true;
      this.LURLs.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LURLs.Location = new System.Drawing.Point(441, 51);
      this.LURLs.Name = "LURLs";
      this.LURLs.Size = new System.Drawing.Size(71, 22);
      this.LURLs.TabIndex = 1;
      this.LURLs.Text = "URL List";
      // 
      // BStart
      // 
      this.BStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.BStart.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BStart.Location = new System.Drawing.Point(12, 428);
      this.BStart.Name = "BStart";
      this.BStart.Size = new System.Drawing.Size(132, 40);
      this.BStart.TabIndex = 4;
      this.BStart.Text = "Start";
      this.BStart.UseVisualStyleBackColor = false;
      this.BStart.Click += new System.EventHandler(this.BStart_Click);
      // 
      // LProgress
      // 
      this.LProgress.Location = new System.Drawing.Point(15, 383);
      this.LProgress.Name = "LProgress";
      this.LProgress.Size = new System.Drawing.Size(405, 23);
      this.LProgress.TabIndex = 9;
      // 
      // TRounds
      // 
      this.TRounds.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TRounds.Location = new System.Drawing.Point(116, 159);
      this.TRounds.Name = "TRounds";
      this.TRounds.Size = new System.Drawing.Size(161, 21);
      this.TRounds.TabIndex = 12;
      this.TRounds.Text = "128";
      this.TRounds.Leave += new System.EventHandler(this.TRounds_Leave);
      // 
      // LRounds
      // 
      this.LRounds.AutoSize = true;
      this.LRounds.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LRounds.Location = new System.Drawing.Point(12, 159);
      this.LRounds.Name = "LRounds";
      this.LRounds.Size = new System.Drawing.Size(55, 18);
      this.LRounds.TabIndex = 13;
      this.LRounds.Text = "Rounds:";
      // 
      // TURLs
      // 
      this.TURLs.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.TURLs.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TURLs.Location = new System.Drawing.Point(445, 144);
      this.TURLs.Multiline = true;
      this.TURLs.Name = "TURLs";
      this.TURLs.ReadOnly = true;
      this.TURLs.Size = new System.Drawing.Size(492, 278);
      this.TURLs.TabIndex = 14;
      // 
      // TStayTime
      // 
      this.TStayTime.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TStayTime.Location = new System.Drawing.Point(116, 196);
      this.TStayTime.Name = "TStayTime";
      this.TStayTime.Size = new System.Drawing.Size(161, 21);
      this.TStayTime.TabIndex = 16;
      this.TStayTime.Text = "32";
      this.TStayTime.Leave += new System.EventHandler(this.TStayTime_Leave);
      // 
      // TBrowserCount
      // 
      this.TBrowserCount.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TBrowserCount.Location = new System.Drawing.Point(116, 275);
      this.TBrowserCount.Name = "TBrowserCount";
      this.TBrowserCount.Size = new System.Drawing.Size(161, 21);
      this.TBrowserCount.TabIndex = 18;
      this.TBrowserCount.Text = "4";
      this.TBrowserCount.Leave += new System.EventHandler(this.TBrowserCount_Leave);
      // 
      // TNextTime
      // 
      this.TNextTime.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TNextTime.Location = new System.Drawing.Point(116, 235);
      this.TNextTime.Name = "TNextTime";
      this.TNextTime.Size = new System.Drawing.Size(161, 21);
      this.TNextTime.TabIndex = 20;
      this.TNextTime.Text = "4";
      this.TNextTime.Leave += new System.EventHandler(this.TNextTime_Leave);
      // 
      // LTitle
      // 
      this.LTitle.AutoSize = true;
      this.LTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LTitle.Location = new System.Drawing.Point(96, 33);
      this.LTitle.Name = "LTitle";
      this.LTitle.Size = new System.Drawing.Size(242, 40);
      this.LTitle.TabIndex = 26;
      this.LTitle.Text = "Website Traffic";
      // 
      // BURLsLoad
      // 
      this.BURLsLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BURLsLoad.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BURLsLoad.Location = new System.Drawing.Point(445, 428);
      this.BURLsLoad.Name = "BURLsLoad";
      this.BURLsLoad.Size = new System.Drawing.Size(243, 40);
      this.BURLsLoad.TabIndex = 29;
      this.BURLsLoad.Text = "Load URL List";
      this.BURLsLoad.UseVisualStyleBackColor = false;
      this.BURLsLoad.Click += new System.EventHandler(this.BURLsLoad_Click);
      // 
      // BURLsSave
      // 
      this.BURLsSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BURLsSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BURLsSave.Location = new System.Drawing.Point(694, 428);
      this.BURLsSave.Name = "BURLsSave";
      this.BURLsSave.Size = new System.Drawing.Size(243, 40);
      this.BURLsSave.TabIndex = 30;
      this.BURLsSave.Text = "Save URL List";
      this.BURLsSave.UseVisualStyleBackColor = false;
      this.BURLsSave.Click += new System.EventHandler(this.BURLsSave_Click);
      // 
      // BURLAdd
      // 
      this.BURLAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BURLAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BURLAdd.Location = new System.Drawing.Point(445, 103);
      this.BURLAdd.Name = "BURLAdd";
      this.BURLAdd.Size = new System.Drawing.Size(243, 33);
      this.BURLAdd.TabIndex = 31;
      this.BURLAdd.Text = "Add URL";
      this.BURLAdd.UseVisualStyleBackColor = false;
      this.BURLAdd.Click += new System.EventHandler(this.BURLAdd_Click);
      // 
      // BURLRemove
      // 
      this.BURLRemove.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BURLRemove.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BURLRemove.Location = new System.Drawing.Point(694, 103);
      this.BURLRemove.Name = "BURLRemove";
      this.BURLRemove.Size = new System.Drawing.Size(243, 33);
      this.BURLRemove.TabIndex = 32;
      this.BURLRemove.Text = "Remove URL";
      this.BURLRemove.UseVisualStyleBackColor = false;
      this.BURLRemove.Click += new System.EventHandler(this.BURLRemove_Click);
      // 
      // LParameters
      // 
      this.LParameters.AutoSize = true;
      this.LParameters.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LParameters.Location = new System.Drawing.Point(8, 107);
      this.LParameters.Name = "LParameters";
      this.LParameters.Size = new System.Drawing.Size(96, 22);
      this.LParameters.TabIndex = 33;
      this.LParameters.Text = "Parameters";
      // 
      // LStayTime
      // 
      this.LStayTime.AutoSize = true;
      this.LStayTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LStayTime.Location = new System.Drawing.Point(12, 196);
      this.LStayTime.Name = "LStayTime";
      this.LStayTime.Size = new System.Drawing.Size(71, 18);
      this.LStayTime.TabIndex = 34;
      this.LStayTime.Text = "Stay Time:";
      // 
      // LNextTime
      // 
      this.LNextTime.AutoSize = true;
      this.LNextTime.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LNextTime.Location = new System.Drawing.Point(12, 235);
      this.LNextTime.Name = "LNextTime";
      this.LNextTime.Size = new System.Drawing.Size(74, 18);
      this.LNextTime.TabIndex = 35;
      this.LNextTime.Text = "Next Time:";
      // 
      // LBrowserCount
      // 
      this.LBrowserCount.AutoSize = true;
      this.LBrowserCount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LBrowserCount.Location = new System.Drawing.Point(12, 275);
      this.LBrowserCount.Name = "LBrowserCount";
      this.LBrowserCount.Size = new System.Drawing.Size(98, 18);
      this.LBrowserCount.TabIndex = 36;
      this.LBrowserCount.Text = "Browser Count:";
      // 
      // LBrowsers
      // 
      this.LBrowsers.AutoSize = true;
      this.LBrowsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LBrowsers.Location = new System.Drawing.Point(304, 107);
      this.LBrowsers.Name = "LBrowsers";
      this.LBrowsers.Size = new System.Drawing.Size(121, 22);
      this.LBrowsers.TabIndex = 37;
      this.LBrowsers.Text = "Browser Select";
      // 
      // BPickChrome
      // 
      this.BPickChrome.BackColor = System.Drawing.Color.White;
      this.BPickChrome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPickChrome.Location = new System.Drawing.Point(308, 144);
      this.BPickChrome.Name = "BPickChrome";
      this.BPickChrome.Size = new System.Drawing.Size(30, 45);
      this.BPickChrome.TabIndex = 38;
      this.BPickChrome.UseVisualStyleBackColor = false;
      this.BPickChrome.Click += new System.EventHandler(this.BPickChrome_Click);
      // 
      // BPickOpera
      // 
      this.BPickOpera.BackColor = System.Drawing.Color.White;
      this.BPickOpera.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPickOpera.Location = new System.Drawing.Point(308, 196);
      this.BPickOpera.Name = "BPickOpera";
      this.BPickOpera.Size = new System.Drawing.Size(30, 45);
      this.BPickOpera.TabIndex = 39;
      this.BPickOpera.UseVisualStyleBackColor = false;
      this.BPickOpera.Click += new System.EventHandler(this.BPickOpera_Click);
      // 
      // BPickFirefox
      // 
      this.BPickFirefox.BackColor = System.Drawing.Color.White;
      this.BPickFirefox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPickFirefox.Location = new System.Drawing.Point(308, 248);
      this.BPickFirefox.Name = "BPickFirefox";
      this.BPickFirefox.Size = new System.Drawing.Size(30, 45);
      this.BPickFirefox.TabIndex = 40;
      this.BPickFirefox.UseVisualStyleBackColor = false;
      this.BPickFirefox.Click += new System.EventHandler(this.BPickFirefox_Click);
      // 
      // BPickEdge
      // 
      this.BPickEdge.BackColor = System.Drawing.Color.White;
      this.BPickEdge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPickEdge.Location = new System.Drawing.Point(308, 300);
      this.BPickEdge.Name = "BPickEdge";
      this.BPickEdge.Size = new System.Drawing.Size(30, 45);
      this.BPickEdge.TabIndex = 41;
      this.BPickEdge.UseVisualStyleBackColor = false;
      this.BPickEdge.Click += new System.EventHandler(this.BPickEdge_Click);
      // 
      // BPause
      // 
      this.BPause.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.BPause.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPause.Location = new System.Drawing.Point(150, 428);
      this.BPause.Name = "BPause";
      this.BPause.Size = new System.Drawing.Size(132, 40);
      this.BPause.TabIndex = 46;
      this.BPause.Text = "Pause";
      this.BPause.UseVisualStyleBackColor = false;
      this.BPause.Click += new System.EventHandler(this.BPause_Click);
      // 
      // BStop
      // 
      this.BStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.BStop.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BStop.Location = new System.Drawing.Point(288, 428);
      this.BStop.Name = "BStop";
      this.BStop.Size = new System.Drawing.Size(132, 40);
      this.BStop.TabIndex = 47;
      this.BStop.Text = "Stop";
      this.BStop.UseVisualStyleBackColor = false;
      this.BStop.Click += new System.EventHandler(this.BStop_Click);
      // 
      // DURLsLoad
      // 
      this.DURLsLoad.DefaultExt = "txt";
      this.DURLsLoad.Filter = "URL List files|*.txt";
      this.DURLsLoad.Title = "Load URL List";
      // 
      // DURLsSave
      // 
      this.DURLsSave.DefaultExt = "txt";
      this.DURLsSave.Filter = "URL List files|*.txt";
      this.DURLsSave.Title = "Save URL List";
      // 
      // DPickBrowser
      // 
      this.DPickBrowser.DefaultExt = "exe";
      this.DPickBrowser.Filter = "Browser Executables|*.exe";
      this.DPickBrowser.Title = "Select Browser";
      // 
      // BMin
      // 
      this.BMin.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BMin.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BtnMin;
      this.BMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BMin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BMin.Location = new System.Drawing.Point(895, 0);
      this.BMin.Name = "BMin";
      this.BMin.Size = new System.Drawing.Size(25, 25);
      this.BMin.TabIndex = 49;
      this.BMin.UseVisualStyleBackColor = false;
      this.BMin.Click += new System.EventHandler(this.BMin_Click);
      // 
      // BClose
      // 
      this.BClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BClose.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BtnClose;
      this.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BClose.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BClose.Location = new System.Drawing.Point(926, 0);
      this.BClose.Name = "BClose";
      this.BClose.Size = new System.Drawing.Size(25, 25);
      this.BClose.TabIndex = 48;
      this.BClose.UseVisualStyleBackColor = false;
      this.BClose.Click += new System.EventHandler(this.BClose_Click);
      // 
      // BPathEdge
      // 
      this.BPathEdge.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BPathEdge.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BrEdge_s;
      this.BPathEdge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BPathEdge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPathEdge.Location = new System.Drawing.Point(343, 300);
      this.BPathEdge.Name = "BPathEdge";
      this.BPathEdge.Size = new System.Drawing.Size(45, 45);
      this.BPathEdge.TabIndex = 45;
      this.BPathEdge.UseVisualStyleBackColor = false;
      this.BPathEdge.Click += new System.EventHandler(this.BPathEdge_Click);
      // 
      // BPathFirefox
      // 
      this.BPathFirefox.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BPathFirefox.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BrFirefox_s;
      this.BPathFirefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BPathFirefox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPathFirefox.Location = new System.Drawing.Point(343, 248);
      this.BPathFirefox.Name = "BPathFirefox";
      this.BPathFirefox.Size = new System.Drawing.Size(45, 45);
      this.BPathFirefox.TabIndex = 44;
      this.BPathFirefox.UseVisualStyleBackColor = false;
      this.BPathFirefox.Click += new System.EventHandler(this.BPathFirefox_Click);
      // 
      // BPathOpera
      // 
      this.BPathOpera.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BPathOpera.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BrOpera_s;
      this.BPathOpera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BPathOpera.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPathOpera.Location = new System.Drawing.Point(343, 196);
      this.BPathOpera.Name = "BPathOpera";
      this.BPathOpera.Size = new System.Drawing.Size(45, 45);
      this.BPathOpera.TabIndex = 43;
      this.BPathOpera.UseVisualStyleBackColor = false;
      this.BPathOpera.Click += new System.EventHandler(this.BPathOpera_Click);
      // 
      // BPathChrome
      // 
      this.BPathChrome.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.BPathChrome.BackgroundImage = global::WebsiteTraffic.Properties.Resources.BrChrome_s;
      this.BPathChrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.BPathChrome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BPathChrome.Location = new System.Drawing.Point(343, 144);
      this.BPathChrome.Name = "BPathChrome";
      this.BPathChrome.Size = new System.Drawing.Size(45, 45);
      this.BPathChrome.TabIndex = 42;
      this.BPathChrome.UseVisualStyleBackColor = false;
      this.BPathChrome.Click += new System.EventHandler(this.BPathChrome_Click);
      // 
      // LLogo
      // 
      this.LLogo.BackgroundImage = global::WebsiteTraffic.Properties.Resources.Icon;
      this.LLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.LLogo.Location = new System.Drawing.Point(12, 12);
      this.LLogo.Name = "LLogo";
      this.LLogo.Size = new System.Drawing.Size(77, 74);
      this.LLogo.TabIndex = 25;
      this.LLogo.TabStop = false;
      // 
      // CForceClose
      // 
      this.CForceClose.AutoSize = true;
      this.CForceClose.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CForceClose.Location = new System.Drawing.Point(15, 316);
      this.CForceClose.Name = "CForceClose";
      this.CForceClose.Size = new System.Drawing.Size(204, 22);
      this.CForceClose.TabIndex = 50;
      this.CForceClose.Text = "Forcibly close browser windows";
      this.CForceClose.UseVisualStyleBackColor = true;
      this.CForceClose.CheckedChanged += new System.EventHandler(this.CForceClose_CheckedChanged);
      // 
      // CHidden
      // 
      this.CHidden.AutoSize = true;
      this.CHidden.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CHidden.Location = new System.Drawing.Point(15, 344);
      this.CHidden.Name = "CHidden";
      this.CHidden.Size = new System.Drawing.Size(152, 22);
      this.CHidden.TabIndex = 51;
      this.CHidden.Text = "Hide browser windows";
      this.CHidden.UseVisualStyleBackColor = true;
      this.CHidden.CheckedChanged += new System.EventHandler(this.CHidden_CheckedChanged);
      // 
      // LLog
      // 
      this.LLog.AutoSize = true;
      this.LLog.Location = new System.Drawing.Point(12, 475);
      this.LLog.Name = "LLog";
      this.LLog.Size = new System.Drawing.Size(38, 13);
      this.LLog.TabIndex = 52;
      this.LLog.Text = "Ready";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(952, 498);
      this.Controls.Add(this.LLog);
      this.Controls.Add(this.CHidden);
      this.Controls.Add(this.CForceClose);
      this.Controls.Add(this.BMin);
      this.Controls.Add(this.BClose);
      this.Controls.Add(this.BStop);
      this.Controls.Add(this.BPause);
      this.Controls.Add(this.BPathEdge);
      this.Controls.Add(this.BPathFirefox);
      this.Controls.Add(this.BPathOpera);
      this.Controls.Add(this.BPathChrome);
      this.Controls.Add(this.BPickEdge);
      this.Controls.Add(this.BPickFirefox);
      this.Controls.Add(this.BPickOpera);
      this.Controls.Add(this.BPickChrome);
      this.Controls.Add(this.LBrowsers);
      this.Controls.Add(this.LBrowserCount);
      this.Controls.Add(this.LNextTime);
      this.Controls.Add(this.LStayTime);
      this.Controls.Add(this.LParameters);
      this.Controls.Add(this.BURLRemove);
      this.Controls.Add(this.BURLAdd);
      this.Controls.Add(this.BURLsSave);
      this.Controls.Add(this.BURLsLoad);
      this.Controls.Add(this.LTitle);
      this.Controls.Add(this.LLogo);
      this.Controls.Add(this.TNextTime);
      this.Controls.Add(this.TBrowserCount);
      this.Controls.Add(this.TStayTime);
      this.Controls.Add(this.TURLs);
      this.Controls.Add(this.LRounds);
      this.Controls.Add(this.TRounds);
      this.Controls.Add(this.LProgress);
      this.Controls.Add(this.BStart);
      this.Controls.Add(this.LURLs);
      this.Controls.Add(this.TURL);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Opacity = 0.95D;
      this.Text = "WebsiteTraffic";
      this.TransparencyKey = System.Drawing.Color.Navy;
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
      ((System.ComponentModel.ISupportInitialize)(this.LLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TURL;
		private System.Windows.Forms.Label LURLs;
		private System.Windows.Forms.Button BStart;
		private System.Windows.Forms.ProgressBar LProgress;
		private System.Windows.Forms.TextBox TRounds;
		private System.Windows.Forms.Label LRounds;
		private System.Windows.Forms.TextBox TURLs;
		private System.Windows.Forms.TextBox TStayTime;
		private System.Windows.Forms.TextBox TBrowserCount;
		private System.Windows.Forms.TextBox TNextTime;
		private System.Windows.Forms.PictureBox LLogo;
		private System.Windows.Forms.Label LTitle;
		private System.Windows.Forms.Button BURLsLoad;
		private System.Windows.Forms.Button BURLsSave;
		private System.Windows.Forms.Button BURLAdd;
		private System.Windows.Forms.Button BURLRemove;
		private System.Windows.Forms.Label LParameters;
		private System.Windows.Forms.Label LStayTime;
		private System.Windows.Forms.Label LNextTime;
		private System.Windows.Forms.Label LBrowserCount;
		private System.Windows.Forms.Label LBrowsers;
		private System.Windows.Forms.Button BPickChrome;
		private System.Windows.Forms.Button BPickOpera;
		private System.Windows.Forms.Button BPickFirefox;
		private System.Windows.Forms.Button BPickEdge;
		private System.Windows.Forms.Button BPathChrome;
		private System.Windows.Forms.Button BPathOpera;
		private System.Windows.Forms.Button BPathFirefox;
		private System.Windows.Forms.Button BPathEdge;
		private System.Windows.Forms.Button BPause;
		private System.Windows.Forms.Button BStop;
		private System.Windows.Forms.Button BClose;
		private System.Windows.Forms.Button BMin;
		private System.Windows.Forms.OpenFileDialog DURLsLoad;
		private System.Windows.Forms.SaveFileDialog DURLsSave;
		private System.Windows.Forms.OpenFileDialog DPickBrowser;
		private System.Windows.Forms.CheckBox CForceClose;
    private System.Windows.Forms.CheckBox CHidden;
    private System.Windows.Forms.Label LLog;
  }
}

