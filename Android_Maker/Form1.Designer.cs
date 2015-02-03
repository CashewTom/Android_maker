namespace Android_Maker
{
    partial class MyForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_change = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_compile = new System.Windows.Forms.Button();
            this.button_install = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.package_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.directory_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.activity_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.target_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "None";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_change);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory";
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(230, 13);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(74, 31);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(12, 68);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(79, 29);
            this.button_create.TabIndex = 5;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_compile
            // 
            this.button_compile.Location = new System.Drawing.Point(130, 68);
            this.button_compile.Name = "button_compile";
            this.button_compile.Size = new System.Drawing.Size(79, 29);
            this.button_compile.TabIndex = 6;
            this.button_compile.Text = "Compile";
            this.button_compile.UseVisualStyleBackColor = true;
            this.button_compile.Click += new System.EventHandler(this.button_compile_Click);
            // 
            // button_install
            // 
            this.button_install.Location = new System.Drawing.Point(243, 68);
            this.button_install.Name = "button_install";
            this.button_install.Size = new System.Drawing.Size(79, 29);
            this.button_install.TabIndex = 7;
            this.button_install.Text = "Install";
            this.button_install.UseVisualStyleBackColor = true;
            this.button_install.Click += new System.EventHandler(this.button_install_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.package_tb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.directory_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.activity_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.name_tb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.target_tb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 147);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // package_tb
            // 
            this.package_tb.Location = new System.Drawing.Point(110, 111);
            this.package_tb.Name = "package_tb";
            this.package_tb.Size = new System.Drawing.Size(194, 19);
            this.package_tb.TabIndex = 9;
            this.package_tb.Text = "org.example.HelloWorld";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Package";
            // 
            // directory_tb
            // 
            this.directory_tb.Location = new System.Drawing.Point(110, 86);
            this.directory_tb.Name = "directory_tb";
            this.directory_tb.Size = new System.Drawing.Size(194, 19);
            this.directory_tb.TabIndex = 7;
            this.directory_tb.Text = "HelloWorld";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Directory name";
            // 
            // activity_tb
            // 
            this.activity_tb.Location = new System.Drawing.Point(110, 61);
            this.activity_tb.Name = "activity_tb";
            this.activity_tb.Size = new System.Drawing.Size(194, 19);
            this.activity_tb.TabIndex = 5;
            this.activity_tb.Text = "HelloWorldActivity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Activity";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(110, 36);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(194, 19);
            this.name_tb.TabIndex = 3;
            this.name_tb.Text = "HelloWorld";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // target_tb
            // 
            this.target_tb.Location = new System.Drawing.Point(110, 11);
            this.target_tb.Name = "target_tb";
            this.target_tb.Size = new System.Drawing.Size(194, 19);
            this.target_tb.TabIndex = 1;
            this.target_tb.Text = "android-14";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target version";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_install);
            this.Controls.Add(this.button_compile);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "MyForm";
            this.Text = "Android Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_compile;
        private System.Windows.Forms.Button button_install;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox package_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox directory_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox activity_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox target_tb;
        private System.Windows.Forms.Label label1;
    }
}

