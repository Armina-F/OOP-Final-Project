
namespace OOP_Final_Project.TeachersForms
{
    partial class NewExamQuestionForm
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
            this.CurrentQuestionNumber_txt = new System.Windows.Forms.TextBox();
            this.Question_RTXT = new System.Windows.Forms.RichTextBox();
            this.A_rb = new System.Windows.Forms.RadioButton();
            this.C_rb = new System.Windows.Forms.RadioButton();
            this.D_rb = new System.Windows.Forms.RadioButton();
            this.B_rb = new System.Windows.Forms.RadioButton();
            this.A_rtxt = new System.Windows.Forms.RichTextBox();
            this.C_rtxt = new System.Windows.Forms.RichTextBox();
            this.B_rtxt = new System.Windows.Forms.RichTextBox();
            this.D_rtxt = new System.Windows.Forms.RichTextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentQuestionNumber_txt
            // 
            this.CurrentQuestionNumber_txt.Location = new System.Drawing.Point(575, 31);
            this.CurrentQuestionNumber_txt.Name = "CurrentQuestionNumber_txt";
            this.CurrentQuestionNumber_txt.ReadOnly = true;
            this.CurrentQuestionNumber_txt.Size = new System.Drawing.Size(145, 27);
            this.CurrentQuestionNumber_txt.TabIndex = 0;
            // 
            // Question_RTXT
            // 
            this.Question_RTXT.Location = new System.Drawing.Point(12, 110);
            this.Question_RTXT.Name = "Question_RTXT";
            this.Question_RTXT.Size = new System.Drawing.Size(841, 98);
            this.Question_RTXT.TabIndex = 1;
            this.Question_RTXT.Text = "";
            // 
            // A_rb
            // 
            this.A_rb.AutoSize = true;
            this.A_rb.Location = new System.Drawing.Point(770, 260);
            this.A_rb.Name = "A_rb";
            this.A_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.A_rb.Size = new System.Drawing.Size(40, 24);
            this.A_rb.TabIndex = 2;
            this.A_rb.TabStop = true;
            this.A_rb.Text = "A";
            this.A_rb.UseVisualStyleBackColor = true;
            // 
            // C_rb
            // 
            this.C_rb.AutoSize = true;
            this.C_rb.Location = new System.Drawing.Point(290, 260);
            this.C_rb.Name = "C_rb";
            this.C_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C_rb.Size = new System.Drawing.Size(39, 24);
            this.C_rb.TabIndex = 3;
            this.C_rb.TabStop = true;
            this.C_rb.Text = "C";
            this.C_rb.UseVisualStyleBackColor = true;
            // 
            // D_rb
            // 
            this.D_rb.AutoSize = true;
            this.D_rb.Location = new System.Drawing.Point(290, 360);
            this.D_rb.Name = "D_rb";
            this.D_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.D_rb.Size = new System.Drawing.Size(41, 24);
            this.D_rb.TabIndex = 4;
            this.D_rb.TabStop = true;
            this.D_rb.Text = "D";
            this.D_rb.UseVisualStyleBackColor = true;
            // 
            // B_rb
            // 
            this.B_rb.AutoSize = true;
            this.B_rb.Location = new System.Drawing.Point(770, 360);
            this.B_rb.Name = "B_rb";
            this.B_rb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_rb.Size = new System.Drawing.Size(39, 24);
            this.B_rb.TabIndex = 5;
            this.B_rb.TabStop = true;
            this.B_rb.Text = "B";
            this.B_rb.UseVisualStyleBackColor = true;
            // 
            // A_rtxt
            // 
            this.A_rtxt.Location = new System.Drawing.Point(500, 250);
            this.A_rtxt.Name = "A_rtxt";
            this.A_rtxt.Size = new System.Drawing.Size(260, 63);
            this.A_rtxt.TabIndex = 6;
            this.A_rtxt.Text = "";
            // 
            // C_rtxt
            // 
            this.C_rtxt.Location = new System.Drawing.Point(15, 250);
            this.C_rtxt.Name = "C_rtxt";
            this.C_rtxt.Size = new System.Drawing.Size(256, 63);
            this.C_rtxt.TabIndex = 7;
            this.C_rtxt.Text = "";
            // 
            // B_rtxt
            // 
            this.B_rtxt.Location = new System.Drawing.Point(500, 350);
            this.B_rtxt.Name = "B_rtxt";
            this.B_rtxt.Size = new System.Drawing.Size(260, 63);
            this.B_rtxt.TabIndex = 8;
            this.B_rtxt.Text = "";
            // 
            // D_rtxt
            // 
            this.D_rtxt.Location = new System.Drawing.Point(15, 350);
            this.D_rtxt.Name = "D_rtxt";
            this.D_rtxt.Size = new System.Drawing.Size(256, 63);
            this.D_rtxt.TabIndex = 9;
            this.D_rtxt.Text = "";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(321, 468);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(183, 63);
            this.Submit_btn.TabIndex = 10;
            this.Submit_btn.Text = "ثبت";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "سوال";
            // 
            // NewExamQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.D_rtxt);
            this.Controls.Add(this.B_rtxt);
            this.Controls.Add(this.C_rtxt);
            this.Controls.Add(this.A_rtxt);
            this.Controls.Add(this.B_rb);
            this.Controls.Add(this.D_rb);
            this.Controls.Add(this.C_rb);
            this.Controls.Add(this.A_rb);
            this.Controls.Add(this.Question_RTXT);
            this.Controls.Add(this.CurrentQuestionNumber_txt);
            this.Name = "NewExamQuestionForm";
            this.Text = "NewExamQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentQuestionNumber_txt;
        private System.Windows.Forms.RichTextBox Question_RTXT;
        private System.Windows.Forms.RadioButton A_rb;
        private System.Windows.Forms.RadioButton C_rb;
        private System.Windows.Forms.RadioButton D_rb;
        private System.Windows.Forms.RadioButton B_rb;
        private System.Windows.Forms.RichTextBox A_rtxt;
        private System.Windows.Forms.RichTextBox C_rtxt;
        private System.Windows.Forms.RichTextBox B_rtxt;
        private System.Windows.Forms.RichTextBox D_rtxt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label1;
    }
}