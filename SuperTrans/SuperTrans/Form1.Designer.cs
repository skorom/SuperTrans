namespace SuperTrans
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.log_pass = new System.Windows.Forms.TextBox();
            this.log_user = new System.Windows.Forms.TextBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_pass2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_pass = new System.Windows.Forms.TextBox();
            this.reg_user = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.log_pass);
            this.tabPage1.Controls.Add(this.log_user);
            this.tabPage1.Controls.Add(this.log_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(458, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bejelentkezés";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jelszó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Felhasználónév";
            // 
            // log_pass
            // 
            this.log_pass.Location = new System.Drawing.Point(40, 200);
            this.log_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_pass.Name = "log_pass";
            this.log_pass.PasswordChar = '*';
            this.log_pass.Size = new System.Drawing.Size(367, 26);
            this.log_pass.TabIndex = 2;
            // 
            // log_user
            // 
            this.log_user.Location = new System.Drawing.Point(40, 108);
            this.log_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_user.Name = "log_user";
            this.log_user.Size = new System.Drawing.Size(367, 26);
            this.log_user.TabIndex = 1;
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(130, 377);
            this.log_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(189, 35);
            this.log_btn.TabIndex = 0;
            this.log_btn.Text = "Belépés";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.reg_pass2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.reg_pass);
            this.tabPage2.Controls.Add(this.reg_user);
            this.tabPage2.Controls.Add(this.reg_btn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(458, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regisztráció";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jelszó mégegyszer";
            // 
            // reg_pass2
            // 
            this.reg_pass2.Location = new System.Drawing.Point(45, 260);
            this.reg_pass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_pass2.Name = "reg_pass2";
            this.reg_pass2.PasswordChar = '*';
            this.reg_pass2.Size = new System.Drawing.Size(367, 26);
            this.reg_pass2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jelszó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Felhasználónév";
            // 
            // reg_pass
            // 
            this.reg_pass.Location = new System.Drawing.Point(45, 174);
            this.reg_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.PasswordChar = '*';
            this.reg_pass.Size = new System.Drawing.Size(367, 26);
            this.reg_pass.TabIndex = 6;
            // 
            // reg_user
            // 
            this.reg_user.Location = new System.Drawing.Point(45, 82);
            this.reg_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_user.Name = "reg_user";
            this.reg_user.Size = new System.Drawing.Size(367, 26);
            this.reg_user.TabIndex = 5;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(130, 377);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(189, 35);
            this.reg_btn.TabIndex = 4;
            this.reg_btn.Text = "Regisztráció";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 525);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox log_pass;
        private System.Windows.Forms.TextBox log_user;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_pass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_pass;
        private System.Windows.Forms.TextBox reg_user;
        private System.Windows.Forms.Button reg_btn;
    }
}

