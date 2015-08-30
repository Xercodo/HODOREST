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
using System.Configuration;
using System.Collections;

namespace HODOREST
{
    public partial class MainForm : Form
    {
        ShipProfile currentProfile = new ShipProfile();
		RunWindow runner;

        public MainForm()
        {
            InitializeComponent();

			if (Properties.Settings.Default.DoUpgrade)
			{
				Properties.Settings.Default.Upgrade();
				Properties.Settings.Default.DoUpgrade = false;
				Properties.Settings.Default.Save();
			}

			currentProfile = new ShipProfile(Properties.Settings.Default.GlobalOutput);
            currentProfile.PreviewRebuild += UpdatePreview;
			currentProfile.DisplayChanged += currentProfile_DisplayChanged;
			listView1.Items.Add(GenerateItem(currentProfile));
			UpdateFields();
			UpdatePreview();
			LoadShaders();

			CheckVersion();
        }

		int displayIndex = -1;
		void currentProfile_DisplayChanged()
		{
			if (displayIndex >= 0)
			{
				ListViewItem.ListViewSubItemCollection existingSubs = listView1.Items[displayIndex].SubItems;
				ListViewItem.ListViewSubItemCollection subs = GenerateItem(currentProfile).SubItems;
				foreach (ListViewItem.ListViewSubItem item in existingSubs)
				{
					foreach (ListViewItem.ListViewSubItem sub in subs)
					{
						if (item.Name == sub.Name)
							item.Text = sub.Text;
					}
				}

				listView1.Items[displayIndex].Checked = currentProfile.Enabled;
				listView1.Items[displayIndex].Tag = currentProfile;
			}
		}

		private void LoadShaders()
		{
			if (Directory.Exists(Properties.Settings.Default.HomeworldDir + "\\GBXTools\\HODOR"))
			{
				var shaders = Directory.EnumerateFiles(Properties.Settings.Default.HomeworldDir + "\\GBXTools\\HODOR", "*.MAP", SearchOption.TopDirectoryOnly);

				foreach (string item in shaders)
				{
					comboShaders.Items.Add(Path.GetFileNameWithoutExtension(item));
				}
			}
		}

		private void CheckVersion()
		{
			var client = new Octokit.GitHubClient(new ProductHeaderValue("HODOREST"));
			var releases = client.Release.GetAll("xercodo", "HODOREST");
			var latest = releases.Result[0];

			Version ver = Assembly.GetExecutingAssembly().GetName().Version;
			string currentVersion = ver.Major + "." + ver.Minor;
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

        }

        private void btnBrowseOutputDir_Click(object sender, EventArgs e)
        {
			folderBrowserDialog2.SelectedPath = currentProfile.OutputDir;
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
			txtPrev.Text = "(" + currentProfile.Preview + ")";

			bool hasEmpty = false;
			foreach (object item in listView1.Items)
			{
				if (item.ToString() == "")
				{
					hasEmpty = true;
					break;
				}
			}

			if (hasEmpty)
			{
				btnRun.Enabled = false;
				btnNew.Enabled = false;
			}
			else
			{
				btnRun.Enabled = (listView1.Items.Count > 0) ? true : false;
				btnNew.Enabled = true;
			}

			if (listView1.Items.Count == 0)
			{
				toolStripButton2_Click(this, EventArgs.Empty);
			}
        }

        private void chkListMain_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateFields()
        {
            txtShip.Text = currentProfile.ShipName;
            txtDAE.Text = currentProfile.DAEFile;
            txtOutputDir.Text = currentProfile.OutputDir;

			this.chkCompress.Checked = currentProfile.Compression;
			this.rdoShader.Checked = currentProfile.CompressShader;
			this.rdo8888.Checked = currentProfile.Compress8888;
			this.rdoDXT1.Checked = currentProfile.CompressDXT1;
			this.rdoDXT3.Checked = currentProfile.CompressDXT3;
			this.rdoDXT5.Checked = currentProfile.CompressDXT5;
			this.chkNoOpt.Checked = currentProfile.NoOptimize;
			this.chkForceScar.Checked = currentProfile.ForceScars;
			this.chkFilterScar.Checked = currentProfile.FilterScars;
			this.txtScarFilter.Text = currentProfile.FilterList;
			this.chkStripJunk.Checked = currentProfile.StripJunk;
			this.comboShaders.Text = currentProfile.Shader;
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

        }

