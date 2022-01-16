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
        private readonly string ConnectionString = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=StudentData;Trusted_Connection=True;";
        private SqlConnection sqlConnection;
        private SqlDataReader dataReader;
        private SqlCommand sqlCommand;

        private void ConnectToDatabase()
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        }
        
        //  GET STUDENT LIST
        public List<List<string>> GetStudents(string ClassList) {
            List<List<string>> StudentList = new List<List<string>>();
            ConnectToDatabase();
            string query = "SELECT * FROM " + ClassList;
            try
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    List<string> StudentRecord = new List<string>
                    {
                        dataReader["StudentName"].ToString(),
                        dataReader["Score"].ToString()
                    };
                    StudentList.Add(StudentRecord);
                }
            }
            catch
            {
                CreateTables();
            }

            sqlConnection.Close();
            return StudentList;
        }

        //  DELETE STUDENT DATA
        public void DeleteStudent(string StudentId)
        {
            string query = "DELETE FROM Class1 WHERE StudentId = '"+ StudentId +"'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        //  UPDATE STUDENT DATA
        public void UpdateName(string StudentID, string NameChanges)
        {
            string query = "UPDATE Class1 SET StudentName='"+ NameChanges +"' WHERE StudentId = '"+ StudentID +"'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        //  ADD STUDENT DATA
        public void AddStudent(string Name, string Section)
        {
            ConnectToDatabase();
            string InsertQuery = @"INSERT INTO "+ Section + @"  (StudentName, Score, CAFL, SL, HUL) VALUES ('" + Name + "', 0, 1, 1, 1)";
            sqlCommand = new SqlCommand(InsertQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        //  CREATE TABLES
        public void CreateTables()
        {
            ConnectToDatabase();
            for (var index = 1; index <= 5; index++)
            {
                string createTable = @"CREATE TABLE Class" + index + " (StudentId int IDENTITY(1,1) PRIMARY KEY, StudentName varchar(255), Score int, CAFL bit, SL bit, HUL bit);";
                sqlCommand = new SqlCommand(createTable, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        // Update Tables
        public void UpdateTables(string Oldname, string Newname)
        {
            ConnectToDatabase();
            string createTable = @"EXEC sp_rename '" + Oldname + "','" + Newname + "'";
            sqlCommand = new SqlCommand(createTable, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        //Load ClassName
        public List<string> LoadTableName()
        {
            List<string> ClassName = new List<string>();
            ConnectToDatabase();
            string query = "USE StudentData SELECT * FROM sys.Tables";

            sqlCommand = new SqlCommand(query, sqlConnection);
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                ClassName.Add(dataReader["Name"].ToString());
            }

            sqlConnection.Close();
            return ClassName;
        }

    }
}
