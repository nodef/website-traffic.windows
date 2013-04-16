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
			this.fURL = new System.Windows.Forms.TextBox();
			this.dInputURL = new System.Windows.Forms.Label();
			this.fStart = new System.Windows.Forms.Button();
			this.fStop = new System.Windows.Forms.Button();
			this.fAddURL = new System.Windows.Forms.Button();
			this.fRemoveURL = new System.Windows.Forms.Button();
			this.fProgress = new System.Windows.Forms.ProgressBar();
			this.fRounds = new System.Windows.Forms.TextBox();
			this.dRounds = new System.Windows.Forms.Label();
			this.fListURL = new System.Windows.Forms.TextBox();
			this.dStayTime = new System.Windows.Forms.Label();
			this.fStayTime = new System.Windows.Forms.TextBox();
			this.dBrowserCount = new System.Windows.Forms.Label();
			this.fBrowserCount = new System.Windows.Forms.TextBox();
			this.dNextTime = new System.Windows.Forms.Label();
			this.fNextTime = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// fURL
			// 
			this.fURL.Location = new System.Drawing.Point( 12, 44 );
			this.fURL.Name = "fURL";
			this.fURL.Size = new System.Drawing.Size( 489, 20 );
			this.fURL.TabIndex = 0;
			// 
			// dInputURL
			// 
			this.dInputURL.AutoSize = true;
			this.dInputURL.Location = new System.Drawing.Point( 9, 28 );
			this.dInputURL.Name = "dInputURL";
			this.dInputURL.Size = new System.Drawing.Size( 108, 13 );
			this.dInputURL.TabIndex = 1;
			this.dInputURL.Text = "URL to be accessed:";
			// 
			// fStart
			// 
			this.fStart.Location = new System.Drawing.Point( 12, 372 );
			this.fStart.Name = "fStart";
			this.fStart.Size = new System.Drawing.Size( 243, 40 );
			this.fStart.TabIndex = 4;
			this.fStart.Text = "Start";
			this.fStart.UseVisualStyleBackColor = true;
			this.fStart.Click += new System.EventHandler( this.fStart_Click );
			// 
			// fStop
			// 
			this.fStop.Location = new System.Drawing.Point( 260, 372 );
			this.fStop.Name = "fStop";
			this.fStop.Size = new System.Drawing.Size( 241, 40 );
			this.fStop.TabIndex = 5;
			this.fStop.Text = "Stop";
			this.fStop.UseVisualStyleBackColor = true;
			this.fStop.Click += new System.EventHandler( this.fStop_Click );
			// 
			// fAddURL
			// 
			this.fAddURL.Location = new System.Drawing.Point( 12, 70 );
			this.fAddURL.Name = "fAddURL";
			this.fAddURL.Size = new System.Drawing.Size( 243, 29 );
			this.fAddURL.TabIndex = 6;
			this.fAddURL.Text = "Add";
			this.fAddURL.UseVisualStyleBackColor = true;
			this.fAddURL.Click += new System.EventHandler( this.fAdd_Click );
			// 
			// fRemoveURL
			// 
			this.fRemoveURL.Location = new System.Drawing.Point( 260, 70 );
			this.fRemoveURL.Name = "fRemoveURL";
			this.fRemoveURL.Size = new System.Drawing.Size( 240, 29 );
			this.fRemoveURL.TabIndex = 7;
			this.fRemoveURL.Text = "Remove";
			this.fRemoveURL.UseVisualStyleBackColor = true;
			this.fRemoveURL.Click += new System.EventHandler( this.fRemove_Click );
			// 
			// fProgress
			// 
			this.fProgress.Location = new System.Drawing.Point( 12, 323 );
			this.fProgress.Name = "fProgress";
			this.fProgress.Size = new System.Drawing.Size( 488, 23 );
			this.fProgress.TabIndex = 9;
			// 
			// fRounds
			// 
			this.fRounds.Location = new System.Drawing.Point( 65, 297 );
			this.fRounds.Name = "fRounds";
			this.fRounds.Size = new System.Drawing.Size( 52, 20 );
			this.fRounds.TabIndex = 12;
			this.fRounds.Text = "20";
			this.fRounds.Leave += new System.EventHandler( this.fRounds_Leave );
			// 
			// dRounds
			// 
			this.dRounds.AutoSize = true;
			this.dRounds.Location = new System.Drawing.Point( 12, 300 );
			this.dRounds.Name = "dRounds";
			this.dRounds.Size = new System.Drawing.Size( 47, 13 );
			this.dRounds.TabIndex = 13;
			this.dRounds.Text = "Rounds:";
			// 
			// fListURL
			// 
			this.fListURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.fListURL.Location = new System.Drawing.Point( 15, 106 );
			this.fListURL.Multiline = true;
			this.fListURL.Name = "fListURL";
			this.fListURL.ReadOnly = true;
			this.fListURL.Size = new System.Drawing.Size( 485, 185 );
			this.fListURL.TabIndex = 14;
			// 
			// dStayTime
			// 
			this.dStayTime.AutoSize = true;
			this.dStayTime.Location = new System.Drawing.Point( 123, 300 );
			this.dStayTime.Name = "dStayTime";
			this.dStayTime.Size = new System.Drawing.Size( 57, 13 );
			this.dStayTime.TabIndex = 15;
			this.dStayTime.Text = "Stay Time:";
			// 
			// fStayTime
			// 
			this.fStayTime.Location = new System.Drawing.Point( 186, 297 );
			this.fStayTime.Name = "fStayTime";
			this.fStayTime.Size = new System.Drawing.Size( 55, 20 );
			this.fStayTime.TabIndex = 16;
			this.fStayTime.Text = "4";
			this.fStayTime.Leave += new System.EventHandler( this.fStayTime_Leave );
			// 
			// dBrowserCount
			// 
			this.dBrowserCount.AutoSize = true;
			this.dBrowserCount.Location = new System.Drawing.Point( 356, 300 );
			this.dBrowserCount.Name = "dBrowserCount";
			this.dBrowserCount.Size = new System.Drawing.Size( 78, 13 );
			this.dBrowserCount.TabIndex = 17;
			this.dBrowserCount.Text = "Browser count:";
			// 
			// fBrowserCount
			// 
			this.fBrowserCount.Location = new System.Drawing.Point( 440, 297 );
			this.fBrowserCount.Name = "fBrowserCount";
			this.fBrowserCount.Size = new System.Drawing.Size( 60, 20 );
			this.fBrowserCount.TabIndex = 18;
			this.fBrowserCount.Text = "4";
			this.fBrowserCount.Leave += new System.EventHandler( this.fBrowserCount_Leave );
			// 
			// dNextTime
			// 
			this.dNextTime.AutoSize = true;
			this.dNextTime.Location = new System.Drawing.Point( 247, 300 );
			this.dNextTime.Name = "dNextTime";
			this.dNextTime.Size = new System.Drawing.Size( 58, 13 );
			this.dNextTime.TabIndex = 19;
			this.dNextTime.Text = "Next Time:";
			// 
			// fNextTime
			// 
			this.fNextTime.Location = new System.Drawing.Point( 311, 297 );
			this.fNextTime.Name = "fNextTime";
			this.fNextTime.Size = new System.Drawing.Size( 39, 20 );
			this.fNextTime.TabIndex = 20;
			this.fNextTime.Text = "4";
			this.fNextTime.Leave += new System.EventHandler( this.fNextTime_Leave );
			// 
			// WebTraffic
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 513, 426 );
			this.Controls.Add( this.fNextTime );
			this.Controls.Add( this.dNextTime );
			this.Controls.Add( this.fBrowserCount );
			this.Controls.Add( this.dBrowserCount );
			this.Controls.Add( this.fStayTime );
			this.Controls.Add( this.dStayTime );
			this.Controls.Add( this.fListURL );
			this.Controls.Add( this.dRounds );
			this.Controls.Add( this.fRounds );
			this.Controls.Add( this.fProgress );
			this.Controls.Add( this.fRemoveURL );
			this.Controls.Add( this.fAddURL );
			this.Controls.Add( this.fStop );
			this.Controls.Add( this.fStart );
			this.Controls.Add( this.dInputURL );
			this.Controls.Add( this.fURL );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "WebTraffic";
			this.Text = "WebTraffic";
			this.TransparencyKey = System.Drawing.Color.Navy;
			this.Paint += new System.Windows.Forms.PaintEventHandler( this.WebTraffic_Paint );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fURL;
		private System.Windows.Forms.Label dInputURL;
		private System.Windows.Forms.Button fStart;
		private System.Windows.Forms.Button fStop;
		private System.Windows.Forms.Button fAddURL;
		private System.Windows.Forms.Button fRemoveURL;
		private System.Windows.Forms.ProgressBar fProgress;
		private System.Windows.Forms.TextBox fRounds;
		private System.Windows.Forms.Label dRounds;
		private System.Windows.Forms.TextBox fListURL;
		private System.Windows.Forms.Label dStayTime;
		private System.Windows.Forms.TextBox fStayTime;
		private System.Windows.Forms.Label dBrowserCount;
		private System.Windows.Forms.TextBox fBrowserCount;
		private System.Windows.Forms.Label dNextTime;
		private System.Windows.Forms.TextBox fNextTime;
	}
}

