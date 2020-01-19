using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityApp
{
    public partial class Utility : Form
    {
        public Utility()
        {
            InitializeComponent();
        }

        private void buttonCloseIE_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] ps = Process.GetProcessesByName("IEXPLORE");

                foreach (Process p in ps)
                {
                    p.Kill();
                }
                buttonCloseIE.ForeColor = Color.Green;
            }
            catch
            {
                buttonCloseIE.ForeColor = Color.Red;
            }
        }

        private void buttonResetIIS_Click(object sender, EventArgs e)
        {
            try
            {
                var process = System.Diagnostics.Process.Start(@"C:\Windows\System32\iisreset.exe");
                process.WaitForExit();
                buttonResetIIS.ForeColor = Color.Green;
            }
            catch
            {
                buttonResetIIS.ForeColor = Color.Red;
            }
        }

        private void buttonDeleteTempFiles_Click(object sender, EventArgs e)
        {
            try
            {
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                string path = @"C:\Users\ct300460\AppData\Local\Microsoft\Windows\Temporary Internet Files";
                //for deleting files
                DirectoryInfo di = new DirectoryInfo(path);
                EmptyCache(di);
            }
            catch { }
        }
        // EmptyCache((new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache))); 
        private void EmptyCache(DirectoryInfo folder)
        {
            foreach (FileInfo file in folder.GetFiles())
            {
                //loop through each file in the folder and delete that 
                try
                {
                    file.Delete();
                }
                catch (Exception)
                { //we have to use try cache, because there are some files that can’t be delete 
                  // because those are system files. 
                  // So we don’t want to stop our program at that point when our program try 
                  // to delete any of those file and exception occurs 
                }
            }
            //loop through all the sub folder in the current folder provided 
            foreach (DirectoryInfo subfolder in folder.GetDirectories())
            {
                EmptyCache(subfolder);
                subfolder.Delete(true);
            }
        }
    }
}
