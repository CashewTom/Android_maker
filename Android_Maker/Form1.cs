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
            button_compile.Enabled = false;
            button_create.Enabled = false;
            button_install.Enabled = false;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please select your project.";
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                linkLabel1.Text = folderDialog.SelectedPath;
                button_compile.Enabled = true;
                button_create.Enabled = true;
                button_install.Enabled = true;
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                String str = "/c android create project --target ";
                str += target_tb.Text;
                str += " --name " + name_tb.Text;
                str += " --activity " + activity_tb.Text;
                str += " --path " + linkLabel1.Text+"\\"+directory_tb.Text;
                str += " --package " + package_tb.Text;

                
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
                process.StartInfo.Arguments = str;
                FormConsole fc = new FormConsole();
                fc.doProcess(process);
                process.WaitForExit();
                linkLabel1.Text = linkLabel1.Text + "\\" + directory_tb.Text;
            }
        }

        private void button_compile_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = linkLabel1.Text;
                process.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
                process.StartInfo.Arguments = "/c ant.bat debug";
                FormConsole fc = new FormConsole();
                fc.doProcess(process);
            }
        }

        private void button_install_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = linkLabel1.Text;
                process.StartInfo.FileName = "adb";
                FormConsole fc = new FormConsole();

                process.StartInfo.Arguments = "kill-server";
                fc.doProcess(process);

                process.StartInfo.Arguments = "start-server";
                fc.doProcess(process);

                process.StartInfo.Arguments = "devices";
                fc.doProcess(process);

                process.StartInfo.Arguments = "install bin\\" + name_tb.Text + "-debug.apk";
                fc.doProcess(process);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.Process.Start(linkLabel1.Text);
            }
        }
    }
}