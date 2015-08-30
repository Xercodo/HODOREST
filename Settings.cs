using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HODOREST
{
	public partial class Settings : Form
	{
		private bool updating;
		private bool ignoreValue;

		public Settings()
		{
			InitializeComponent();

			updating = true;
			txtHWDir.Text = Properties.Settings.Default.HomeworldDir;
			txtGlobalDir.Text = Properties.Settings.Default.GlobalOutput;
			chkIgnore.Checked = Properties.Settings.Default.IgnoreMap;
			ignoreValue = Properties.Settings.Default.IgnoreMap;
			updating = false;
		}

		private void btnBrowseHWDir_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Properties.Settings.Default.HomeworldDir;
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				updating = true;
				Properties.Settings.Default.HomeworldDir = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.Save();
				txtHWDir.Text = Properties.Settings.Default.HomeworldDir;
				updating = false;
			}
		}

		private void btnBrowseGlobalDir_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Properties.Settings.Default.GlobalOutput;
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
			{
				updating = true;
				Properties.Settings.Default.GlobalOutput = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.Save();
				txtGlobalDir.Text = Properties.Settings.Default.GlobalOutput;
				updating = false;				
			}
		}

		private void btnClearOutputGlobal_Click(object sender, EventArgs e)
		{
			updating = true;
			txtGlobalDir.Text = "";
			Properties.Settings.Default.GlobalOutput = "";
			Properties.Settings.Default.Save();
			updating = false;
		}

		private void txtHWDir_TextChanged(object sender, EventArgs e)
		{
			if (!updating)
			{
				Properties.Settings.Default.HomeworldDir = txtHWDir.Text;
				Properties.Settings.Default.Save();
			}
		}

		private void txtGlobalDir_TextChanged(object sender, EventArgs e)
		{
			if (!updating)
			{
				Properties.Settings.Default.GlobalOutput = txtGlobalDir.Text;
				Properties.Settings.Default.Save();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.IgnoreMap = chkIgnore.Checked;
		}

		public bool IgnoreChanged;
		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Properties.Settings.Default.IgnoreMap != ignoreValue)
				IgnoreChanged = true;
			else
				IgnoreChanged = false;
		}
	}
}
