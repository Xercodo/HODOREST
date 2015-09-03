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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pluginToExportDAEFromBlenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gBXHODORExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.colEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDAEDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHODDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colWarn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
			this.openDAE = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(514, 24);
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
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
			this.groupBox2.Size = new System.Drawing.Size(492, 137);
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
			this.txtPrev.Size = new System.Drawing.Size(338, 20);
			this.txtPrev.TabIndex = 8;
			// 
			// btnBrowseOutputDir
			// 
			this.btnBrowseOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOutputDir.Location = new System.Drawing.Point(407, 75);
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
			this.txtOutputDir.Size = new System.Drawing.Size(338, 20);
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
			this.btnBrowseDAE.Location = new System.Drawing.Point(407, 47);
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
			this.txtDAE.Size = new System.Drawing.Size(338, 20);
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
			this.txtShip.Size = new System.Drawing.Size(367, 20);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.groupBox6);
			this.panel1.Controls.Add(this.groupBox5);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 157);
			this.panel1.MinimumSize = new System.Drawing.Size(0, 300);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(514, 304);
			this.panel1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(436, 278);
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
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEnabled,
            this.colName,
            this.colDAEDate,
            this.colHODDate,
            this.colWarn});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 49);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(514, 108);
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// colEnabled
			// 
			this.colEnabled.Text = "X";
			this.colEnabled.Width = 19;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 134;
			// 
			// colDAEDate
			// 
			this.colDAEDate.Text = "DAE Date";
			this.colDAEDate.Width = 120;
			// 
			// colHODDate
			// 
			this.colHODDate.Text = "HOD Date";
			this.colHODDate.Width = 120;
			// 
			// colWarn
			// 
			this.colWarn.Text = "Newer";
			this.colWarn.Width = 100;
			// 
			// openDAE
			// 
			this.openDAE.Filter = "Collada Files|*.dae";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRun,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.btnNew,
            this.btnDelete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(514, 25);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnRun
			// 
			this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
			this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(23, 22);
			this.btnRun.Text = "Run";
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Refresh";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnNew
			// 
			this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(23, 22);
			this.btnNew.Text = "New";
			this.btnNew.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDelete.Enabled = false;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 22);
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 461);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "HOD, HODOR, HODOREST";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
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
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginToExportDAEFromBlenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBXHODORExampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
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
		private System.Windows.Forms.OpenFileDialog openDAE;
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
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader colEnabled;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colDAEDate;
		private System.Windows.Forms.ColumnHeader colHODDate;
		private System.Windows.Forms.ColumnHeader colWarn;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

