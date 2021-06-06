using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project.TeachersForms
{
    public partial class NewExamQuestionForm : Form
    {
        private int examId;
        private int questionNum;
        private ExamClass exam;

        public NewExamQuestionForm(int examId, int questionNum)
        {
            InitializeComponent();
            this.examId = examId;
            this.questionNum = questionNum;
            CurrentQuestionNumber_txt.Text = questionNum.ToString();
        }

        public NewExamQuestionForm(ExamClass exam)
        {
            InitializeComponent();
            this.exam = exam;
            this.examId = exam.ExamId;
            this.questionNum = exam.QuestionId;
            this.Text = "Student Exam";
            CurrentQuestionNumber_txt.Text = questionNum.ToString();
            Submit_btn.Visible = false;
            NextQuestion_btn.Visible = true;
            Question_RTXT.Text = exam.QuestionText;
            A_rtxt.Text = exam.AnswerA;
            B_rtxt.Text = exam.AnswerB;
            C_rtxt.Text = exam.AnswerC;
            D_rtxt.Text = exam.AnswerD;

            Question_RTXT.ReadOnly = false;
            A_rtxt.ReadOnly = false;
            B_rtxt.ReadOnly = false;
            C_rtxt.ReadOnly = false;
            D_rtxt.ReadOnly = false;
        }
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (Question_RTXT.Text.Trim().Length == 0)
            {
                MessageBox.Show("سوال نباید خالی باشد");
                return;
            }

            if (A_rtxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("جواب  اول  نباید خالی باشد");
                return;
            }

            if (B_rtxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("جواب دوم نباید خالی باشد");
                return;
            }

            if (C_rtxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("جواب سوم نباید خالی باشد");
                return;
            }

            if (D_rtxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("جواب چهارم  نباید خالی باشد");
                return;
            }

            int AnswerId = GetAnsweId();

            if (AnswerId == 0)
            {
                MessageBox.Show("گزینه درست را انتخاب کنید");
                return;
            }

            MyClass.ExecQuerly(@"INSERT INTO ExamQuestions 
                                (ExamId, QuestionId, QuestionText, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswerId) 
                                VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8)
                                SELECT 0", examId.ToString(), questionNum.ToString(), Question_RTXT.Text,
                                A_rtxt.Text, B_rtxt.Text, C_rtxt.Text, D_rtxt.Text, AnswerId.ToString());
            MessageBox.Show(" سوال با موفقیت ثبت شد");

            this.Close();






        }

        private int GetAnsweId()
        {
            if (A_rb.Checked)
                return 1;

            else if (B_rb.Checked)
                return 2;

            else if (C_rb.Checked)
                return 3;

            else if (D_rb.Checked)
                return 4;
            return 0;
        }

        private void NextQuestion_btn_Click(object sender, EventArgs e)
        {
            int answerId = GetAnsweId();
            if(answerId == 0)
            {
                MessageBox.Show(" یک گزینه را انتخاب کنید");
            }
            else
            {
                exam.StudentAnswerId = answerId;
                this.Close();
            }
        }
    }
}
