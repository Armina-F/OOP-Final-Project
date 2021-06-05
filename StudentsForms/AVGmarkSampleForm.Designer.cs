
namespace OOP_Final_Project
{
    partial class AVGmarkSample
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(524, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl1.Size = new System.Drawing.Size(186, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "نمره کلاسی خود را وارد کنید :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(524, 146);
            this.lbl2.Name = "lbl2";
            this.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl2.Size = new System.Drawing.Size(189, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "نمره امتحان خود را وارد کنید :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(532, 237);
            this.lbl3.Name = "lbl3";
            this.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl3.Size = new System.Drawing.Size(178, 20);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "میانگین نمره (نمره پایانی ) :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(299, 50);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(154, 27);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(299, 146);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(154, 27);
            this.txt2.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(299, 234);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(154, 27);
            this.txt3.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(606, 376);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(227, 20);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "براساس نمره پایانی شما در این ترم ";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(447, 376);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(125, 27);
            this.txt4.TabIndex = 11;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(393, 379);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(17, 20);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "و";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(169, 376);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(201, 27);
            this.txt5.TabIndex = 13;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(79, 383);
            this.lbl6.Name = "lbl6";
            this.lbl6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl6.Size = new System.Drawing.Size(53, 20);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "هستید.";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(370, 459);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(149, 29);
            this.btn.TabIndex = 15;
            this.btn.Text = "ثبت";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // AVGmarkSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 516);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "AVGmarkSample";
            this.Text = "FindAVGmarkSample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btn;
    }
}