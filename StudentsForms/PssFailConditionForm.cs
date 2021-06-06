using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class PassFailNextTermCondition : Form
    {
        public PassFailNextTermCondition()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string passfail = MyClass.PassFailForm.text1;
            txt2.Text = passfail;
            int level = Convert.ToInt16(txt1.Text);
            int newlevel = level + 1;

            if (passfail == " قبول")
            {
                if (newlevel <= 6)
                {
                    txt3.Text = Convert.ToString(newlevel);
                }
                else
                {
                    MessageBox.Show("شماره ترم جدید را درست وارد کنید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (newlevel <= 6)
                {
                    level = Convert.ToInt16(txt1.Text);
                    newlevel = level;
                    txt3.Text = Convert.ToString(newlevel);
                }
                else
                {
                    MessageBox.Show("شماره ترم جدید را درست وارد کنید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            int.TryParse(txt3.Text, out int x);
            if (x >= 1 && x <= 6)
            {
                txt4.Text = $"{1200000 + 50000 * (x - 1)}";
            }
            else
            {
                MessageBox.Show("شماره ترم جدید را درس وارد کنید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
