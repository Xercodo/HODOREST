using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Octokit;
using System.Reflection;

namespace HODOREST
{
    public partial class MainForm : Form
    {
        ShipProfile currentProfile = new ShipProfile();
        string outputGlobal = "";
        public static string homeworldDir = "";

        public MainForm()
        {
            InitializeComponent();

            homeworldDir = Properties.Settings.Default.HomeworldDir;
            outputGlobal = Properties.Settings.Default.GlobalOutput;

            txtHWDir.Text = homeworldDir;
            txtGlobalDir.Text = outputGlobal;

            currentProfile = new ShipProfile(outputGlobal);
            currentProfile.PreviewRebuildTiggered += UpdatePreview;
            chkListMain.Items.Add(currentProfile, currentProfile.Enabled);
			UpdateFields();
			UpdatePreview();

			CheckVersion();
        }

		private void CheckVersion()
		{
			var client = new Octokit.GitHubClient(new ProductHeaderValue("HODOREST"));
			var releases = client.Release.GetAll("xercodo", "HODOREST");
			var latest = releases.Result[0];

			Version ver = Assembly.GetExecutingAssembly().GetName().Version;
			string currentVersion = ver.Major + "." + ver.Minor + "-beta";
			if (currentVersion != latest.TagName)
			{
				DialogResult result = MessageBox.Show(this, "There's a newer version of HODOREST!\r\n\r\n" +
					"Current: " + currentVersion + "\r\n" +
					"Latest Version: " + latest.TagName + "\r\n\r\n" +
					"Do you want to visit the release page now?",
					"Newer Version", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (result == System.Windows.Forms.DialogResult.Yes)
				{
					Process proc = new Process();
					proc.StartInfo = new ProcessStartInfo(latest.HtmlUrl);
					proc.Start();
					this.Close();
				}
			}
		}

        private void pluginToExportDAEFromBlenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forums.gearboxsoftware.com/t/blender-dae-compatibility-with-hodor/125078");
        }

