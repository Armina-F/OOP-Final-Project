using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace OOP_Final_Project.StudentsForms
{
    public partial class StudentExamForm1cs : Form
    {
        public StudentExamForm1cs()
        {
            InitializeComponent();
            StudentId_txt.Text = MyClass.UserId.ToString();
            ExamNames_cb.DataSource = MyClass.ExecQuerly("SELECT * FROM Exams ");
            ExamNames_cb.DisplayMember = "ExamName";
            ExamNames_cb.ValueMember = "Id";
        }

        private void ExamSart_btn_Click(object sender, EventArgs e)
        {
           
            if (ExamNames_cb.SelectedIndex >-1)
            {
                //MessageBox.Show(ExamNames_cb.SelectedValue.ToString());
                var examQuestionsDT = MyClass.ExecQuerly("SELECT * FROM ExamQuestions WHERE ExamId = @param1 " , ExamNames_cb.SelectedValue.ToString());
                foreach (var row in examQuestionsDT.Rows)
                {


                }
            }

            else
            {
                MessageBox.Show("شماره آزمون صحیح نیست");
            }
        }
    }
}
