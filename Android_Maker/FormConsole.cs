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
        private async void ConsoleStart()
        {
            button_ok.Enabled = false;
            Show();

            Application.DoEvents();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();
            char[] stderr = new char[256];
            char[] stdout = new char[256];
            Task<int> output2 = process.StandardOutput.ReadAsync(stdout, 0, 256);
            Task<int> output3 = process.StandardError.ReadAsync(stderr,0,256);
            while (!process.HasExited)
            {
                if (output2.IsCompleted)
                {
                    ResultText.Text += new string(stdout);
                    ResultText.Text += "#######";
                    output2 = process.StandardOutput.ReadAsync(stdout, 0, 256);
                }
                if (output3.IsCompleted)
                {
                    ResultText.Text += new string(stderr);
                    ResultText.Text += "SAFDAFDFF";
                    output3 = process.StandardError.ReadAsync(stderr,0,256);
                }
                Application.DoEvents();
            }
            output2.Wait();
            output3.Wait();
            //if (output2.IsCompleted)ResultText.Text += new string(stdout);
            //if (output3.IsCompleted)ResultText.Text += new string(stderr);
            string output = process.StandardOutput.ReadToEnd();
            output += process.StandardError.ReadToEnd();
            output = output.Replace("\r\r\n", "\n");
            ResultText.Text += output;
            button_ok.Enabled = true;
            process.WaitForExit();
            Application.DoEvents();
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
