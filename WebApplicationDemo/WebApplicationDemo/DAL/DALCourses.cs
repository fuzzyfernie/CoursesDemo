using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.DAL
{
    public class DALCourses
    {
        private IConfiguration configuration;

        public DALCourses(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public int addCourses(Courses courses)
        {
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "INSERT INTO [dbo].[Student_Schedule],[dbo].[Student]([ClassID])VALUES(@pClassID,@pClassName,@pClassTime) select SCOPE_IDENTITY() as StudentID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pClassID", courses.ClassID);
            cmd.Parameters.AddWithValue("@pClassName", courses.ClassName);
            cmd.Parameters.AddWithValue("@pClassTime", courses.ClassTime);
            


            //Step 3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int uID = Convert.ToInt32(reader[0].ToString());

            //Step 4 - close the connection
            conn.Close();

            return uID;
        }



        // public Courses getCourses(string CourseID)
        public List<Courses> getCourses(string CourseID)
        {
            List<Courses> coursesList = new List<Courses>();
            Courses courses = new Courses();
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "SELECT [ClassID],[ClassName],[ClassTime]FROM [dbo].[Classes_Available], [dbo].[Student] where ClassID = @ClassID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ClassID", CourseID);


            //Step 3 - query the DB
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Courses newCourse = new Courses()
                {
                    ClassName = reader["ClassName"].ToString(),
                    ClassTime = Convert.ToDateTime(reader["ClassTime"]),
                    //courses.UID = uID;
                    ClassID = Convert.ToInt32(CourseID)

                };
                coursesList.Add(newCourse);
        }
        
            //Step 4 - close the connection
            conn.Close();

            return coursesList;
        }

       

        public List<Courses> GetCourseAvailableForStudent(int studentID)
        {
            List<Courses> courses = new List<Courses>();
            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
           
            string query = "select c.[ClassID], c.[ClassName], c.[ClassTime] from Classes_Available c " +
            "where c.ClassTime not in (" +
                "SELECT a.[ClassTime] FROM[dbo].[Classes_Available] a join[dbo].[Student_Schedule] b on a.[ClassID] = b.[ClassID] where b.StudentID = @studentID)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentID", studentID);


            //Step 3 - query the DB
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Courses newCourse = new Courses()
                    {
                        ClassID = Convert.ToInt32(reader["ClassID"]),
                        ClassName = reader["ClassName"].ToString(),
                        ClassTime = Convert.ToDateTime(reader["ClassTime"])
                    };

                    courses.Add(newCourse);
                }
            }
               
            //Step 4 - close the connection
            conn.Close();

            return courses;
        }


        internal void UpdateCourses(string ClassID, int uID)
        {

            //Step 1 - Connecto to the DB
            string connStr = configuration.GetConnectionString("DefaultConnection");
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Step 2 - create a command
            string query = "INSERT INTO [dbo].[Student_Schedule]([ClassID],[StudentID])VALUES(@pClassID,@pStudentID) select SCOPE_IDENTITY() as StudentID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pStudentID", uID);
            cmd.Parameters.AddWithValue("@pClassID", ClassID);
            
            

            //Step 3 - query the DB
            cmd.ExecuteNonQuery();

            //Step 4 - close the connection
            conn.Close();
        }

       

    }
}
