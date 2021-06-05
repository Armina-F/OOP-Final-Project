using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OOP_Final_Project
{
    public static class MyClass
    {
        readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OneDrive\Documents\MyNewDB.mdf;Integrated Security=True;Connect Timeout=30 ";

        public static int UserId { get; set; }
        public static AVGmarkSample myForm { get; set; }
        public static StudentHomeForm markcacForm { get; set; }
        public static LoginForm studentForm { get; set; }
        public static LoginForm teacherForm { get; set; }
        public static StudentHomeForm finacialForm { get; set; }
        public static TeacherHomeForm teacherShowForm { get; set; }
        public static TeacherHomeForm TeacherMarkForm { get; set; }
        public static FinacialStudentForm AddNewPayment { get; set; }
        public static FinacialStudentForm HistoryPayments { get; set; }

        public static DataTable ExecQuerly(string commandText)
        {
            DataTable dbtl = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(commandText, connection);
                sqlDa.Fill(dbtl);
            }
            return dbtl;
        }
    }


}
