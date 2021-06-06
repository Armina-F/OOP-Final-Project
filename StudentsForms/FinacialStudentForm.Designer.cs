
namespace OOP_Final_Project
{
    partial class FinacialStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinacialStudentForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.historyPayments_btn = new System.Windows.Forms.Button();
            this.NewPayment_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // historyPayments_btn
            // 
            this.historyPayments_btn.Location = new System.Drawing.Point(456, 67);
            this.historyPayments_btn.Name = "historyPayments_btn";
            this.historyPayments_btn.Size = new System.Drawing.Size(192, 58);
            this.historyPayments_btn.TabIndex = 1;
            this.historyPayments_btn.Text = "سوابق تمامی پرداخت ها ";
            this.historyPayments_btn.UseVisualStyleBackColor = true;
            this.historyPayments_btn.Click += new System.EventHandler(this.historyPayments_btn_Click);
            // 
            // NewPayment_btn
            // 
            this.NewPayment_btn.Location = new System.Drawing.Point(457, 219);
            this.NewPayment_btn.Name = "NewPayment_btn";
            this.NewPayment_btn.Size = new System.Drawing.Size(191, 58);
            this.NewPayment_btn.TabIndex = 2;
            this.NewPayment_btn.Text = "پرداخت شهریه ";
            this.NewPayment_btn.UseVisualStyleBackColor = true;
            this.NewPayment_btn.Click += new System.EventHandler(this.NewPayment_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(457, 354);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(191, 49);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = "بازگشت به منوی قبلی";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // FinacialStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 451);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.NewPayment_btn);
            this.Controls.Add(this.historyPayments_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FinacialStudentForm";
            this.Text = "FinacialStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button historyPayments_btn;
        private System.Windows.Forms.Button NewPayment_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}