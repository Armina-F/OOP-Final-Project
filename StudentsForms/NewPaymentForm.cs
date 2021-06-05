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
                //Message
                return;
            }

            if (int.TryParse(PayingCost_txt.Text, out int cost))
            {
                //Add command
                MyClass.ExecQuerly($"INSERT INTO PaymentHistory (studentId, PaiedCost) VALUES ({MyClass.UserId},{cost}) SELECT 0");
                MessageBox.Show("مبلغ وارده صحیح یست");
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
            if(CardNumber_txt .Text.Trim().Length != 16 || !int.TryParse(CardNumber_txt.Text, out _))
            {
                return false;
            }

            return true;
        }
    }
}
