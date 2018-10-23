using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;
using Microsoft.Extensions.Configuration;
using WebApplicationDemo.DAL;
using Microsoft.AspNetCore.Http;


namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController (IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration(viewModelStudentCourse student)
        {
            //send it to the DB
            //validate the info

            //student = new viewModelStudentCourse();
            DALStudent dp = new DALStudent(configuration);
            int uID = dp.addStudent(student);
            student.UID = uID;
            student.Courses = new Courselist();
            student.Courses.Courses = dp.getCourses(student.UID);

            //string connStr = configuration.GetConnectionString("DefaultConnection");

            //save the User ID to the session
            HttpContext.Session.SetString("uID",uID.ToString()); //write to the session
            string strUID = HttpContext.Session.GetString("uID"); //reads from the session


            return View(student);
        }

        public IActionResult EditStudent()
        {
            //get the UID from the Session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session

            //get the Student object from the DB using the DALStudent class
            DALStudent dp = new DALStudent(configuration);
            Student student = dp.getStudent(uID);
            
            //send the view 
            return View(student);
        }

        
        public IActionResult UpdateStudent(Student student)
        {
            //get the uid from the session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session
            student.UID = uID;

            DALStudent dp = new DALStudent(configuration);
            dp.UpdateUser(student);
            return View("Registration",student);
        }

        public IActionResult DeleteStudent()
        {
            //get the uid from the session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session
            DALStudent dp = new DALStudent(configuration);
            Student student = dp.getStudent(uID);

            dp.DeleteStudent(uID);
           

           
           
            return View(student);
        }
    }
}