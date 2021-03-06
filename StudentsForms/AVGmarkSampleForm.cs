using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class AVGmarkSample : Form
    {
        public AVGmarkSample()
        {
            InitializeComponent();
        }
        public string text1;
        public string text2;

        private void SetText()
        {
            txt4.Text = text1;
            txt5.Text = text2;
            MessageBox.Show("ok", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double ClassMark = Convert.ToDouble(txt1.Text);
            double ExamMark = Convert.ToDouble(txt2.Text);
            double AveMark = Convert.ToDouble(0.6 * ClassMark + 0.4 * ExamMark);
            string numberstring = Convert.ToString(AveMark);
            txt3.Text = numberstring;

            if (AveMark >= 60 && AveMark <= 65)
            {
                text1 = " قبول";
                text2 = " مشروط";
                MessageBox.Show("شما مجاز به ادامه تحصیل در ترم بعدی هستید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AveMark < 60)
            {
                text1 = " مردود";
                text2 = "  عدم مشروط";
                MessageBox.Show("شما مجاز به ادامه تحصیل در ترم بعد نیستید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AveMark > 65 && AveMark < 90)
            {
                text1 = " قبول";
                text2 = " عدم مشروط وعدم معدل الف ";
                MessageBox.Show("شما مجاز به ادامه تحصیل در ترم بعدی هستید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                text1 = " قبول";
                text2 = " معدل الف ";
                MessageBox.Show("شما مجاز به ادامه تحصیل در ترم بعدی هستید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SetText();
            new PassFailNextTermCondition().Show();
            MyClass.PassFailForm = this;
            this.Hide();
        }
    }
}
