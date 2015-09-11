namespace HODOREST
{
	partial class Settings
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClearOutputGlobal = new System.Windows.Forms.Button();
			this.btnBrowseGlobalDir = new System.Windows.Forms.Button();
			this.txtGlobalDir = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtHWDir = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnBrowseHWDir = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.chkIgnore = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoKaren = new System.Windows.Forms.RadioButton();
			this.rdoMakaan = new System.Windows.Forms.RadioButton();
			this.rdoEmperor = new System.Windows.Forms.RadioButton();
			this.rdoWindows = new System.Windows.Forms.RadioButton();
			this.rdoNone = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnClearOutputGlobal);
			this.groupBox1.Controls.Add(this.btnBrowseGlobalDir);
			this.groupBox1.Controls.Add(this.txtGlobalDir);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtHWDir);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnBrowseHWDir);
			this.groupBox1.Location = new System.Drawing.Point(3, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(769, 80);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Directories";
			// 
			// btnClearOutputGlobal
			// 
			this.btnClearOutputGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearOutputGlobal.Location = new System.Drawing.Point(607, 42);
			this.btnClearOutputGlobal.Name = "btnClearOutputGlobal";
			this.btnClearOutputGlobal.Size = new System.Drawing.Size(75, 23);
			this.btnClearOutputGlobal.TabIndex = 14;
			this.btnClearOutputGlobal.Text = "Clear";
			this.btnClearOutputGlobal.UseVisualStyleBackColor = true;
			this.btnClearOutputGlobal.Click += new System.EventHandler(this.btnClearOutputGlobal_Click);
			// 
			// btnBrowseGlobalDir
			// 
			this.btnBrowseGlobalDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseGlobalDir.Location = new System.Drawing.Point(688, 42);
			this.btnBrowseGlobalDir.Name = "btnBrowseGlobalDir";
			this.btnBrowseGlobalDir.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseGlobalDir.TabIndex = 13;
			this.btnBrowseGlobalDir.Text = "Browse";
			this.btnBrowseGlobalDir.UseVisualStyleBackColor = true;
			this.btnBrowseGlobalDir.Click += new System.EventHandler(this.btnBrowseGlobalDir_Click);
			// 
			// txtGlobalDir
			// 
			this.txtGlobalDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGlobalDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGlobalDir.Location = new System.Drawing.Point(101, 45);
			this.txtGlobalDir.Name = "txtGlobalDir";
			this.txtGlobalDir.Size = new System.Drawing.Size(500, 20);
			this.txtGlobalDir.TabIndex = 12;
			this.txtGlobalDir.TextChanged += new System.EventHandler(this.txtGlobalDir_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Global Output:";
			// 
			// txtHWDir
			// 
			this.txtHWDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHWDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtHWDir.Location = new System.Drawing.Point(101, 16);
			this.txtHWDir.Name = "txtHWDir";
			this.txtHWDir.Size = new System.Drawing.Size(581, 20);
			this.txtHWDir.TabIndex = 1;
			this.txtHWDir.TextChanged += new System.EventHandler(this.txtHWDir_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 21);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Homeworld Main:";
			// 
			// btnBrowseHWDir
			// 
			this.btnBrowseHWDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseHWDir.Location = new System.Drawing.Point(688, 13);
			this.btnBrowseHWDir.Name = "btnBrowseHWDir";
			this.btnBrowseHWDir.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseHWDir.TabIndex = 0;
			this.btnBrowseHWDir.Text = "Browse";
			this.btnBrowseHWDir.UseVisualStyleBackColor = true;
			this.btnBrowseHWDir.Click += new System.EventHandler(this.btnBrowseHWDir_Click);
			// 
			// chkIgnore
			// 
			this.chkIgnore.AutoSize = true;
			this.chkIgnore.Location = new System.Drawing.Point(12, 98);
			this.chkIgnore.Name = "chkIgnore";
			this.chkIgnore.Size = new System.Drawing.Size(114, 17);
			this.chkIgnore.TabIndex = 2;
			this.chkIgnore.Text = "Ignore Newer Map";
			this.chkIgnore.UseVisualStyleBackColor = true;
			this.chkIgnore.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rdoWindows);
			this.groupBox2.Controls.Add(this.rdoNone);
			this.groupBox2.Controls.Add(this.rdoEmperor);
			this.groupBox2.Controls.Add(this.rdoMakaan);
			this.groupBox2.Controls.Add(this.rdoKaren);
			this.groupBox2.Location = new System.Drawing.Point(565, 98);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(207, 72);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Finish Notification";
			// 
			// rdoKaren
			// 
			this.rdoKaren.AutoSize = true;
			this.rdoKaren.Location = new System.Drawing.Point(6, 19);
			this.rdoKaren.Name = "rdoKaren";
			this.rdoKaren.Size = new System.Drawing.Size(53, 17);
			this.rdoKaren.TabIndex = 0;
			this.rdoKaren.TabStop = true;
			this.rdoKaren.Text = "Karen";
			this.rdoKaren.UseVisualStyleBackColor = true;
			this.rdoKaren.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// rdoMakaan
			// 
			this.rdoMakaan.AutoSize = true;
			this.rdoMakaan.Location = new System.Drawing.Point(6, 42);
			this.rdoMakaan.Name = "rdoMakaan";
			this.rdoMakaan.Size = new System.Drawing.Size(64, 17);
			this.rdoMakaan.TabIndex = 0;
			this.rdoMakaan.TabStop = true;
			this.rdoMakaan.Text = "Makaan";
			this.rdoMakaan.UseVisualStyleBackColor = true;
			this.rdoMakaan.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// rdoEmperor
			// 
			this.rdoEmperor.AutoSize = true;
			this.rdoEmperor.Location = new System.Drawing.Point(76, 19);
			this.rdoEmperor.Name = "rdoEmperor";
			this.rdoEmperor.Size = new System.Drawing.Size(64, 17);
			this.rdoEmperor.TabIndex = 0;
			this.rdoEmperor.TabStop = true;
			this.rdoEmperor.Text = "Emperor";
			this.rdoEmperor.UseVisualStyleBackColor = true;
			this.rdoEmperor.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// rdoWindows
			// 
			this.rdoWindows.AutoSize = true;
			this.rdoWindows.Location = new System.Drawing.Point(76, 42);
			this.rdoWindows.Name = "rdoWindows";
			this.rdoWindows.Size = new System.Drawing.Size(69, 17);
			this.rdoWindows.TabIndex = 0;
			this.rdoWindows.TabStop = true;
			this.rdoWindows.Text = "Windows";
			this.rdoWindows.UseVisualStyleBackColor = true;
			this.rdoWindows.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// rdoNone
			// 
			this.rdoNone.AutoSize = true;
			this.rdoNone.Location = new System.Drawing.Point(146, 19);
			this.rdoNone.Name = "rdoNone";
			this.rdoNone.Size = new System.Drawing.Size(51, 17);
			this.rdoNone.TabIndex = 0;
			this.rdoNone.TabStop = true;
			this.rdoNone.Text = "None";
			this.rdoNone.UseVisualStyleBackColor = true;
			this.rdoNone.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 182);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.chkIgnore);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnClearOutputGlobal;
		private System.Windows.Forms.Button btnBrowseGlobalDir;
		private System.Windows.Forms.TextBox txtGlobalDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtHWDir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnBrowseHWDir;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.CheckBox chkIgnore;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdoKaren;
		private System.Windows.Forms.RadioButton rdoWindows;
		private System.Windows.Forms.RadioButton rdoNone;
		private System.Windows.Forms.RadioButton rdoEmperor;
		private System.Windows.Forms.RadioButton rdoMakaan;
	}
}