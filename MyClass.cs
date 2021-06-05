using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OOP_Final_Project
{
    public static class MyClass
    {
        public readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OneDrive\Documents\MyNewDB.mdf;Integrated Security=True;Connect Timeout=30 ";


        public static int UserId { get; set; }
        public static StudentHomeForm studentHomeForm { get; set; }
        public static LoginForm studentForm { get; set; }
        public static LoginForm teacherForm { get; set; }
        public static TeacherHomeForm teacherShowForm { get; set; }
        public static FinacialStudentForm AddNewPayment { get; set; }
        public static FinacialStudentForm HistoryPayments { get; set; }
        public static ExamForm NewExamQuestionForm { get; internal set; }
        public static AVGmarkSample PassFailForm { get;  set; }

        public static DataTable ExecQuerly(string commandText, params string[] listParams)
        {
            DataTable dbtl = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand(commandText, connection);
                int i = 1;
                foreach (var item in listParams)
                {
                    comm.Parameters.Add(new SqlParameter("@param" + i, item));
                    i++;
                }

                SqlDataAdapter sqlDa = new SqlDataAdapter(comm);

                sqlDa.Fill(dbtl);
            }
            return dbtl;
        }
    }


}
