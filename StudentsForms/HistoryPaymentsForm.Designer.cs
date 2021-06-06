
namespace OOP_Final_Project
{
    partial class HistoryPaymentsForm
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
            this.PaymentsHistory_dgv = new System.Windows.Forms.DataGridView();
            this.StudentId_lbl = new System.Windows.Forms.Label();
            this.StudentId_txt = new System.Windows.Forms.TextBox();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsHistory_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentsHistory_dgv
            // 
            this.PaymentsHistory_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentsHistory_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PaymentsHistory_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsHistory_dgv.Location = new System.Drawing.Point(43, 103);
            this.PaymentsHistory_dgv.Name = "PaymentsHistory_dgv";
            this.PaymentsHistory_dgv.ReadOnly = true;
            this.PaymentsHistory_dgv.RowHeadersWidth = 51;
            this.PaymentsHistory_dgv.RowTemplate.Height = 29;
            this.PaymentsHistory_dgv.Size = new System.Drawing.Size(802, 419);
            this.PaymentsHistory_dgv.TabIndex = 0;
            // 
            // StudentId_lbl
            // 
            this.StudentId_lbl.AutoSize = true;
            this.StudentId_lbl.Location = new System.Drawing.Point(57, 29);
            this.StudentId_lbl.Name = "StudentId_lbl";
            this.StudentId_lbl.Size = new System.Drawing.Size(118, 20);
            this.StudentId_lbl.TabIndex = 1;
            this.StudentId_lbl.Text = "شماره زبان آموزی";
            // 
            // StudentId_txt
            // 
            this.StudentId_txt.Location = new System.Drawing.Point(194, 29);
            this.StudentId_txt.Name = "StudentId_txt";
            this.StudentId_txt.ReadOnly = true;
            this.StudentId_txt.Size = new System.Drawing.Size(145, 27);
            this.StudentId_txt.TabIndex = 4;
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(615, 563);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(175, 52);
            this.Show_btn.TabIndex = 5;
            this.Show_btn.Text = "نمایش";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(330, 563);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(167, 52);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "بازگشت به منوی قبلی";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // HistoryPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 644);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.StudentId_txt);
            this.Controls.Add(this.StudentId_lbl);
            this.Controls.Add(this.PaymentsHistory_dgv);
            this.Name = "HistoryPaymentsForm";
            this.Text = "HistoryPaymentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsHistory_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PaymentsHistory_dgv;
        private System.Windows.Forms.Label StudentId_lbl;
        private System.Windows.Forms.TextBox StudentId_txt;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}