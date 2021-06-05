
namespace OOP_Final_Project
{
    partial class SeeStudentInfoForm
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
            this.StudentInfo_dgv = new System.Windows.Forms.DataGridView();
            this.Show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInfo_dgv
            // 
            this.StudentInfo_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo_dgv.Location = new System.Drawing.Point(12, 92);
            this.StudentInfo_dgv.Name = "StudentInfo_dgv";
            this.StudentInfo_dgv.ReadOnly = true;
            this.StudentInfo_dgv.RowHeadersWidth = 51;
            this.StudentInfo_dgv.RowTemplate.Height = 29;
            this.StudentInfo_dgv.Size = new System.Drawing.Size(919, 432);
            this.StudentInfo_dgv.TabIndex = 3;
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(563, 546);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(141, 54);
            this.Show_btn.TabIndex = 4;
            this.Show_btn.Text = "نمایش";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // SeeStudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 821);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.StudentInfo_dgv);
            this.Name = "SeeStudentInfoForm";
            this.Text = "SeeStudentInfo";
            this.Load += new System.EventHandler(this.SeeStudentInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StudentGroupName;
        private System.Windows.Forms.DataGridView StudentInfo_dgv;
        private System.Windows.Forms.Button Show_btn;
    }
}