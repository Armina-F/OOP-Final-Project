using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OOP_Final_Project
{
    public static class MyClass
    {
        public readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\OOP Final Project\DataBaseFiles\MyNewDB.mdf;Integrated Security=True;Connect Timeout=30 ";


        public static int UserId { get; set; }
        public static StudentHomeForm StudentHome { get; set; }
        public static LoginForm StudentForm { get; set; }
        public static LoginForm TeacherForm { get; set; }
        public static TeacherHomeForm TeacherHome { get; set; }
        public static FinacialStudentForm AddNewPayment { get; set; }
        public static FinacialStudentForm HistoryPayments { get; set; }
        public static ExamForm NewExamQuestionForm { get; internal set; }
        public static AVGmarkSample PassFailForm { get; set; }

        public static DataTable ExecQuerly(string commandText, params string[] listParams)
        {
            DataTable dbtl = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
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
            connection.Close();
            return dbtl;
        }
    }


}
