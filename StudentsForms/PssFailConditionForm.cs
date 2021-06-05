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

        private void btn_Click(object sender, EventArgs e)
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


            
            int.TryParse(txt3.Text , out int x);
            if (x >= 1 && x <= 6)
            {
                txt4.Text = $"{1200000 + 50000 * (x - 1)}";

            }
            else
            {
                MessageBox.Show("شماره ترم جدید را درس وارد کنید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //int x = Convert.ToInt16(txt3.Text);
            //for (int y = 1; y <= 6; y++)
            //{
            //    if (y == x )
            //    {
            //        txt4.Text = $"{1200000 + 50000 * (y - 1)}";
            //    }
            //    break;
            //}



            //switch (x)
            //{

            //    case 1:
            //        txt4.Text = "1.200.000 T";
            //        break;

            //    case 2:
            //        txt4.Text = "1.250.000 T";
            //        break;

            //    case 3:
            //        txt4.Text = "1.300.000 T";
            //        break;

            //    case 4:
            //        txt4.Text = "1.350.000 T";
            //        break;

            //    case 5:
            //        txt4.Text = "1.400.000 T";
            //        break;

            //    case 6:
            //        txt4.Text = "1.450.000 T";
            //        break;

            //    default:
            //        MessageBox.Show("شماره ترم جدید را درس وارد کنید.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;

            //}


        }
    }
}
