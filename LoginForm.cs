using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Final_Project
{
    public partial class LoginForm : Form
    {

       

        public LoginForm()
        {
            InitializeComponent();

        }

        private void StudentLogin_btn_Click(object sender, EventArgs e)
        {
            string userRole = "";
            using (SqlConnection connection = new SqlConnection(MyClass.connectionString))

            {
                connection.Open();
                SqlCommand com = new SqlCommand("select * from AUTH", connection);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if (username_txt.Text == (dr["username"].ToString()) && password_txt.Text == dr["password"].ToString())
                    {
                        MessageBox.Show("ورود با  موفقیت ", "تبریک ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userRole = dr["userRole"].ToString().Trim();
                        MyClass.UserId = int.Parse(dr["Id"].ToString());
                        break;
                    }
                }
            }
            if (userRole == "student")
            {
                new StudentHomeForm().Show();
                MyClass.StudentForm = this;
                this.Hide();
            }
            else if (userRole == "teacher")
            {
                new TeacherHomeForm().Show();
                MyClass.TeacherForm = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز اشتباه است ", " خطا ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                username_txt.Text = "";
                password_txt.Text = "";
            }



        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
