
namespace OOP_Final_Project
{
    partial class AddMarkForm
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
            this.Submit_btn = new System.Windows.Forms.Button();
            this.students_dgv = new System.Windows.Forms.DataGridView();
            this.Back_btn = new System.Windows.Forms.Button();
            this.StudentId_txt = new System.Windows.Forms.TextBox();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.ClassMark_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(829, 383);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(170, 54);
            this.Submit_btn.TabIndex = 5;
            this.Submit_btn.Text = "ثبت";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // students_dgv
            // 
            this.students_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.students_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_dgv.Location = new System.Drawing.Point(31, 57);
            this.students_dgv.MultiSelect = false;
            this.students_dgv.Name = "students_dgv";
            this.students_dgv.ReadOnly = true;
            this.students_dgv.RowHeadersWidth = 51;
            this.students_dgv.RowTemplate.Height = 29;
            this.students_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.students_dgv.Size = new System.Drawing.Size(754, 465);
            this.students_dgv.TabIndex = 6;
            this.students_dgv.SelectionChanged += new System.EventHandler(this.Students_dgv_SelectionChanged);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(328, 544);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(165, 54);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "بازگشت به منوی قبلی";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // StudentId_txt
            // 
            this.StudentId_txt.Location = new System.Drawing.Point(844, 57);
            this.StudentId_txt.Name = "StudentId_txt";
            this.StudentId_txt.ReadOnly = true;
            this.StudentId_txt.Size = new System.Drawing.Size(125, 27);
            this.StudentId_txt.TabIndex = 8;
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(844, 146);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.ReadOnly = true;
            this.FirstName_txt.Size = new System.Drawing.Size(125, 27);
            this.FirstName_txt.TabIndex = 9;
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(844, 225);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.ReadOnly = true;
            this.LastName_txt.Size = new System.Drawing.Size(125, 27);
            this.LastName_txt.TabIndex = 10;
            // 
            // ClassMark_txt
            // 
            this.ClassMark_txt.Location = new System.Drawing.Point(844, 304);
            this.ClassMark_txt.Name = "ClassMark_txt";
            this.ClassMark_txt.Size = new System.Drawing.Size(125, 27);
            this.ClassMark_txt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(989, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "شماره دانشجویی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام دانشجو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(975, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "نام خانوادگی دانشجو";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1013, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "نمره کلاسی";
            // 
            // AddMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 638);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassMark_txt);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.StudentId_txt);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.students_dgv);
            this.Controls.Add(this.Submit_btn);
            this.Name = "AddMarkForm";
            this.Text = "AddMarkForm";
            this.Load += new System.EventHandler(this.AddMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.DataGridView students_dgv;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox StudentId_txt;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.TextBox ClassMark_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}