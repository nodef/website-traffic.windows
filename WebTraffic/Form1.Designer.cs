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
			this.wtxtWebAddress = new System.Windows.Forms.TextBox();
			this.dInputURL = new System.Windows.Forms.Label();
			this.fStart = new System.Windows.Forms.Button();
			this.fStop = new System.Windows.Forms.Button();
			this.fAddURL = new System.Windows.Forms.Button();
			this.fRemoveURL = new System.Windows.Forms.Button();
			this.fProgress = new System.Windows.Forms.ProgressBar();
			this.wbrsrIE0 = new System.Windows.Forms.WebBrowser();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// wtxtWebAddress
			// 
			this.wtxtWebAddress.Location = new System.Drawing.Point(12, 44);
			this.wtxtWebAddress.Name = "wtxtWebAddress";
			this.wtxtWebAddress.Size = new System.Drawing.Size(273, 20);
			this.wtxtWebAddress.TabIndex = 0;
			// 
			// dInputURL
			// 
			this.dInputURL.AutoSize = true;
			this.dInputURL.Location = new System.Drawing.Point(9, 28);
			this.dInputURL.Name = "dInputURL";
			this.dInputURL.Size = new System.Drawing.Size(108, 13);
			this.dInputURL.TabIndex = 1;
			this.dInputURL.Text = "URL to be accessed:";
			// 
			// fStart
			// 
			this.fStart.Location = new System.Drawing.Point(12, 372);
			this.fStart.Name = "fStart";
			this.fStart.Size = new System.Drawing.Size(134, 40);
			this.fStart.TabIndex = 4;
			this.fStart.Text = "Start";
			this.fStart.UseVisualStyleBackColor = true;
			this.fStart.Click += new System.EventHandler(this.wbtnStart_Click);
			// 
			// fStop
			// 
			this.fStop.Location = new System.Drawing.Point(154, 372);
			this.fStop.Name = "fStop";
			this.fStop.Size = new System.Drawing.Size(134, 40);
			this.fStop.TabIndex = 5;
			this.fStop.Text = "Stop";
			this.fStop.UseVisualStyleBackColor = true;
			this.fStop.Click += new System.EventHandler(this.wbtnStop_Click);
			// 
			// fAddURL
			// 
			this.fAddURL.Location = new System.Drawing.Point(12, 70);
			this.fAddURL.Name = "fAddURL";
			this.fAddURL.Size = new System.Drawing.Size(131, 29);
			this.fAddURL.TabIndex = 6;
			this.fAddURL.Text = "Add";
			this.fAddURL.UseVisualStyleBackColor = true;
			this.fAddURL.Click += new System.EventHandler(this.wbtnAdd_Click);
			// 
			// fRemoveURL
			// 
			this.fRemoveURL.Location = new System.Drawing.Point(154, 70);
			this.fRemoveURL.Name = "fRemoveURL";
			this.fRemoveURL.Size = new System.Drawing.Size(131, 29);
			this.fRemoveURL.TabIndex = 7;
			this.fRemoveURL.Text = "Remove";
			this.fRemoveURL.UseVisualStyleBackColor = true;
			this.fRemoveURL.Click += new System.EventHandler(this.wbtnRemove_Click);
			// 
			// fProgress
			// 
			this.fProgress.Location = new System.Drawing.Point(12, 323);
			this.fProgress.Name = "fProgress";
			this.fProgress.Size = new System.Drawing.Size(273, 23);
			this.fProgress.TabIndex = 9;
			// 
			// wbrsrIE0
			// 
			this.wbrsrIE0.Location = new System.Drawing.Point(325, 44);
			this.wbrsrIE0.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbrsrIE0.Name = "wbrsrIE0";
			this.wbrsrIE0.Size = new System.Drawing.Size(324, 368);
			this.wbrsrIE0.TabIndex = 10;
			this.wbrsrIE0.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbrsrIE0_DocumentCompleted);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(98, 297);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 20);
			this.textBox1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 300);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Access rounds:";
			// 
			// WebTraffic
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 426);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.wbrsrIE0);
			this.Controls.Add(this.fProgress);
			this.Controls.Add(this.fRemoveURL);
			this.Controls.Add(this.fAddURL);
			this.Controls.Add(this.fStop);
			this.Controls.Add(this.fStart);
			this.Controls.Add(this.dInputURL);
			this.Controls.Add(this.wtxtWebAddress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "WebTraffic";
			this.Text = "WebTraffic";
			this.TransparencyKey = System.Drawing.Color.Navy;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebTraffic_FormClosed);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.WebTraffic_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox wtxtWebAddress;
		private System.Windows.Forms.Label dInputURL;
		private System.Windows.Forms.Button fStart;
		private System.Windows.Forms.Button fStop;
		private System.Windows.Forms.Button fAddURL;
		private System.Windows.Forms.Button fRemoveURL;
		private System.Windows.Forms.ProgressBar fProgress;
		private System.Windows.Forms.WebBrowser wbrsrIE0;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

