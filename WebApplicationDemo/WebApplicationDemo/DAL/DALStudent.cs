using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.DAL
{
    public class DALStudent
    {
        private IConfiguration configuration;

        public DALStudent(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int addStudent(Student student)
        {
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "INSERT INTO [dbo].[Student]([StudentFName],[StudentLName],[StudentEmail])VALUES(@pFName,@pLName,@pEmail) select SCOPE_IDENTITY() as StudentID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pFName",student.FirstName);
            cmd.Parameters.AddWithValue("@pLName", student.LastName);
            cmd.Parameters.AddWithValue("@pEmail", student.StudentEmail);


            //Step 3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int uID = Convert.ToInt32(reader[0].ToString());

            //Step 4 - close the connection
            conn.Close();

            return uID;
        }

        internal Student getStudent(int uID)
        {
            Student student = new Student();
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "SELECT [StudentID],[StudentFName],[StudentLName],[StudentEmail]FROM [dbo].[Student] where StudentID = @uID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uID", uID);
            
            
            //Step 3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            student.FirstName = reader["StudentFName"].ToString();
            student.LastName = reader["StudentLName"].ToString();
            student.UID = uID;

            //Step 4 - close the connection
            conn.Close();

            return student;
        }

        internal void DeleteStudent(int uID)
        {

            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "DELETE FROM [dbo].[Student] WHERE StudentID = @pStudentID";
            SqlCommand cmd = new SqlCommand(query, conn);          
            cmd.Parameters.AddWithValue("@pStudentID", uID);


            //Step 3 - query the DB
            cmd.ExecuteNonQuery();

            //Step 4 - close the connection
            conn.Close();


        }

        internal void UpdateUser(Student student)
        {
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "UPDATE [dbo].[Student] SET [StudentFName] =pFName,[StudentLName] = @pLName,[StudentEmail] = @pEmail WHERE StudentID = @pStudentID";
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@pStudentID", student.StudentID);
            cmd.Parameters.AddWithValue("@pFName", student.FirstName);
            cmd.Parameters.AddWithValue("@pLName", student.LastName);
            cmd.Parameters.AddWithValue("@pEmail", student.StudentEmail);


            //Step 3 - query the DB
            cmd.ExecuteNonQuery();

            //Step 4 - close the connection
            conn.Close();
        }
    }
}
