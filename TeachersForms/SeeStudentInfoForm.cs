using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Final_Project
{
    public partial class SeeStudentInfoForm : Form
    {
       
        //public List<Student> Students { get; set; }

        public SeeStudentInfoForm()
        {

            // Students = GetStudents();


            InitializeComponent();
        }

        //private List<Student> GetStudents()
        //{
        // var list = new List<Student>();
        //  list.Add(new Student ())

        //  }



        private void SeeStudentInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            DataTable dbtl = MyClass.ExecQuerly(@" SELECT Students.Id, FirstName, LastName , GroupName, LastestMark
                                                   FROM Students
                                                   LEFT JOIN StudentsGroups
                                                   ON Students.GroupId = StudentsGroups.GroupId");
            StudentInfo_dgv.DataSource = dbtl;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            MyClass.teacherShowForm.Show();
            this.Close();
        }
    }
}