		private void SaveList()
		{
			List<ShipProfile> profiles = new List<ShipProfile>();

			foreach (ListViewItem item in listView1.Items)
			{
				ShipProfile profile = item.Tag as ShipProfile;
				profile.PreviewRebuild -= UpdatePreview;
				profile.DisplayChanged -= currentProfile_DisplayChanged;
				profiles.Add(profile);
			}

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

		private List<ShaderProfile> LoadShaderList(string mapFile)
		{
			List<ShaderProfile> shaders = new List<ShaderProfile>();

			List<ShaderProfile> currentList = new List<ShaderProfile>();

			if(File.Exists(mapFile))
			{
				StreamReader reader = new StreamReader(mapFile);

				int lineCounter = 0;
				while(!reader.EndOfStream)
				{
					string line = reader.ReadLine();

					if(line.Length > 2)
					{
						if(line[0] == '+')
						{
							shaders.AddRange(currentList);
							currentList = new List<ShaderProfile>();
							int space = line.IndexOfAny(new char[] {' ', '\t'});
							if(space > 0)
								line = line.Substring(1, space-1);
							else
								line = line.Substring(1);

							string[] names = line.Split(new char[] { ',' });
							foreach (string name in names)
							{
								currentList.Add(new ShaderProfile(name, lineCounter));
							}
						}
						else if (line[0] == '\t' && line[1] == '\t')
						{
							line = line.Substring(2);
							int space = line.IndexOfAny(new char[] { ' ', '\t', '[' });
							if (space > 0)
								line = line.Substring(0, space);
							else
								line = line.Substring(0);

							if (currentList.Count > 0)
							{
								foreach (ShaderProfile item in currentList)
								{
									item.FileNames.Add(line);
								}
							}
						}
					}

					lineCounter++;
				}

				shaders.AddRange(currentList);
				reader.Close();
			}

			return shaders;
		}

		private HashSet<KeyValuePair<string, string>> GetShaderTexturePairs(string daefile)
		{
			HashSet<KeyValuePair<string, string>> pairs = new HashSet<KeyValuePair<string, string>>();

			if(File.Exists(daefile))
			{
				StreamReader reader = new StreamReader(daefile);

				string shader = "";
				string textureName = "";

				while(!reader.EndOfStream)
				{
					string line = reader.ReadLine();

					if(line.Length > 0)
					{
						if(line.Contains("effect id=\"MAT["))
						{
							int index = line.IndexOf("_SHD[");
							line = line.Substring(index + 5);
							int endIndex = line.IndexOf(']');
							shader = line.Substring(0, endIndex);
						}
						else if(shader != "" && line.Contains("texture texture=\"IMG["))
						{
							int start = line.IndexOf("texture texture=\"IMG[");
							line = line.Substring(start + 21);
							int endIndex = line.IndexOf(']');
							textureName = line.Substring(0, endIndex);

							textureName = textureName.Substring(0, textureName.LastIndexOf("_"));

							pairs.Add(new KeyValuePair<string, string>(shader, textureName));
							shader = "";
							textureName = "";
						}
					}
				}

				reader.Close();
			}

			return pairs;
		}

		private HashSet<string> CheckTextures(string daeDir, DateTime hodDate, HashSet<KeyValuePair<string, string>> usedShaders, List<ShaderProfile> mappedShaders)
		{
			HashSet<string> newerFiles = new HashSet<string>();

			foreach (KeyValuePair<string, string> item in usedShaders)
			{
				ShaderProfile match = null;
				foreach (ShaderProfile shader in mappedShaders)
				{
					if (item.Key == shader.Name)
						match = shader;
				}

				if (match != null)
				{
					DirectoryInfo info = new DirectoryInfo(daeDir);
					var files = info.EnumerateFiles(item.Value + "*.tga", SearchOption.TopDirectoryOnly);
					foreach (string texture in match.FileNames)
					{
						foreach (FileInfo file in files)
						{
							if (file.Name.Contains(texture))
							{
								if (file.LastWriteTime > hodDate)
									newerFiles.Add(file.Name);
							}
						}
					}
				}
			}

			return newerFiles;
		}

		private ListViewItem GenerateItem(ShipProfile profile)
		{
			ListViewItem newItem = new ListViewItem("");
			newItem.Checked = profile.Enabled;
			ListViewItem.ListViewSubItem subItem;

			subItem = new ListViewItem.ListViewSubItem();
			subItem.Name = "Name";
			subItem.Text = profile.ShipName;

			newItem.SubItems.Add(subItem);

			string daetime = "";
			if (File.Exists(profile.DAEFile))
			{
				string date = File.GetLastWriteTime(profile.DAEFile).ToShortDateString();
				string time = File.GetLastWriteTime(profile.DAEFile).ToShortTimeString();
				daetime = date + " " + time;

				subItem = new ListViewItem.ListViewSubItem();
				subItem.Name = "DAEDate";
				subItem.Text = daetime;

				newItem.SubItems.Add(subItem);
			}
			else
			{
				subItem = new ListViewItem.ListViewSubItem();
				subItem.Name = "DAEDate";
				subItem.Text = daetime;

				newItem.SubItems.Add(subItem);
			}

			string hodPath = profile.OutputDir + "\\" + profile.ShipName + "\\" + profile.ShipName + ".hod";
			string hodtime = "";
			DateTime hodDateTime;
			if (File.Exists(hodPath))
			{
				hodDateTime = File.GetLastWriteTime(hodPath);
				string date = hodDateTime.ToShortDateString();
				string time = hodDateTime.ToShortTimeString();
				hodtime = date + " " + time;

				subItem = new ListViewItem.ListViewSubItem();
				subItem.Name = "HODDate";
				subItem.Text = hodtime;

				newItem.SubItems.Add(subItem);
			}
			else
			{
				hodDateTime = new DateTime();

				subItem = new ListViewItem.ListViewSubItem();
				subItem.Name = "HODDate";
				subItem.Text = hodtime;

				newItem.SubItems.Add(subItem);
			}

			HashSet<string> files = new HashSet<string>();
			string warning = "";

			if (File.Exists(hodPath))
			{
				DateTime hodDate = File.GetLastWriteTime(hodPath);

				if (File.Exists(profile.DAEFile))
				{
					string directory = Path.GetDirectoryName(profile.DAEFile);

					HashSet<KeyValuePair<string, string>> usedShaders = GetShaderTexturePairs(profile.DAEFile);

					string mapFile = Properties.Settings.Default.HomeworldDir + @"\GBXTools\HODOR\" + profile.Shader + ".MAP";
					List<ShaderProfile> shaders = LoadShaderList(mapFile);

					files = CheckTextures(directory, hodDate, usedShaders, shaders);

					if (Compare(daetime, hodtime) > 0)
						files.Add(profile.DAEFile);

					if (!Properties.Settings.Default.IgnoreMap)
					{
						DateTime mapDate = File.GetLastWriteTime(mapFile);
						if (mapDate > hodDateTime)
							files.Add(mapFile);
					}

					profile.NewerFiles = new List<string>();
					profile.NewerFiles.AddRange(files);

					if (files.Count > 0)
					{
						warning = "NEWER FILES";
					}
				}
			}

			ListViewItem.ListViewSubItem newSub = new ListViewItem.ListViewSubItem();
			newSub.Text = warning;
			newSub.ForeColor = Color.Red;
			newSub.Name = "Warning";
			newItem.SubItems.Add(newSub);

			newItem.UseItemStyleForSubItems = false;

			newItem.Tag = profile;
			newItem.Checked = profile.Enabled;

			return newItem;

		}

		private void LoadList()
		{
			using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.BuildList)))
			{
				try
				{
					listView1.Items.Clear();
					BinaryFormatter bf = new BinaryFormatter();
					List<ShipProfile> profiles = (List<ShipProfile>)bf.Deserialize(ms);

					foreach (ShipProfile item in profiles.ToArray<ShipProfile>())
					{
						listView1.Items.Add(GenerateItem(item));
					}
				}
				catch (Exception ex)
				{
					string smg = ex.ToString();
				}
			}
		}

		private int Compare(string x, string y)
		{
			int returnVal = 0;
			// Determine whether the type being compared is a date type.
			try
			{
				// Parse the two objects passed as a parameter as a DateTime.
				System.DateTime firstDate =
						DateTime.Parse(x);
				System.DateTime secondDate =
						DateTime.Parse(y);
				// Compare the two dates.
				returnVal = DateTime.Compare(firstDate, secondDate);
			}
			// If neither compared object has a valid date format, compare
			// as a string.
			catch
			{ }

			return returnVal;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadList();
			UpdateFields();
			UpdatePreview();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (runner != null)
			{
				runner.Kill();
				runner.Close();
			}

			currentProfile.PreviewRebuild -= UpdatePreview;

			SaveList();
		}

		private void chkCompress_CheckedChanged(object sender, EventArgs e)
		{
			this.rdoShader.Enabled = chkCompress.Checked;
			this.rdo8888.Enabled = chkCompress.Checked;
			this.rdoDXT1.Enabled = chkCompress.Checked;
			this.rdoDXT3.Enabled = chkCompress.Checked;
			this.rdoDXT5.Enabled = chkCompress.Checked;

			currentProfile.Compression = this.chkCompress.Checked;

			if(!this.chkCompress.Checked)
			{
				this.rdoShader.Checked = false;
				this.rdo8888.Checked = false;
				this.rdoDXT1.Checked = false;
				this.rdoDXT3.Checked = false;
				this.rdoDXT5.Checked = false;
			}
		}

		private void rdoShader_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.CompressShader = this.rdoShader.Checked;
		}

		private void rdo8888_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.Compress8888 = this.rdo8888.Checked;
		}

		private void rdoDXT1_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.CompressDXT1 = this.rdoDXT1.Checked;
		}

		private void rdoDXT3_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.CompressDXT3 = this.rdoDXT3.Checked;
		}

		private void rdoDXT5_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.CompressDXT5 = this.rdoDXT5.Checked;
		}

		private void chkNoOpt_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.NoOptimize = this.chkNoOpt.Checked;
		}

		private void chkForceScar_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.ForceScars = this.chkForceScar.Checked;
		}

		private void chkFilterScar_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.FilterScars = this.chkFilterScar.Checked;
		}

		private void txtScarFilter_TextChanged(object sender, EventArgs e)
		{
			currentProfile.FilterList = this.txtScarFilter.Text;
		}

		private void chkStripJunk_CheckedChanged(object sender, EventArgs e)
		{
			currentProfile.StripJunk = this.chkStripJunk.Checked;
		}

		private void comboShaders_SelectedIndexChanged(object sender, EventArgs e)
		{
			currentProfile.Shader = this.comboShaders.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			currentProfile.BuildScript();
		}

		private int sortColumn = -1;
		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			// Determine whether the column is the same as the last column clicked.
			if (e.Column != sortColumn)
			{
				// Set the sort column to the new column.
				sortColumn = e.Column;
				// Set the sort order to ascending by default.
				listView1.Sorting = SortOrder.Ascending;
			}
			else
			{
				// Determine what the last sort order was and change it.
				if (listView1.Sorting == SortOrder.Ascending)
					listView1.Sorting = SortOrder.Descending;
				else
					listView1.Sorting = SortOrder.Ascending;
			}

			// Call the sort method to manually sort.
			listView1.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer
			// object.
			this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column,
															  listView1.Sorting);
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				List<string> files = (listView1.SelectedItems[0].Tag as ShipProfile).NewerFiles;
				string directory = Path.GetDirectoryName((listView1.SelectedItems[0].Tag as ShipProfile).DAEFile);
				if (files.Count > 0)
				{
					NewerFilesList listWindow = new NewerFilesList(files, directory);
					listWindow.ShowDialog();
				}
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.GlobalOutput != "")
				currentProfile = new ShipProfile(Properties.Settings.Default.GlobalOutput);
			else
				currentProfile = new ShipProfile();

			currentProfile.PreviewRebuild += UpdatePreview;
			currentProfile.DisplayChanged += currentProfile_DisplayChanged;
			listView1.Items.Add(GenerateItem(currentProfile));
			listView1.Items[listView1.Items.Count - 1].Selected = true;
			UpdateFields();
			UpdatePreview();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Settings settingsWindow = new Settings();
			settingsWindow.ShowDialog(this);
			if(settingsWindow.IgnoreChanged)
			{
				foreach (ListViewItem item in listView1.Items)
				{
					ShipProfile tempProfile = item.Tag as ShipProfile;

					ListViewItem.ListViewSubItemCollection existingSubs = item.SubItems;
					ListViewItem.ListViewSubItemCollection subs = GenerateItem(tempProfile).SubItems;
					foreach (ListViewItem.ListViewSubItem exSub in existingSubs)
					{
						foreach (ListViewItem.ListViewSubItem sub in subs)
						{
							if (exSub.Name == sub.Name)
								exSub.Text = sub.Text;
						}
					}

					item.Checked = tempProfile.Enabled;
					item.Tag = tempProfile;
				}
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShipProfile profile = null;
			if (listView1.SelectedItems.Count > 0)
			{
				profile = listView1.SelectedItems[0].Tag as ShipProfile;
				displayIndex = listView1.SelectedIndices[0];
			}

			if (profile != null)
			{
				btnDelete.Enabled = true;

				currentProfile.PreviewRebuild -= UpdatePreview;
				currentProfile.DisplayChanged -= currentProfile_DisplayChanged;

				ShipProfile newCurrent;
				newCurrent = profile;
				currentProfile = newCurrent;
				currentProfile.PreviewRebuild += UpdatePreview;
				currentProfile.DisplayChanged += currentProfile_DisplayChanged;
				UpdateFields();
			}
			else
			{
				btnDelete.Enabled = false;
			}
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			if (!File.Exists(Properties.Settings.Default.HomeworldDir + "\\GBXTools\\HODOR\\HODOR.exe"))
			{
				MessageBox.Show(this,
					"Cannot find HODOR.\r\n\r\nCheck your Homeworld Directory path!",
					"Cannot Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			List<ShipProfile> sendList = new List<ShipProfile>();

			foreach (ListViewItem item in listView1.Items)
			{
				ShipProfile temp = item.Tag	as ShipProfile;
				if (temp.Enabled)
				{
					sendList.Add(temp);
				}
			}

			runner = new RunWindow(sendList);
			runner.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			listView1.Items.RemoveAt(displayIndex);
			if (listView1.Items.Count == 0)
			{
				if (Properties.Settings.Default.GlobalOutput != "")
					currentProfile = new ShipProfile(Properties.Settings.Default.GlobalOutput);
				else
					currentProfile = new ShipProfile();

				currentProfile.PreviewRebuild += UpdatePreview;
				listView1.Items.Add(GenerateItem(currentProfile));
				UpdateFields();
				UpdatePreview();
			}
		}

		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			ShipProfile profile = listView1.Items[e.Index].Tag as ShipProfile;

			if (profile.Enabled)
				e.NewValue = CheckState.Checked;
			else
				e.NewValue = CheckState.Unchecked;
		}
	}
}