        private void gBXHODORExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://forums.gearboxsoftware.com/t/example-ships-1/118742");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void btnBrowseHWDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                homeworldDir = folderBrowserDialog1.SelectedPath;
                txtHWDir.Text = homeworldDir;
                Properties.Settings.Default.HomeworldDir = homeworldDir;
                Properties.Settings.Default.Save();
            }
        }

        private void btnBrowseOutputDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                currentProfile.OutputDir = folderBrowserDialog2.SelectedPath;
                txtOutputDir.Text = currentProfile.OutputDir;
            }
        }

        private void txtShip_TextChanged(object sender, EventArgs e)
        {
            currentProfile.ShipName = txtShip.Text;
        }

        private void UpdatePreview()
        {
            txtPrev.Text = currentProfile.Preview;

            bool hasEmpty = false;
            foreach (object item in chkListMain.Items)
            {
                if (item.ToString() == "")
                {
                    hasEmpty = true;
                    break;
                }
            }

            if (hasEmpty)
            {
                runToolStripMenuItem.Enabled = false;
				btnNew.Enabled = false;
            }
            else
            {
                runToolStripMenuItem.Enabled = (chkListMain.Items.Count > 0) ? true : false;
				btnNew.Enabled = true;
            }

			if (chkListMain.Items.Count == 0)
			{
				btnStartNew_Click(this, EventArgs.Empty);
			}

            chkListMain.SelectedItem = currentProfile;
            chkListMain.Refresh();
        }

        private void btnBrowseGlobalDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                outputGlobal = folderBrowserDialog2.SelectedPath;
                txtGlobalDir.Text = outputGlobal;
                Properties.Settings.Default.GlobalOutput = outputGlobal;
                Properties.Settings.Default.Save();
            }
        }

        private void btnClearOutputGlobal_Click(object sender, EventArgs e)
        {
            outputGlobal = "";
            txtGlobalDir.Text = outputGlobal;
            Properties.Settings.Default.GlobalOutput = outputGlobal;
            Properties.Settings.Default.Save();
        }

        private void btnStartNew_Click(object sender, EventArgs e)
        {
            if (outputGlobal != "")
                currentProfile = new ShipProfile(outputGlobal);
            else
                currentProfile = new ShipProfile();

            currentProfile.PreviewRebuildTiggered += UpdatePreview;
            chkListMain.Items.Add(currentProfile, currentProfile.Enabled);
            UpdateFields();
            UpdatePreview();
        }

        private void chkListMain_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chkListMain.SelectedItem != null)
            {
				btnDelete.Enabled = true;

				currentProfile.PreviewRebuildTiggered -= UpdatePreview;

                ShipProfile newCurrent;
                newCurrent = (chkListMain.SelectedItem as ShipProfile);
                currentProfile = newCurrent;
				currentProfile.PreviewRebuildTiggered += UpdatePreview;
                UpdateFields();
            }
            else
            {
				btnDelete.Enabled = false;
            }
        }

        private void UpdateFields()
        {
            txtShip.Text = currentProfile.ShipName;
            txtDAE.Text = currentProfile.DAEFile;
            txtOutputDir.Text = currentProfile.OutputDir;
        }

        private void chkListMain_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            currentProfile.Enabled = e.NewValue.HasFlag(CheckState.Checked);
        }

        private void btnBrowseDAE_Click(object sender, EventArgs e)
        {
            DialogResult result = openDAE.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                currentProfile.DAEFile = openDAE.FileName;
                txtDAE.Text = currentProfile.DAEFile;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkListMain.Items.RemoveAt(chkListMain.SelectedIndex);
            if (chkListMain.Items.Count == 0)
            {
                if (outputGlobal != "")
                    currentProfile = new ShipProfile(outputGlobal);
                else
                    currentProfile = new ShipProfile();

                currentProfile.PreviewRebuildTiggered += UpdatePreview;
                chkListMain.Items.Add(currentProfile, currentProfile.Enabled);
                UpdateFields();
                UpdatePreview();
            }
        }

		RunWindow runner;
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (!File.Exists(MainForm.homeworldDir + "\\GBXTools\\HODOR\\HODOR.exe"))
			{
				MessageBox.Show(this, 
					"Cannot find HODOR.\r\n\r\nCheck your Homeworld Directory path!", 
					"Cannot Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
            List<ShipProfile> sendList = new List<ShipProfile>();
            foreach (object item in chkListMain.Items)
            {
				ShipProfile temp = item as ShipProfile;
				if (temp.Enabled)
				{
					sendList.Add(temp);
				}
            }

			runner = new RunWindow(sendList);
            runner.ShowDialog();
        }

		private void SaveList(CheckedListBox.ObjectCollection items)
		{
			List<ShipProfile> profiles = items.Cast<ShipProfile>().ToList<ShipProfile>();

			using (MemoryStream ms = new MemoryStream())
			{
				try
				{
					BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(ms, profiles);
					ms.Position = 0;
					byte[] buffer = new byte[(int)ms.Length];
					ms.Read(buffer, 0, buffer.Length);
					Properties.Settings.Default.BuildList = Convert.ToBase64String(buffer);
					Properties.Settings.Default.Save();
				}
				catch (Exception ex)
				{
					string smg = ex.ToString();
				}
			}
		}

		private CheckedListBox.ObjectCollection LoadList()
		{
			using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.BuildList)))
			{
				try
				{
					BinaryFormatter bf = new BinaryFormatter();
					List<ShipProfile> profiles = (List<ShipProfile>)bf.Deserialize(ms);
					CheckedListBox.ObjectCollection coll = new CheckedListBox.ObjectCollection(new CheckedListBox());
					coll.AddRange(profiles.ToArray<object>());
					return coll;
				}
				catch(Exception ex)
				{
					string smg = ex.ToString();
					return new CheckedListBox.ObjectCollection(null);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			chkListMain.Items.Clear();
			chkListMain.Items.AddRange(LoadList());
			UpdateFields();
			UpdatePreview();

			for (int i = 0; i < chkListMain.Items.Count; i++)
			{
				chkListMain.SetItemChecked(i, (chkListMain.Items[i] as ShipProfile).Enabled);
			}

			chkListMain.SelectedIndex = 0;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (runner != null)
			{
				runner.Kill();
				runner.Close();
			}

			currentProfile.PreviewRebuildTiggered -= UpdatePreview;

			SaveList(chkListMain.Items);
		}
    }

    public delegate void DataChangedHandler();

	[Serializable]
    public class ShipProfile
    {
        private string shipName;
        private string daeFile;
        private string outputDir;
        private bool enabled;

        public ShipProfile()
        {
            shipName = "";
            outputDir = "";
            daeFile = "";
            enabled = true;
        }

        public ShipProfile(string defaultOutputDir)
        {
            shipName = "";
            outputDir = defaultOutputDir;
            daeFile = "";
            enabled = true;
        }

        public ShipProfile(ShipProfile oldProfile)
        {
            shipName = oldProfile.ShipName;
            outputDir = oldProfile.OutputDir;
            daeFile = oldProfile.DAEFile;
            enabled = true;
        }

        public string ShipName
        {
            get { return shipName; }
            set
            {
                shipName = value;
                if (this.PreviewRebuildTiggered != null)
                    PreviewRebuildTiggered();
            }
        }
        public string DAEFile
        {
            get { return daeFile; }
            set
            {
                daeFile = value; 
                if (this.PreviewRebuildTiggered != null)
                    PreviewRebuildTiggered();
            }
        }
        public string OutputDir
        {
            get { return outputDir; }
            set
            {
                outputDir = value;
                if (this.PreviewRebuildTiggered != null)
                    PreviewRebuildTiggered();
            }
        }
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
        public string Preview
        {
            get
            {
                string returnString = "";

                if (OutputDir == "")
                    returnString += "([OutputDir]\\";
                else
                    returnString += "(" + OutputDir + "\\";

                if(ShipName == "")
                    returnString += "[ShipName]\\[ShipName].HOD)";
                else
                    returnString += ShipName + "\\" + ShipName + ".HOD)";

                return returnString;
            }
        }

        public event DataChangedHandler PreviewRebuildTiggered;

        public override string ToString()
        {
            return ShipName;
        }

        public void BuildScript()
        {
            string scriptPath = (MainForm.homeworldDir + "\\GBXTools\\HODOR\\hodorest.hodor");
            StreamWriter writer = new StreamWriter(scriptPath);
            writer.WriteLine("## HODOR Params - by HODOREST");
            writer.WriteLine("= -$HWRM_BASE=" + MainForm.homeworldDir);
            writer.WriteLine("= -$SHIP_NAME=" + this.ShipName);
            writer.WriteLine("= -$SHADER_MAP=$[HWRM_BASE]\\GBXTools\\HODOR\\SHADERS.MAP");
            writer.WriteLine("= -$SHADE_OPT_LOADDAE=Force8888");
            writer.WriteLine("= -$HOD_SAVE_OPTS=ForceScars FilterScars=thruster,bay");
            writer.WriteLine("= -$CONVERT_IN=" + this.DAEFile);
            writer.WriteLine("= -$CONVERT_OUT=" + this.OutputDir + "\\$[SHIP_NAME]\\$[SHIP_NAME].HOD");
            writer.WriteLine("= -do=convert");
            writer.WriteLine("= -action=null");
            writer.Close();

            //## My HODOR Params - by Timmy
            //= -$HWRM_BASE=C:\Games\Homeworld2
            //= -$SHIP_NAME=Kad_Swarmer
            //= -$SHADER_MAP=$[HWRM_BASE]\GBXTools\HODOR\SHADERS.MAP
            //= -$SHADE_OPT_LOADDAE=Force8888
            //= -$HOD_SAVE_OPTS=ForceScars FilterScars=thruster,bay
            //= -$CONVERT_IN=$[HWRM_BASE]\GBXTools\ShipExample\$[SHIP_NAME]\$[SHIP_NAME].DAE
            //= -$CONVERT_OUT=$[HWRM_BASE]\MyMod\Ships\$[SHIP_NAME]\$[SHIP_NAME].HOD
            //= -do=convert
            //= -action=null
            //= -wait
        }
    }
}
