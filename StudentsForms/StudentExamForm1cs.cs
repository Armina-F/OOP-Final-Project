using OOP_Final_Project.TeachersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

            if (ExamNames_cb.SelectedIndex > -1)
            {
                //MessageBox.Show(ExamNames_cb.SelectedValue.ToString());
                var examQuestionsDT = MyClass.ExecQuerly("SELECT * FROM ExamQuestions WHERE ExamId = @param1 ", ExamNames_cb.SelectedValue.ToString());
                if (examQuestionsDT.Rows == null || examQuestionsDT.Rows.Count == 0)
                {
                    MessageBox.Show("  هیچ سوالی در این آزمون ثبت نشده است");
                    return;
                }

                List<ExamClass> examAnswers = new List<ExamClass>();
                foreach (DataRow row in examQuestionsDT.Rows)
                {
                    ExamClass examClass = new ExamClass();
                    examClass.ExamId = int.Parse(row["ExamId"].ToString());
                    examClass.QuestionId = int.Parse(row["QuestionId"].ToString());
                    examClass.QuestionText = row["QuestionText"].ToString();
                    examClass.AnswerA = row["AnswerA "].ToString();
                    examClass.AnswerB = row["AnswerB"].ToString();
                    examClass.AnswerC = row["AnswerC"].ToString();
                    examClass.AnswerD = row["AnswerD"].ToString();
                    examClass.CorrectAnswerId = int.Parse(row["CorrectAnswerId"].ToString());

                    NewExamQuestionForm questionForm = new NewExamQuestionForm(examClass);
                    questionForm.ShowDialog();
                    examAnswers.Add(examClass);
                }
                if (examAnswers.Count != 0)
                {
                    int correctAnswers = examAnswers.Where(x => x.CorrectAnswerId == x.StudentAnswerId).Count();
                    var result = Math.Round(100.0 * correctAnswers / examAnswers.Count, 2);
                    MessageBox.Show("Your rezult: " + result);

                    var tb1 = MyClass.ExecQuerly("SELECT * FROM LevelMarks WHERE StudentId = @param1   " , MyClass.UserId.ToString());
                    if (tb1.Rows.Count == 0)
                    {
                        MyClass.ExecQuerly(@" INSERT INTO LevelMarks VALUES (@param1, 1, 0, 0, @param2 ); SELECT 0"
                                            , MyClass.UserId.ToString(), result.ToString());
                    }

                    else
                    {
                        MyClass.ExecQuerly(" UPDATE LevelMarks SET ExamMark = @param1 WHERE StudentId = @param2; SELECT 0"
                            , result.ToString(), MyClass.UserId.ToString());
                    }

                }
            }

            else
            {
                MessageBox.Show("شماره آزمون صحیح نیست");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            MyClass.studentForm.Show();
            this.Close();
        }
    }
}
