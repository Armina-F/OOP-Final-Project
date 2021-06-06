
namespace OOP_Final_Project
{
    partial class StudentHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finacial_btn = new System.Windows.Forms.Button();
            this.markCaculator_btn = new System.Windows.Forms.Button();
            this.Exam_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // finacial_btn
            // 
            this.finacial_btn.Location = new System.Drawing.Point(435, 62);
            this.finacial_btn.Name = "finacial_btn";
            this.finacial_btn.Size = new System.Drawing.Size(198, 48);
            this.finacial_btn.TabIndex = 1;
            this.finacial_btn.Text = "وضعیت مالی";
            this.finacial_btn.UseVisualStyleBackColor = true;
            this.finacial_btn.Click += new System.EventHandler(this.Finacial_btn_Click);
            // 
            // markCaculator_btn
            // 
            this.markCaculator_btn.Location = new System.Drawing.Point(435, 181);
            this.markCaculator_btn.Name = "markCaculator_btn";
            this.markCaculator_btn.Size = new System.Drawing.Size(197, 52);
            this.markCaculator_btn.TabIndex = 2;
            this.markCaculator_btn.Text = "محاسبه گر معدل";
            this.markCaculator_btn.UseVisualStyleBackColor = true;
            this.markCaculator_btn.Click += new System.EventHandler(this.MarkCaculator_btn_Click);
            // 
            // Exam_btn
            // 
            this.Exam_btn.Location = new System.Drawing.Point(435, 299);
            this.Exam_btn.Name = "Exam_btn";
            this.Exam_btn.Size = new System.Drawing.Size(198, 48);
            this.Exam_btn.TabIndex = 4;
            this.Exam_btn.Text = "آزمون آنلاین";
            this.Exam_btn.UseVisualStyleBackColor = true;
            this.Exam_btn.Click += new System.EventHandler(this.Exam_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(435, 415);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(198, 51);
            this.Back_btn.TabIndex = 5;
            this.Back_btn.Text = "بازگشت به منوی قبلی";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // StudentHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 492);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Exam_btn);
            this.Controls.Add(this.markCaculator_btn);
            this.Controls.Add(this.finacial_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentHomeForm";
            this.Text = "StudentHomeForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button finacial_btn;
        private System.Windows.Forms.Button markCaculator_btn;
        private System.Windows.Forms.Button Exam_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}