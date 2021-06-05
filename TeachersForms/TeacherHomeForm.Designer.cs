
namespace OOP_Final_Project
{
    partial class TeacherHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentsClassesName_btn = new System.Windows.Forms.Button();
            this.MarkStudents_btn = new System.Windows.Forms.Button();
            this.ExamMake_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StudentsClassesName_btn
            // 
            this.StudentsClassesName_btn.Location = new System.Drawing.Point(480, 52);
            this.StudentsClassesName_btn.Name = "StudentsClassesName_btn";
            this.StudentsClassesName_btn.Size = new System.Drawing.Size(174, 59);
            this.StudentsClassesName_btn.TabIndex = 1;
            this.StudentsClassesName_btn.Text = "مشاهده لیست زبان آموزان هر کلاس";
            this.StudentsClassesName_btn.UseVisualStyleBackColor = true;
            this.StudentsClassesName_btn.Click += new System.EventHandler(this.StudentsClassesName_btn_Click);
            // 
            // MarkStudents_btn
            // 
            this.MarkStudents_btn.Location = new System.Drawing.Point(480, 193);
            this.MarkStudents_btn.Name = "MarkStudents_btn";
            this.MarkStudents_btn.Size = new System.Drawing.Size(174, 54);
            this.MarkStudents_btn.TabIndex = 2;
            this.MarkStudents_btn.Text = "وارد کردن نمرات ";
            this.MarkStudents_btn.UseVisualStyleBackColor = true;
            this.MarkStudents_btn.Click += new System.EventHandler(this.MarkStudents_btn_Click);
            // 
            // ExamMake_btn
            // 
            this.ExamMake_btn.Location = new System.Drawing.Point(481, 327);
            this.ExamMake_btn.Name = "ExamMake_btn";
            this.ExamMake_btn.Size = new System.Drawing.Size(173, 60);
            this.ExamMake_btn.TabIndex = 3;
            this.ExamMake_btn.Text = "ساخت آزمون آنلاین ";
            this.ExamMake_btn.UseVisualStyleBackColor = true;
            this.ExamMake_btn.Click += new System.EventHandler(this.ExamMake_btn_Click);
            // 
            // TeacherHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExamMake_btn);
            this.Controls.Add(this.MarkStudents_btn);
            this.Controls.Add(this.StudentsClassesName_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherHomeForm";
            this.Text = "TeacherHomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StudentsClassesName_btn;
        private System.Windows.Forms.Button MarkStudents_btn;
        private System.Windows.Forms.Button ExamMake_btn;
    }
}