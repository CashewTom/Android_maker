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
    public partial class FormConsole : Form
    {
        System.Diagnostics.Process process;
        public FormConsole()
        {
            InitializeComponent();
        }
        public void doProcess(System.Diagnostics.Process set_process)
        {
            process = set_process;
            ConsoleStart();
        }
        private void ConsoleStart()
        {
            button_ok.Enabled = false;
            Show();

            Application.DoEvents();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output += process.StandardError.ReadToEnd();
            output = output.Replace("\r\r\n", "\n");
            ResultText.Text += output;
            button_ok.Enabled = true;
            Application.DoEvents();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
