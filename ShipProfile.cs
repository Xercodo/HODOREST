using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HODOREST
{
	public delegate void DataChangedHandler();

	[Serializable]
	public class ShipProfile
	{
		private string shipName;
		private string daeFile;
		private string outputDir;
		private bool enabled;

		private bool compression = true;
		public bool Compression { get { return compression; } set { compression = value; } }

		private bool compressShader;
		public bool CompressShader { get { return compressShader; } set { compressShader = value; } }

		private bool compress8888 = true;
		public bool Compress8888 { get { return compress8888; } set { compress8888 = value; } }

		private bool compressDXT1;
		public bool CompressDXT1 { get { return compressDXT1; } set { compressDXT1 = value; } }

		private bool compressDXT3;
		public bool CompressDXT3 { get { return compressDXT3; } set { compressDXT3 = value; } }

		private bool compressDXT5;
		public bool CompressDXT5 { get { return compressDXT5; } set { compressDXT5 = value; } }


		private bool noOptimize;
		public bool NoOptimize { get { return noOptimize; } set { noOptimize = value; } }

		private bool forceScars = true;
		public bool ForceScars { get { return forceScars; } set { forceScars = value; } }

		private bool filterScars = true;
		public bool FilterScars { get { return filterScars; } set { filterScars = value; } }

		private string filterList = "thruster,bay";
		public string FilterList { get { return filterList; } set { filterList = value; } }


		private bool stripJunk;
		public bool StripJunk { get { return stripJunk; } set { stripJunk = value; } }


		private string shader = "SHADERS";
		public string Shader { get { return shader; } set { shader = value; } }

		private List<string> newerFiles = new List<string>();
		public List<string> NewerFiles { get { return newerFiles; } set { newerFiles = value; } }

		public string ShipName
		{
			get { return shipName; }
			set
			{
				shipName = value;
				if (this.PreviewRebuild != null)
					PreviewRebuild();
				if (this.DisplayChanged != null)
					DisplayChanged();
			}
		}
		public string DAEFile
		{
			get { return daeFile; }
			set
			{
				daeFile = value;
				if (this.PreviewRebuild != null)
					PreviewRebuild();
				if (this.DisplayChanged != null)
					DisplayChanged();
			}
		}
		public string OutputDir
		{
			get { return outputDir; }
			set
			{
				outputDir = value;
				if (this.PreviewRebuild != null)
					PreviewRebuild();
			}
		}
		public bool Enabled
		{
			get 
			{
				bool exists = File.Exists(this.Preview);
				return (newerFiles.Count > 0) || !exists; 
			}
			set { enabled = value; }
		}
		public string Preview
		{
			get
			{
				string returnString = "";

				if (OutputDir == "")
					returnString += "[OutputDir]\\";
				else
					returnString += OutputDir + "\\";

				if (ShipName == "")
					returnString += "[ShipName]\\[ShipName].HOD";
				else
					returnString += ShipName + "\\" + ShipName + ".HOD";

				return returnString;
			}
		}

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

		public event DataChangedHandler PreviewRebuild;
		public event DataChangedHandler DisplayChanged;

		public override string ToString()
		{
			return ShipName;
		}

		public void BuildScript()
		{
			string scriptPath = (Properties.Settings.Default.HomeworldDir + "\\GBXTools\\HODOR\\hodorest.hodor");
			StreamWriter writer = new StreamWriter(scriptPath);
			writer.WriteLine("## HODOR Params - by HODOREST");
			writer.WriteLine("= -$HWRM_BASE=" + Properties.Settings.Default.HomeworldDir);
			writer.WriteLine("= -$SHIP_NAME=" + this.ShipName);
			writer.WriteLine("= -$SHADER_MAP=$[HWRM_BASE]\\GBXTools\\HODOR\\" + this.shader + ".MAP");
			if (this.compression)
			{
				string compressionName = "";
				if (this.compressShader)
					compressionName = "ForceMAP";
				if (this.compress8888)
					compressionName = "Force8888";
				if (this.compressDXT1)
					compressionName = "ForceDXT1";
				if (this.compressDXT3)
					compressionName = "ForceDXT3";
				if (this.compressDXT5)
					compressionName = "ForceDXT5";

				writer.WriteLine("= -$SHADE_OPT_LOADDAE=" + compressionName);
			}
			if (this.forceScars || this.noOptimize || this.filterScars)
			{
				List<string> flagText = new List<string>();
				if (this.forceScars)
					flagText.Add("ForceScars");

				if (this.noOptimize)
					flagText.Add("noOptimize");

				if (this.filterScars)
					flagText.Add("FilterScars=" + this.filterList);

				for (int i = 0; i < flagText.Count; i++)
				{
					if ((i + 1) < (flagText.Count))
					{
						flagText.Insert(i + 1, " ");
						i++;
					}
				}

				string flags = "";
				foreach (string item in flagText)
				{
					flags += item;
				}

				writer.WriteLine("= -$HOD_SAVE_OPTS=" + flags);
			}
			if (this.stripJunk)
			{
				writer.WriteLine("= -$HOD_OPTIMIZE_OPT=StripJunk");
			}
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

	class ListViewItemComparer : IComparer
	{
		private int col;
		private SortOrder order;
		public ListViewItemComparer()
		{
			col = 0;
			order = SortOrder.Ascending;
		}
		public ListViewItemComparer(int column, SortOrder order)
		{
			col = column;
			this.order = order;
		}
		public int Compare(object x, object y)
		{
			int returnVal;
			// Determine whether the type being compared is a date type.
			try
			{
				// Parse the two objects passed as a parameter as a DateTime.
				System.DateTime firstDate =
						DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
				System.DateTime secondDate =
						DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
				// Compare the two dates.
				returnVal = DateTime.Compare(firstDate, secondDate);
			}
			// If neither compared object has a valid date format, compare
			// as a string.
			catch
			{
				if (col != 0)
				{
					// Compare the two items as a string.
					returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
								((ListViewItem)y).SubItems[col].Text);
				}
				else
				{
					bool Xcheck = ((ListViewItem)x).Checked;
					bool Ycheck = ((ListViewItem)y).Checked;
					if (Xcheck && Ycheck)
						returnVal = 0;
					else if (Xcheck && !Ycheck)
						returnVal = 1;
					else if (!Xcheck && Ycheck)
						returnVal = -1;
					else
						returnVal = 0;
				}
			}
			// Determine whether the sort order is descending.
			if (order == SortOrder.Descending)
				// Invert the value returned by String.Compare.
				returnVal *= -1;
			return returnVal;
		}
	}
}
