using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HODOREST
{
	public partial class NewerFilesList : Form
	{
		public NewerFilesList(List<string> files, string directory)
		{
			InitializeComponent();

			foreach (string file in files)
			{
				string fullPath = "";
				if (Path.GetExtension(file) != ".MAP")
					fullPath = directory + "\\" + file;
				else
					fullPath = file;
				ListViewItem newItem = new ListViewItem(Path.GetFileName(file));
				DateTime fileDate = File.GetLastWriteTime(fullPath);

				string date = fileDate.ToShortDateString();
				string time = fileDate.ToShortTimeString();
				string dateString = date + " " + time;

				newItem.SubItems.Add(dateString);
				newItem.Tag = fullPath;
				listView1.Items.Add(newItem);
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			Process openFile = new Process();
			openFile.StartInfo.FileName = listView1.SelectedItems[0].Tag.ToString();
			openFile.Start();
		}
	}
}
