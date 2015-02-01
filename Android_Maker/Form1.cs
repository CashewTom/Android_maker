using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Maker
{
    public partial class MyForm: System.Windows.Forms.Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please select your project.";
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                linkLabel1.Text = folderDialog.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                String str = "create project --target ";
                str += target_tb.Text;
                str += " --name " + name_tb.Text;
                str += " --activity " + activity_tb.Text;
                str += " --path " + linkLabel1.Text + "\\" + directory_tb.Text;
                str += " --package " + package_tb.Text;
                System.Diagnostics.Process.Start("android", @str);
                linkLabel1.Text = linkLabel1.Text + "\\" + directory_tb.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
                process.WorkingDirectory = linkLabel1.Text;
                process.FileName = "ant.bat";
                process.Arguments = "debug";
                System.Diagnostics.Process.Start(process);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = linkLabel1.Text;
                process.StartInfo.FileName = "adb";
                process.StartInfo.Arguments = "kill-server";
                process.Start();
                process.WaitForExit();
                process.StartInfo.Arguments = "start-server";
                process.Start();
                process.WaitForExit();
                process.StartInfo.Arguments = "devices";
                process.Start();
                process.WaitForExit();
                process.StartInfo.Arguments = "install bin\\"+name_tb.Text+"-debug.apk";
                process.Start();
                process.WaitForExit();
            }
        }
    }
}