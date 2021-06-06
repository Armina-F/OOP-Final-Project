using OOP_Final_Project.TeachersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class ExamForm : Form
    {
        public ExamForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(NumberOFQuestions_txt.Text, out int countQuestions) && countQuestions > 0 && ExamName_txt.Text.Trim().Length > 0)
            {
                DataTable dt = MyClass.ExecQuerly(@"INSERT INTO Exams(ExamName) Values (@param1)
                                                    SELECT Id FROM Exams WHERE ExamName = @param1 ORDER BY Id DESC", ExamName_txt.Text.Trim());
                int examId = int.Parse(dt.Rows[0][0].ToString());
                for (int i = 1; i <= countQuestions; i++)
                {
                    new NewExamQuestionForm(examId, i).ShowDialog();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyClass.TeacherHome.Show();
            this.Close();
        }
    }
}
