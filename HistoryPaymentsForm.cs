using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class HistoryPaymentsForm : Form
    {
        public HistoryPaymentsForm()
        {
            InitializeComponent();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            PaymentsHistory_dgv.DataSource = MyClass
                .ExecQuerly($"SELECT id, PaiedCost FROM PaymentHistory WHERE studentId = {MyClass.UserId} ORDER BY id");
            StudentId_txt.Text = MyClass.UserId.ToString();
        }
    }
}
