
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
            this.Level_lbl = new System.Windows.Forms.Label();
            this.level_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Level_lbl
            // 
            this.Level_lbl.AutoSize = true;
            this.Level_lbl.Location = new System.Drawing.Point(128, 41);
            this.Level_lbl.Name = "Level_lbl";
            this.Level_lbl.Size = new System.Drawing.Size(73, 20);
            this.Level_lbl.TabIndex = 2;
            this.Level_lbl.Text = "سطح زبان";
            // 
            // level_txt
            // 
            this.level_txt.Location = new System.Drawing.Point(241, 41);
            this.level_txt.Name = "level_txt";
            this.level_txt.Size = new System.Drawing.Size(125, 27);
            this.level_txt.TabIndex = 3;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(433, 549);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(141, 54);
            this.Submit_btn.TabIndex = 5;
            this.Submit_btn.Text = "ثبت";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // AddMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 940);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.level_txt);
            this.Controls.Add(this.Level_lbl);
            this.Name = "AddMarkForm";
            this.Text = "AddMarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Level_lbl;
        private System.Windows.Forms.TextBox level_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}