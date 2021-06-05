
namespace OOP_Final_Project
{
    partial class NewPaymentForm
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
            this.CardNumber_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.ExpDate_lbl = new System.Windows.Forms.Label();
            this.Cvv2_lbl = new System.Windows.Forms.Label();
            this.PayingCost_txt = new System.Windows.Forms.TextBox();
            this.CardNumber_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Cvv2_txt = new System.Windows.Forms.TextBox();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.PayingCost_lbl = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.MonthExt_cb = new System.Windows.Forms.ComboBox();
            this.YearExt_cb = new System.Windows.Forms.ComboBox();
            this.YearExt_lbl = new System.Windows.Forms.Label();
            this.MonthExt_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardNumber_lbl
            // 
            this.CardNumber_lbl.AutoSize = true;
            this.CardNumber_lbl.Location = new System.Drawing.Point(712, 106);
            this.CardNumber_lbl.Name = "CardNumber_lbl";
            this.CardNumber_lbl.Size = new System.Drawing.Size(83, 20);
            this.CardNumber_lbl.TabIndex = 0;
            this.CardNumber_lbl.Text = "شماره کارت";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(737, 198);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(58, 20);
            this.Password_lbl.TabIndex = 1;
            this.Password_lbl.Text = "رمز دوم";
            // 
            // ExpDate_lbl
            // 
            this.ExpDate_lbl.AutoSize = true;
            this.ExpDate_lbl.Location = new System.Drawing.Point(716, 293);
            this.ExpDate_lbl.Name = "ExpDate_lbl";
            this.ExpDate_lbl.Size = new System.Drawing.Size(79, 20);
            this.ExpDate_lbl.TabIndex = 2;
            this.ExpDate_lbl.Text = "تاریخ انقضا";
            // 
            // Cvv2_lbl
            // 
            this.Cvv2_lbl.AutoSize = true;
            this.Cvv2_lbl.Location = new System.Drawing.Point(751, 384);
            this.Cvv2_lbl.Name = "Cvv2_lbl";
            this.Cvv2_lbl.Size = new System.Drawing.Size(44, 20);
            this.Cvv2_lbl.TabIndex = 3;
            this.Cvv2_lbl.Text = "CVV2";
            // 
            // PayingCost_txt
            // 
            this.PayingCost_txt.Location = new System.Drawing.Point(545, 23);
            this.PayingCost_txt.Name = "PayingCost_txt";
            this.PayingCost_txt.Size = new System.Drawing.Size(250, 27);
            this.PayingCost_txt.TabIndex = 4;
            // 
            // CardNumber_txt
            // 
            this.CardNumber_txt.Location = new System.Drawing.Point(328, 106);
            this.CardNumber_txt.Name = "CardNumber_txt";
            this.CardNumber_txt.Size = new System.Drawing.Size(323, 27);
            this.CardNumber_txt.TabIndex = 5;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(469, 198);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(182, 27);
            this.Password_txt.TabIndex = 6;
            // 
            // Cvv2_txt
            // 
            this.Cvv2_txt.Location = new System.Drawing.Point(570, 384);
            this.Cvv2_txt.Name = "Cvv2_txt";
            this.Cvv2_txt.Size = new System.Drawing.Size(81, 27);
            this.Cvv2_txt.TabIndex = 9;
            // 
            // Pay_btn
            // 
            this.Pay_btn.Location = new System.Drawing.Point(447, 454);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(204, 49);
            this.Pay_btn.TabIndex = 10;
            this.Pay_btn.Text = "پرداخت";
            this.Pay_btn.UseVisualStyleBackColor = true;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click_1);
            // 
            // PayingCost_lbl
            // 
            this.PayingCost_lbl.AutoSize = true;
            this.PayingCost_lbl.Location = new System.Drawing.Point(447, 23);
            this.PayingCost_lbl.Name = "PayingCost_lbl";
            this.PayingCost_lbl.Size = new System.Drawing.Size(81, 20);
            this.PayingCost_lbl.TabIndex = 11;
            this.PayingCost_lbl.Text = "مبلغ واریزی";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(147, 454);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(181, 49);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "لغو";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // MonthExt_cb
            // 
            this.MonthExt_cb.FormattingEnabled = true;
            this.MonthExt_cb.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthExt_cb.Location = new System.Drawing.Point(500, 293);
            this.MonthExt_cb.Name = "MonthExt_cb";
            this.MonthExt_cb.Size = new System.Drawing.Size(151, 28);
            this.MonthExt_cb.TabIndex = 13;
            // 
            // YearExt_cb
            // 
            this.YearExt_cb.FormattingEnabled = true;
            this.YearExt_cb.Items.AddRange(new object[] {
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405"});
            this.YearExt_cb.Location = new System.Drawing.Point(147, 293);
            this.YearExt_cb.Name = "YearExt_cb";
            this.YearExt_cb.Size = new System.Drawing.Size(151, 28);
            this.YearExt_cb.TabIndex = 14;
            // 
            // YearExt_lbl
            // 
            this.YearExt_lbl.AutoSize = true;
            this.YearExt_lbl.Location = new System.Drawing.Point(94, 296);
            this.YearExt_lbl.Name = "YearExt_lbl";
            this.YearExt_lbl.Size = new System.Drawing.Size(36, 20);
            this.YearExt_lbl.TabIndex = 15;
            this.YearExt_lbl.Text = "سال";
            // 
            // MonthExt_lbl
            // 
            this.MonthExt_lbl.AutoSize = true;
            this.MonthExt_lbl.Location = new System.Drawing.Point(447, 301);
            this.MonthExt_lbl.Name = "MonthExt_lbl";
            this.MonthExt_lbl.Size = new System.Drawing.Size(30, 20);
            this.MonthExt_lbl.TabIndex = 16;
            this.MonthExt_lbl.Text = "ماه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthExt_lbl);
            this.Controls.Add(this.YearExt_lbl);
            this.Controls.Add(this.YearExt_cb);
            this.Controls.Add(this.MonthExt_cb);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.PayingCost_lbl);
            this.Controls.Add(this.Pay_btn);
            this.Controls.Add(this.Cvv2_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.CardNumber_txt);
            this.Controls.Add(this.PayingCost_txt);
            this.Controls.Add(this.Cvv2_lbl);
            this.Controls.Add(this.ExpDate_lbl);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.CardNumber_lbl);
            this.Name = "NewPaymentForm";
            this.Text = "NewPaymentForm";
            this.Load += new System.EventHandler(this.NewPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardNumber_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label ExpDate_lbl;
        private System.Windows.Forms.Label Cvv2_lbl;
        private System.Windows.Forms.TextBox PayingCost_txt;
        private System.Windows.Forms.TextBox CardNumber_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox Cvv2_txt;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Label PayingCost_lbl;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.ComboBox MonthExt_cb;
        private System.Windows.Forms.ComboBox YearExt_cb;
        private System.Windows.Forms.Label YearExt_lbl;
        private System.Windows.Forms.Label MonthExt_lbl;
        private System.Windows.Forms.Label label1;
    }
}