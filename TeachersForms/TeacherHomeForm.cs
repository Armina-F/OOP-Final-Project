using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class TeacherHomeForm : Form
    {
        public TeacherHomeForm()
        {
            InitializeComponent();
        }

        private void StudentsClassesName_btn_Click(object sender, EventArgs e)
        {
            new SeeStudentInfoForm().Show();
            MyClass.teacherShowForm= this ;
            this.Hide();
        }

        private void MarkStudents_btn_Click(object sender, EventArgs e)
        {
            new AddMarkForm().Show();
            MyClass.TeacherMarkForm = this;
            this.Hide();
        }

        private void ExamMake_btn_Click(object sender, EventArgs e)
        {
            new ExamForm().Show();
            MyClass.ExamForm = this;
            this.Hide();
        }
    }
}
