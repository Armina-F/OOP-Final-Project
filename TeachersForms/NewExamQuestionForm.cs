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
        public NewExamQuestionForm(int examId, int questionNum)
        { 
            InitializeComponent();
            this.examId = examId;
            this.questionNum = questionNum;
            CurrentQuestionNumber_txt.Text = questionNum.ToString();
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

            int AnswerId = 0;
            if (A_rb.Checked)
                AnswerId = 1;

           else if (B_rb.Checked)
                AnswerId = 2;

            else if (C_rb.Checked)
                AnswerId = 3;

            else if (D_rb.Checked)
                AnswerId = 4;

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
    }
}
