namespace SuperMarket
{
    partial class login_form
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
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textEdit1_users_pw;
        private System.Windows.Forms.ComboBox comboBox1_users_name;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1_users_pw = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1_users_name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1_users_pw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::SuperMarket.Properties.Resources.Store;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 748);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textEdit1_users_pw);
            this.panel2.Controls.Add(this.comboBox1_users_name);
            this.panel2.Location = new System.Drawing.Point(371, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 506);
            this.panel2.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(120, 286);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(208, 63);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "تسجيل الدخول";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.1791F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(119, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "سوبر ماركت";
            // 
            // textEdit1_users_pw
            // 
            this.textEdit1_users_pw.Location = new System.Drawing.Point(44, 213);
            this.textEdit1_users_pw.Name = "textEdit1_users_pw";
            this.textEdit1_users_pw.Properties.Appearance.Font = new System.Drawing.Font("AGA Rasheeq V.2 رشيق", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textEdit1_users_pw.Properties.Appearance.Options.UseFont = true;
            this.textEdit1_users_pw.Properties.AutoHeight = false;
            this.textEdit1_users_pw.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1_users_pw.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.textEdit1_users_pw.Size = new System.Drawing.Size(350, 46);
            this.textEdit1_users_pw.TabIndex = 1;
            // 
            // comboBox1_users_name
            // 
            this.comboBox1_users_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1_users_name.Font = new System.Drawing.Font("AGA Rasheeq V.2 رشيق", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox1_users_name.FormattingEnabled = true;
            this.comboBox1_users_name.Location = new System.Drawing.Point(44, 161);
            this.comboBox1_users_name.Name = "comboBox1_users_name";
            this.comboBox1_users_name.Size = new System.Drawing.Size(350, 46);
            this.comboBox1_users_name.TabIndex = 0;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 748);
            this.Controls.Add(this.panel1);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1_users_pw.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}