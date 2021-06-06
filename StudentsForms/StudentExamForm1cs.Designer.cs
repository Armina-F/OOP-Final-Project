
namespace OOP_Final_Project.StudentsForms
{
    partial class StudentExamForm1cs
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentId_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExamSart_btn = new System.Windows.Forms.Button();
            this.ExamNames_cb = new System.Windows.Forms.ComboBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره زبان آموزی";
            // 
            // StudentId_txt
            // 
            this.StudentId_txt.Location = new System.Drawing.Point(484, 40);
            this.StudentId_txt.Name = "StudentId_txt";
            this.StudentId_txt.ReadOnly = true;
            this.StudentId_txt.Size = new System.Drawing.Size(125, 27);
            this.StudentId_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "شماره آزمون";
            // 
            // ExamSart_btn
            // 
            this.ExamSart_btn.Location = new System.Drawing.Point(425, 347);
            this.ExamSart_btn.Name = "ExamSart_btn";
            this.ExamSart_btn.Size = new System.Drawing.Size(184, 48);
            this.ExamSart_btn.TabIndex = 4;
            this.ExamSart_btn.Text = "شروع آزمون";
            this.ExamSart_btn.UseVisualStyleBackColor = true;
            this.ExamSart_btn.Click += new System.EventHandler(this.ExamSart_btn_Click);
            // 
            // ExamNames_cb
            // 
            this.ExamNames_cb.FormattingEnabled = true;
            this.ExamNames_cb.Location = new System.Drawing.Point(458, 119);
            this.ExamNames_cb.Name = "ExamNames_cb";
            this.ExamNames_cb.Size = new System.Drawing.Size(151, 28);
            this.ExamNames_cb.TabIndex = 5;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(137, 347);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(182, 48);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "بازگشت به منوی قبلی";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // StudentExamForm1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.ExamNames_cb);
            this.Controls.Add(this.ExamSart_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentId_txt);
            this.Controls.Add(this.label1);
            this.Name = "StudentExamForm1cs";
            this.Text = "StudentExamForm1cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentId_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExamSart_btn;
        private System.Windows.Forms.ComboBox ExamNames_cb;
        private System.Windows.Forms.Button Back_btn;
    }
}