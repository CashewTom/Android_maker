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

        private void button_change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please select your project.";
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                linkLabel1.Text = folderDialog.SelectedPath;
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                String str = "create project --target ";
                str += target_tb.Text;
                str += " --name " + name_tb.Text;
                str += " --activity " + activity_tb.Text;
                str += " --path " + linkLabel1.Text + "\\" + directory_tb.Text;
                str += " --package " + package_tb.Text;

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "android";
                process.StartInfo.Arguments = str;
                FormConsole fc = new FormConsole();
                fc.doProcess(process);
                linkLabel1.Text = linkLabel1.Text + "\\" + directory_tb.Text;
            }
        }

        private void button_compile_Click(object sender, EventArgs e)
        {
            if (!linkLabel1.Text.Equals("None"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = linkLabel1.Text;
                process.StartInfo.FileName = "ant.bat";
                process.StartInfo.Arguments = "debug";
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
    }
}