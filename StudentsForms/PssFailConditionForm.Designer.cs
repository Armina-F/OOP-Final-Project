
namespace OOP_Final_Project
{
    partial class PassFailNextTermCondition
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
            this.llbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(429, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl1.Size = new System.Drawing.Size(111, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "شماره ترم جاری :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(417, 146);
            this.lbl2.Name = "lbl2";
            this.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl2.Size = new System.Drawing.Size(123, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "وضعیت ترم جاری :";
            // 
            // llbl3
            // 
            this.llbl3.AutoSize = true;
            this.llbl3.Location = new System.Drawing.Point(428, 240);
            this.llbl3.Name = "llbl3";
            this.llbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llbl3.Size = new System.Drawing.Size(112, 20);
            this.llbl3.TabIndex = 8;
            this.llbl3.Text = "شماره ترم جدید :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(426, 344);
            this.lbl4.Name = "lbl4";
            this.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl4.Size = new System.Drawing.Size(114, 20);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "شهریه ترم جدید :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(258, 63);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(125, 27);
            this.txt1.TabIndex = 10;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(258, 146);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(125, 27);
            this.txt2.TabIndex = 11;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(258, 240);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(125, 27);
            this.txt3.TabIndex = 12;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(258, 344);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(125, 27);
            this.txt4.TabIndex = 13;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(300, 453);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(208, 41);
            this.btn.TabIndex = 14;
            this.btn.Text = "ثبت";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // PassFailNextTermCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 566);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.llbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "PassFailNextTermCondition";
            this.Text = " PassFailNextTermCondition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label llbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btn;
    }
}