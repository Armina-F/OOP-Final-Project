
namespace OOP_Final_Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.Location = new System.Drawing.Point(665, 102);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(70, 20);
            this.UserName_lbl.TabIndex = 0;
            this.UserName_lbl.Text = "نام کاربری";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(674, 200);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(61, 20);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "رمز عبور";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(391, 102);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(183, 27);
            this.username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(391, 200);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(183, 27);
            this.password_txt.TabIndex = 3;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(591, 330);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(175, 29);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "ورود ";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.StudentLogin_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(353, 330);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(161, 29);
            this.Exit_btn.TabIndex = 5;
            this.Exit_btn.Text = "خروج";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.UserName_lbl);
            this.Name = "LoginForm";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox username_txt;
    }
}

