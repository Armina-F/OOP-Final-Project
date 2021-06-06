using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public partial class AddMarkForm :Form
    {
        public AddMarkForm()
        {
            InitializeComponent();
            SeeAllStudents();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if( int.TryParse( StudentId_txt.Text , out int Id ) && Id >0)
            {
                if( double.TryParse(ClassMark_txt.Text , out double mark)&& mark > 0 && mark <=100)
                {
                    MyClass.ExecQuerly(" UPDATE LevelMarks SET ClassMark = @param1 WHERE StudentId = @param2; SELECT 0"
                            , mark.ToString(), Id.ToString());
                    MessageBox.Show("  نمره ثبت شد");

                    SeeAllStudents();
                }

                else
                {
                    MessageBox.Show("  لطفا نمره را انتخاب کنید ");
                }
            }

            else
            {
                MessageBox.Show("  لطفا یک زبان آموز را انتخاب کنید ");
            }



        }

        void SeeAllStudents()
        {
            DataTable dbtl = MyClass.ExecQuerly(@" SELECT Students.Id, FirstName, LastName , GroupName, ClassMark, ExamMark, 
                                                          (0.6 * ClassMark + 0.4 * ExamMark ) AS 'AvergeMark'
                                                   FROM Students
                                                   LEFT JOIN StudentsGroups
                                                   ON Students.GroupId = StudentsGroups.GroupId
                                                   LEFT JOIN LevelMarks
                                                   ON Students.Id = LevelMarks.StudentId");
            students_dgv.DataSource = dbtl;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

            MyClass.teacherShowForm.Show();
            this.Close();
        }

        private void students_dgv_SelectionChanged(object sender, EventArgs e)
        {
            ClassMark_txt.Text = "";
            if (students_dgv.SelectedRows != null && students_dgv.SelectedRows.Count> 0)
            {
                DataGridViewRow row = students_dgv.SelectedRows[0];
                StudentId_txt.Text = row.Cells[0].Value.ToString();
                FirstName_txt.Text = row.Cells[1].Value.ToString();
                LastName_txt.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
