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
            MessageBox.Show(questionNum.ToString()); 
        }
    }
}
