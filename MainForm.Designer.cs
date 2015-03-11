namespace HODOREST
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearOutputGlobal = new System.Windows.Forms.Button();
            this.btnBrowseGlobalDir = new System.Windows.Forms.Button();
            this.txtGlobalDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHWDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseHWDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginToExportDAEFromBlenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBXHODORExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkListMain = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrev = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputDir = new System.Windows.Forms.Button();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseDAE = new System.Windows.Forms.Button();
            this.txtDAE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnStartNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.openDAE = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearOutputGlobal);
            this.groupBox1.Controls.Add(this.btnBrowseGlobalDir);
            this.groupBox1.Controls.Add(this.txtGlobalDir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHWDir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBrowseHWDir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // btnClearOutputGlobal
            // 
            this.btnClearOutputGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutputGlobal.Location = new System.Drawing.Point(545, 42);
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
            this.btnBrowseGlobalDir.Location = new System.Drawing.Point(626, 42);
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
            this.txtGlobalDir.ReadOnly = true;
            this.txtGlobalDir.Size = new System.Drawing.Size(438, 20);
            this.txtGlobalDir.TabIndex = 12;
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
            this.txtHWDir.ReadOnly = true;
            this.txtHWDir.Size = new System.Drawing.Size(519, 20);
            this.txtHWDir.TabIndex = 1;
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
            this.btnBrowseHWDir.Location = new System.Drawing.Point(626, 13);
            this.btnBrowseHWDir.Name = "btnBrowseHWDir";
            this.btnBrowseHWDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseHWDir.TabIndex = 0;
            this.btnBrowseHWDir.Text = "Browse";
            this.btnBrowseHWDir.UseVisualStyleBackColor = true;
            this.btnBrowseHWDir.Click += new System.EventHandler(this.btnBrowseHWDir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Enabled = false;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginToExportDAEFromBlenderToolStripMenuItem,
            this.gBXHODORExampleToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pluginToExportDAEFromBlenderToolStripMenuItem
            // 
            this.pluginToExportDAEFromBlenderToolStripMenuItem.Name = "pluginToExportDAEFromBlenderToolStripMenuItem";
            this.pluginToExportDAEFromBlenderToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.pluginToExportDAEFromBlenderToolStripMenuItem.Text = "Plugin to export DAE from Blender";
            this.pluginToExportDAEFromBlenderToolStripMenuItem.Click += new System.EventHandler(this.pluginToExportDAEFromBlenderToolStripMenuItem_Click);
            // 
            // gBXHODORExampleToolStripMenuItem
            // 
            this.gBXHODORExampleToolStripMenuItem.Name = "gBXHODORExampleToolStripMenuItem";
            this.gBXHODORExampleToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.gBXHODORExampleToolStripMenuItem.Text = "GBX HODOR Example";
            this.gBXHODORExampleToolStripMenuItem.Click += new System.EventHandler(this.gBXHODORExampleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chkListMain
            // 
            this.chkListMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkListMain.FormattingEnabled = true;
            this.chkListMain.Location = new System.Drawing.Point(0, 104);
            this.chkListMain.Margin = new System.Windows.Forms.Padding(5);
            this.chkListMain.Name = "chkListMain";
            this.chkListMain.Size = new System.Drawing.Size(150, 225);
            this.chkListMain.TabIndex = 2;
            this.chkListMain.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListMain_ItemCheck);
            this.chkListMain.SelectedValueChanged += new System.EventHandler(this.chkListMain_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrev);
            this.groupBox2.Controls.Add(this.btnBrowseOutputDir);
            this.groupBox2.Controls.Add(this.txtOutputDir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowseDAE);
            this.groupBox2.Controls.Add(this.txtDAE);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtShip);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fields";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview:";
            // 
            // txtPrev
            // 
            this.txtPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrev.Location = new System.Drawing.Point(63, 104);
            this.txtPrev.Name = "txtPrev";
            this.txtPrev.ReadOnly = true;
            this.txtPrev.Size = new System.Drawing.Size(391, 20);
            this.txtPrev.TabIndex = 8;
            // 
            // btnBrowseOutputDir
            // 
            this.btnBrowseOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutputDir.Location = new System.Drawing.Point(460, 76);
            this.btnBrowseOutputDir.Name = "btnBrowseOutputDir";
            this.btnBrowseOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutputDir.TabIndex = 7;
            this.btnBrowseOutputDir.Text = "Browse";
            this.btnBrowseOutputDir.UseVisualStyleBackColor = true;
            this.btnBrowseOutputDir.Click += new System.EventHandler(this.btnBrowseOutputDir_Click);
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutputDir.Location = new System.Drawing.Point(63, 78);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.ReadOnly = true;
            this.txtOutputDir.Size = new System.Drawing.Size(391, 20);
            this.txtOutputDir.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output:";
            // 
            // btnBrowseDAE
            // 
            this.btnBrowseDAE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDAE.Location = new System.Drawing.Point(460, 47);
            this.btnBrowseDAE.Name = "btnBrowseDAE";
            this.btnBrowseDAE.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDAE.TabIndex = 2;
            this.btnBrowseDAE.Text = "Browse";
            this.btnBrowseDAE.UseVisualStyleBackColor = true;
            this.btnBrowseDAE.Click += new System.EventHandler(this.btnBrowseDAE_Click);
            // 
            // txtDAE
            // 
            this.txtDAE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDAE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDAE.Location = new System.Drawing.Point(63, 50);
            this.txtDAE.Name = "txtDAE";
            this.txtDAE.ReadOnly = true;
            this.txtDAE.Size = new System.Drawing.Size(391, 20);
            this.txtDAE.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DAE File:";
            // 
            // txtShip
            // 
            this.txtShip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShip.Location = new System.Drawing.Point(115, 19);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(420, 20);
            this.txtShip.TabIndex = 2;
            this.txtShip.TextChanged += new System.EventHandler(this.txtShip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship Name:\r\n(as used in filenames)";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Location = new System.Drawing.Point(150, 104);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 225);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnStartNew
            // 
            this.btnStartNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartNew.Location = new System.Drawing.Point(470, 199);
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.Size = new System.Drawing.Size(77, 23);
            this.btnStartNew.TabIndex = 6;
            this.btnStartNew.Text = "Start New";
            this.btnStartNew.UseVisualStyleBackColor = true;
            this.btnStartNew.Click += new System.EventHandler(this.btnStartNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnStartNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(154, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 225);
            this.panel1.TabIndex = 7;
            // 
            // openDAE
            // 
            this.openDAE.Filter = "Collada Files|*.dae";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chkListMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "HOD, HODOR, HODOREST";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHWDir;
        private System.Windows.Forms.Button btnBrowseHWDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginToExportDAEFromBlenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBXHODORExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox chkListMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrev;
        private System.Windows.Forms.Button btnBrowseOutputDir;
        private System.Windows.Forms.TextBox txtOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseDAE;
        private System.Windows.Forms.TextBox txtDAE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseGlobalDir;
        private System.Windows.Forms.TextBox txtGlobalDir;
        private System.Windows.Forms.Button btnClearOutputGlobal;
        private System.Windows.Forms.OpenFileDialog openDAE;
    }
}

