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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.chkStripJunk = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtScarFilter = new System.Windows.Forms.TextBox();
			this.chkFilterScar = new System.Windows.Forms.CheckBox();
			this.chkForceScar = new System.Windows.Forms.CheckBox();
			this.chkNoOpt = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.comboShaders = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rdoDXT5 = new System.Windows.Forms.RadioButton();
			this.rdoDXT3 = new System.Windows.Forms.RadioButton();
			this.rdoDXT1 = new System.Windows.Forms.RadioButton();
			this.rdo8888 = new System.Windows.Forms.RadioButton();
			this.rdoShader = new System.Windows.Forms.RadioButton();
			this.chkCompress = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.openDAE = new System.Windows.Forms.OpenFileDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(726, 80);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Directories";
			// 
			// btnClearOutputGlobal
			// 
			this.btnClearOutputGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearOutputGlobal.Location = new System.Drawing.Point(564, 42);
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
			this.btnBrowseGlobalDir.Location = new System.Drawing.Point(645, 42);
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
			this.txtGlobalDir.Size = new System.Drawing.Size(457, 20);
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
			this.txtHWDir.Size = new System.Drawing.Size(538, 20);
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
			this.btnBrowseHWDir.Location = new System.Drawing.Point(645, 13);
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
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(726, 24);
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
			this.chkListMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkListMain.FormattingEnabled = true;
			this.chkListMain.Location = new System.Drawing.Point(0, 25);
			this.chkListMain.Margin = new System.Windows.Forms.Padding(5);
			this.chkListMain.Name = "chkListMain";
			this.chkListMain.Size = new System.Drawing.Size(150, 282);
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
			this.groupBox2.Size = new System.Drawing.Size(554, 137);
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
			this.txtPrev.Size = new System.Drawing.Size(404, 20);
			this.txtPrev.TabIndex = 8;
			// 
			// btnBrowseOutputDir
			// 
			this.btnBrowseOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOutputDir.Location = new System.Drawing.Point(473, 75);
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
			this.txtOutputDir.Size = new System.Drawing.Size(404, 20);
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
			this.btnBrowseDAE.Location = new System.Drawing.Point(473, 47);
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
			this.txtDAE.Size = new System.Drawing.Size(404, 20);
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
			this.txtShip.Size = new System.Drawing.Size(433, 20);
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
			this.splitter1.Size = new System.Drawing.Size(4, 307);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.groupBox6);
			this.panel1.Controls.Add(this.groupBox5);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(154, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(572, 307);
			this.panel1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(485, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Gen Script";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.chkStripJunk);
			this.groupBox6.Location = new System.Drawing.Point(176, 246);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(122, 49);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Optimization Options";
			// 
			// chkStripJunk
			// 
			this.chkStripJunk.AutoSize = true;
			this.chkStripJunk.Location = new System.Drawing.Point(6, 19);
			this.chkStripJunk.Name = "chkStripJunk";
			this.chkStripJunk.Size = new System.Drawing.Size(73, 17);
			this.chkStripJunk.TabIndex = 0;
			this.chkStripJunk.Text = "Strip Junk";
			this.chkStripJunk.UseVisualStyleBackColor = true;
			this.chkStripJunk.CheckedChanged += new System.EventHandler(this.chkStripJunk_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.txtScarFilter);
			this.groupBox5.Controls.Add(this.chkFilterScar);
			this.groupBox5.Controls.Add(this.chkForceScar);
			this.groupBox5.Controls.Add(this.chkNoOpt);
			this.groupBox5.Location = new System.Drawing.Point(176, 149);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(210, 91);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Save Options";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(92, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Filter List";
			// 
			// txtScarFilter
			// 
			this.txtScarFilter.Location = new System.Drawing.Point(92, 55);
			this.txtScarFilter.Name = "txtScarFilter";
			this.txtScarFilter.Size = new System.Drawing.Size(112, 20);
			this.txtScarFilter.TabIndex = 1;
			this.txtScarFilter.TextChanged += new System.EventHandler(this.txtScarFilter_TextChanged);
			// 
			// chkFilterScar
			// 
			this.chkFilterScar.AutoSize = true;
			this.chkFilterScar.Location = new System.Drawing.Point(95, 19);
			this.chkFilterScar.Name = "chkFilterScar";
			this.chkFilterScar.Size = new System.Drawing.Size(78, 17);
			this.chkFilterScar.TabIndex = 0;
			this.chkFilterScar.Text = "Filter Scars";
			this.chkFilterScar.UseVisualStyleBackColor = true;
			this.chkFilterScar.CheckedChanged += new System.EventHandler(this.chkFilterScar_CheckedChanged);
			// 
			// chkForceScar
			// 
			this.chkForceScar.AutoSize = true;
			this.chkForceScar.Location = new System.Drawing.Point(6, 42);
			this.chkForceScar.Name = "chkForceScar";
			this.chkForceScar.Size = new System.Drawing.Size(83, 17);
			this.chkForceScar.TabIndex = 0;
			this.chkForceScar.Text = "Force Scars";
			this.chkForceScar.UseVisualStyleBackColor = true;
			this.chkForceScar.CheckedChanged += new System.EventHandler(this.chkForceScar_CheckedChanged);
			// 
			// chkNoOpt
			// 
			this.chkNoOpt.AutoSize = true;
			this.chkNoOpt.Location = new System.Drawing.Point(6, 19);
			this.chkNoOpt.Name = "chkNoOpt";
			this.chkNoOpt.Size = new System.Drawing.Size(83, 17);
			this.chkNoOpt.TabIndex = 0;
			this.chkNoOpt.Text = "No Optimize";
			this.chkNoOpt.UseVisualStyleBackColor = true;
			this.chkNoOpt.CheckedChanged += new System.EventHandler(this.chkNoOpt_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboShaders);
			this.groupBox4.Location = new System.Drawing.Point(6, 246);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(164, 49);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Shader";
			// 
			// comboShaders
			// 
			this.comboShaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboShaders.FormattingEnabled = true;
			this.comboShaders.Location = new System.Drawing.Point(6, 19);
			this.comboShaders.Name = "comboShaders";
			this.comboShaders.Size = new System.Drawing.Size(152, 21);
			this.comboShaders.TabIndex = 0;
			this.comboShaders.SelectedIndexChanged += new System.EventHandler(this.comboShaders_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdoDXT5);
			this.groupBox3.Controls.Add(this.rdoDXT3);
			this.groupBox3.Controls.Add(this.rdoDXT1);
			this.groupBox3.Controls.Add(this.rdo8888);
			this.groupBox3.Controls.Add(this.rdoShader);
			this.groupBox3.Controls.Add(this.chkCompress);
			this.groupBox3.Location = new System.Drawing.Point(6, 149);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(164, 91);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "      Force Image Compression";
			// 
			// rdoDXT5
			// 
			this.rdoDXT5.AutoSize = true;
			this.rdoDXT5.Enabled = false;
			this.rdoDXT5.Location = new System.Drawing.Point(93, 65);
			this.rdoDXT5.Name = "rdoDXT5";
			this.rdoDXT5.Size = new System.Drawing.Size(53, 17);
			this.rdoDXT5.TabIndex = 1;
			this.rdoDXT5.TabStop = true;
			this.rdoDXT5.Text = "DXT5";
			this.rdoDXT5.UseVisualStyleBackColor = true;
			this.rdoDXT5.CheckedChanged += new System.EventHandler(this.rdoDXT5_CheckedChanged);
			// 
			// rdoDXT3
			// 
			this.rdoDXT3.AutoSize = true;
			this.rdoDXT3.Enabled = false;
			this.rdoDXT3.Location = new System.Drawing.Point(93, 43);
			this.rdoDXT3.Name = "rdoDXT3";
			this.rdoDXT3.Size = new System.Drawing.Size(53, 17);
			this.rdoDXT3.TabIndex = 1;
			this.rdoDXT3.TabStop = true;
			this.rdoDXT3.Text = "DXT3";
			this.rdoDXT3.UseVisualStyleBackColor = true;
			this.rdoDXT3.CheckedChanged += new System.EventHandler(this.rdoDXT3_CheckedChanged);
			// 
			// rdoDXT1
			// 
			this.rdoDXT1.AutoSize = true;
			this.rdoDXT1.Enabled = false;
			this.rdoDXT1.Location = new System.Drawing.Point(93, 20);
			this.rdoDXT1.Name = "rdoDXT1";
			this.rdoDXT1.Size = new System.Drawing.Size(53, 17);
			this.rdoDXT1.TabIndex = 1;
			this.rdoDXT1.TabStop = true;
			this.rdoDXT1.Text = "DXT1";
			this.rdoDXT1.UseVisualStyleBackColor = true;
			this.rdoDXT1.CheckedChanged += new System.EventHandler(this.rdoDXT1_CheckedChanged);
			// 
			// rdo8888
			// 
			this.rdo8888.AutoSize = true;
			this.rdo8888.Enabled = false;
			this.rdo8888.Location = new System.Drawing.Point(6, 43);
			this.rdo8888.Name = "rdo8888";
			this.rdo8888.Size = new System.Drawing.Size(49, 17);
			this.rdo8888.TabIndex = 1;
			this.rdo8888.TabStop = true;
			this.rdo8888.Text = "8888";
			this.rdo8888.UseVisualStyleBackColor = true;
			this.rdo8888.CheckedChanged += new System.EventHandler(this.rdo8888_CheckedChanged);
			// 
			// rdoShader
			// 
			this.rdoShader.AutoSize = true;
			this.rdoShader.Enabled = false;
			this.rdoShader.Location = new System.Drawing.Point(6, 20);
			this.rdoShader.Name = "rdoShader";
			this.rdoShader.Size = new System.Drawing.Size(81, 17);
			this.rdoShader.TabIndex = 1;
			this.rdoShader.TabStop = true;
			this.rdoShader.Text = "Use Shader";
			this.rdoShader.UseVisualStyleBackColor = true;
			this.rdoShader.CheckedChanged += new System.EventHandler(this.rdoShader_CheckedChanged);
			// 
			// chkCompress
			// 
			this.chkCompress.AutoSize = true;
			this.chkCompress.Location = new System.Drawing.Point(9, 0);
			this.chkCompress.Name = "chkCompress";
			this.chkCompress.Size = new System.Drawing.Size(15, 14);
			this.chkCompress.TabIndex = 0;
			this.chkCompress.UseVisualStyleBackColor = true;
			this.chkCompress.CheckedChanged += new System.EventHandler(this.chkCompress_CheckedChanged);
			// 
			// openDAE
			// 
			this.openDAE.Filter = "Collada Files|*.dae";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.chkListMain);
			this.panel2.Controls.Add(this.toolStrip1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 104);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(150, 307);
			this.panel2.TabIndex = 7;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripSeparator2,
            this.btnDelete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(150, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNew
			// 
			this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(23, 22);
			this.btnNew.Text = "New Entry";
			this.btnNew.Click += new System.EventHandler(this.btnStartNew_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDelete.Enabled = false;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 22);
			this.btnDelete.Text = "Delete Selected Item";
			this.btnDelete.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 411);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "HOD, HODOR, HODOREST";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseGlobalDir;
        private System.Windows.Forms.TextBox txtGlobalDir;
        private System.Windows.Forms.Button btnClearOutputGlobal;
        private System.Windows.Forms.OpenFileDialog openDAE;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rdoDXT5;
		private System.Windows.Forms.RadioButton rdoDXT3;
		private System.Windows.Forms.RadioButton rdoDXT1;
		private System.Windows.Forms.RadioButton rdo8888;
		private System.Windows.Forms.RadioButton rdoShader;
		private System.Windows.Forms.CheckBox chkCompress;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtScarFilter;
		private System.Windows.Forms.CheckBox chkFilterScar;
		private System.Windows.Forms.CheckBox chkForceScar;
		private System.Windows.Forms.CheckBox chkNoOpt;
		private System.Windows.Forms.ComboBox comboShaders;
		private System.Windows.Forms.CheckBox chkStripJunk;
		private System.Windows.Forms.Button button1;
    }
}

