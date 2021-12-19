using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ReCITE.Database
{
    /*
        =========================================================================================
        "WILL HOLD RETURNED DATA FROM DATABASE"
        List<List<string>> StudentRecords = new List<List<string>>();
       
        "INITIALIZE DATABASE"
        Database.Database databaseConnection = new Database.Database();

        "GET STUDENTS FUNCTION WITH CLASS PARAMETER"
        StudentRecords = databaseConnection.getStudents("BTVTED-CP"); // STUDENT LIST AND SCORE

        MessageBox.Show(StudentRecords[0][1].ToString()); 
    */

    class Database
    {
        private string ConnectionString = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=StudentData;Trusted_Connection=True;";
        private SqlConnection sqlConnection;
        private SqlDataReader dataReader;
        private SqlCommand sqlCommand;

        private void ConnectToDatabase()
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        }
        
        public List<List<string>> getStudents(string ClassList) {
            List<List<string>> StudentList = new List<List<string>>();
            ConnectToDatabase();
            string query = "SELECT * FROM Students WHERE Class='" + ClassList +"'";
            try
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    List<string> StudentRecord = new List<string>();
                    StudentRecord.Add(dataReader["StudentName"].ToString());
                    StudentRecord.Add(dataReader["Score"].ToString());
                    StudentList.Add(StudentRecord);
                }
            }
            catch
            {
                CreateTable();
            }

            sqlConnection.Close();
            return StudentList;
        }

        public void CreateTable()
        {
            string createTable = "CREATE TABLE Students (StudentId varchar(255), StudentName varchar(255), Class varchar(255), Score int);";
            sqlCommand = new SqlCommand(createTable, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

    }
}
