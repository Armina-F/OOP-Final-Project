using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class NewPaymentForm : Form
    {
        public NewPaymentForm()
        {
            InitializeComponent();
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {

        }

        private void Pay_btn_Click_1(object sender, EventArgs e)
        {
            if(!CheckRows())
            {
                MessageBox.Show("مقداری ورودی صحیح نمی باشند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(PayingCost_txt.Text, out int cost))
            {
                //Add command  ADO.NET  ---  EntityFramework 6.0
                string text_of_SQL_command = $"INSERT INTO PaymentHistory (studentId, PaiedCost) VALUES ({MyClass.UserId},{cost}) SELECT 0";
                MyClass.ExecQuerly(text_of_SQL_command);
                MessageBox.Show("مبلغ وارده صحیح می باشد");
            }
            else
            {
                MessageBox.Show("مبلغ وارده صحیح نیست");
            }
            PayingCost_txt.Text = "";
        }

        private void NewPaymentForm_Load(object sender, EventArgs e)
        {

        }

        private bool CheckRows()
        {
            if(CardNumber_txt .Text.Trim().Length != 16 || !Int64.TryParse(CardNumber_txt.Text, out _))
            {
                MessageBox.Show("شماره کارت اشتباه هست ");
                return false;
            }




            if (Password_txt.Text.Trim().Length != 6 || !int.TryParse(Password_txt.Text, out _))
            {
                MessageBox.Show("رمز اشتباه هست ");
                return false;
            }



            if (Cvv2_txt.Text.Trim().Length != 4 || !int.TryParse(Cvv2_txt.Text, out _))
            {
                MessageBox.Show(" اشتباه هست cvv2 ");
                return false;
            }


            if ((int.Parse(MonthExt_cb.Text) <= 4) && (int.Parse(YearExt_cb.Text) == 1400))
            {
                MessageBox.Show(" تاریخ انقضا اشتباه هست ");
                return false;
            }

            return true;


        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new FinacialStudentForm().Show();

        }
    }
}
