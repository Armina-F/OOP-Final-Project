
namespace OOP_Final_Project
{
    partial class ExamForm
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
            this.NumberOFQuestions_txt = new System.Windows.Forms.TextBox();
            this.ExamName_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOFQuestions_txt
            // 
            this.NumberOFQuestions_txt.Location = new System.Drawing.Point(673, 29);
            this.NumberOFQuestions_txt.Name = "NumberOFQuestions_txt";
            this.NumberOFQuestions_txt.Size = new System.Drawing.Size(125, 27);
            this.NumberOFQuestions_txt.TabIndex = 0;
            // 
            // ExamName_txt
            // 
            this.ExamName_txt.Location = new System.Drawing.Point(73, 89);
            this.ExamName_txt.Name = "ExamName_txt";
            this.ExamName_txt.Size = new System.Drawing.Size(725, 27);
            this.ExamName_txt.TabIndex = 1;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(592, 229);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(262, 48);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "ثبت";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "تعداد سوالات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام آزمون";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(191, 229);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(256, 48);
            this.Exit_btn.TabIndex = 5;
            this.Exit_btn.Text = "برگشت";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 368);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.ExamName_txt);
            this.Controls.Add(this.NumberOFQuestions_txt);
            this.Name = "ExamForm";
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOFQuestions_txt;
        private System.Windows.Forms.TextBox ExamName_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit_btn;
    }
}