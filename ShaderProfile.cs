using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HODOREST
{
	class ShaderProfile
	{

		private string name;
		private int lineNumber;
		private List<string> files;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int LineNumber
		{
			get { return lineNumber; }
			set { lineNumber = value; }
		}

		public List<string> FileNames
		{
			get { return files; }
			set { files = value; }
		}

		public ShaderProfile()
		{
			name = "";
			lineNumber = 0;
			files = new List<string>();
		}

		public ShaderProfile(string _name, int line)
		{
			name = _name;
			lineNumber = line;
			files = new List<string>();
		}

		public override string ToString()
		{
			string returnString = "";
			returnString += name + " on line number: " + lineNumber;
			return returnString;
		}
	}
}
