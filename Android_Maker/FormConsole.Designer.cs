namespace Android_Maker
{
    partial class FormConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(12, 12);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(596, 237);
            this.ResultText.TabIndex = 0;
            this.ResultText.Text = "";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(470, 255);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(137, 37);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 304);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.ResultText);
            this.Name = "FormConsole";
            this.Text = "Console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultText;
        private System.Windows.Forms.Button button_ok;
    }
}