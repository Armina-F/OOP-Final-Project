using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class FinacialStudentForm : Form
    {
        public FinacialStudentForm()
        {
            InitializeComponent();
        }

        private void HistoryPayments_btn_Click(object sender, EventArgs e)
        {
            new HistoryPaymentsForm().Show();
            MyClass.HistoryPayments = this;
            this.Hide();
        }

        private void NewPayment_btn_Click(object sender, EventArgs e)
        {
            new NewPaymentForm().Show();
            MyClass.AddNewPayment = this;
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            MyClass.StudentForm.Show();
            this.Close();
        }
    }
}
