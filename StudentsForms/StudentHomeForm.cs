using OOP_Final_Project.StudentsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class StudentHomeForm : Form
    {
        public StudentHomeForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void EducationRecord_btn_Click(object sender, EventArgs e)
        {

        }

        private void MarkCaculator_btn_Click(object sender, EventArgs e)
        {
            new AVGmarkSample().Show();
            MyClass.StudentHome = this;
            this.Hide();
          
        }

        private void Finacial_btn_Click(object sender, EventArgs e)
        {
            new FinacialStudentForm().Show();
            MyClass.StudentHome = this;
            this.Hide();
        }

        private void Exam_btn_Click(object sender, EventArgs e)
        {
            new StudentExamForm1cs().Show();
            MyClass.StudentHome = this;
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            MyClass.StudentForm.Show();
            this.Close();
        }
    }
}
