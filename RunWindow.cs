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
using System.Threading;
using System.Text.RegularExpressions;

namespace HODOREST
{
    public partial class RunWindow : Form
    {
        List<ShipProfile> runList;

        public RunWindow(List<ShipProfile> profiles)
        {
            InitializeComponent();

            runList = profiles;
            this.Focus();
            this.Refresh();
        }


        public void RunList()
        {
            Thread.Sleep(100);

            int stepAmount = 100 / runList.Count;
            string path = MainForm.homeworldDir + "\\GBXTools\\HODOR\\HODOR.exe";

            for (int i = 0; i < runList.Count; i++)
            {
                ShipProfile item = runList[i];
                this.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "Current: " + item.ToString() + " (" + (i + 1) + "/" + runList.Count + ")";
                });

                string seperator = "Starting ship profile: " + item.ShipName;
                seperator = seperator.PadRight(69, '=');
                WriteAsynch(seperator + "\r\n");

                WriteAsynch("Building script...\r\n");
                item.BuildScript();

                WriteAsynch("Starting HODOR...\r\n");
                Process newHODOR = new Process();
                newHODOR.StartInfo.FileName = path;
                newHODOR.StartInfo.Arguments = "-script=hodorest.hodor";
                newHODOR.StartInfo.Domain = MainForm.homeworldDir + "\\GBXTools\\HODOR\\";
                newHODOR.StartInfo.WorkingDirectory = MainForm.homeworldDir + "\\GBXTools\\HODOR\\";
                newHODOR.StartInfo.CreateNoWindow = true;
                newHODOR.StartInfo.RedirectStandardError = true;
                newHODOR.StartInfo.RedirectStandardOutput = true;
                newHODOR.StartInfo.ErrorDialog = true;
                newHODOR.StartInfo.UseShellExecute = false;

                newHODOR.Start();

                while (!newHODOR.StandardOutput.EndOfStream)
                {
                        char[] buffer = new char[20];
                        newHODOR.StandardOutput.Read(buffer, 0, 20);

                        string normalized = Regex.Replace(new string(buffer), @"\r\n|\n\r|\n|\r", "\r\n");
                        WriteAsynch(normalized);

                }

                newHODOR.WaitForExit();

                //newHODOR.WaitForExit();
                WriteAsynch(item.ShipName + " is done.\r\n");

                WriteAsynch("\r\n");

                this.Invoke((MethodInvoker)delegate
                {
                    SetProgressNoAnimation(toolStripProgressBar1, ((i + 1) * stepAmount));
                });
            }

            WriteAsynch("DONE!\r\n");
            this.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "Current: DONE! (" + runList.Count + "/" + runList.Count + ")";
                });
        }

        void WriteAsynch(string data)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.AppendText(data);
                txtConsole.Refresh();
            });
        }

        private void RunWindow_Load(object sender, EventArgs e)
        {
            Thread runner = new Thread(new ThreadStart(RunList));
            runner.Start();
            //RunList();
        }

        /// <summary>
        /// Used to circumvent the animations used on progress bars inWindows 7 and up.
        /// Includes a Update() call to take care of redraw.
        /// </summary>
        /// <param name="pb">The progress bar to be updated</param>
        /// <param name="value">Value from 0 to 100 for the progress bar</param>
        public static void SetProgressNoAnimation(ProgressBar pb, int value)
        {
            // To get around the progressive animation, we need to move the 
            // progress bar backwards.
            if (value == pb.Maximum)
            {
                // Special case as value can't be set greater than Maximum.
                pb.Maximum = value + 1;     // Temporarily Increase Maximum
                pb.Value = value + 1;       // Move past
                pb.Maximum = value;         // Reset maximum
            }
            else
            {
                pb.Value = value + 1;       // Move past
            }
            pb.Value = value;               // Move to correct value
            pb.Update();
        }

        public static void SetProgressNoAnimation(ToolStripProgressBar pb, int value)
        {
            // To get around the progressive animation, we need to move the 
            // progress bar backwards.
            if (value == pb.Maximum)
            {
                // Special case as value can't be set greater than Maximum.
                pb.Maximum = value + 1;     // Temporarily Increase Maximum
                pb.Value = value + 1;       // Move past
                pb.Maximum = value;         // Reset maximum
            }
            else
            {
                pb.Value = value + 1;       // Move past
            }
            pb.Value = value;               // Move to correct value
            if (pb.Owner != null)
                pb.Owner.Update();
        }
    }
}
