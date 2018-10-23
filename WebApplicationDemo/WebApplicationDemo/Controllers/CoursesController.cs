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
    public class CoursesController : Controller
    {
        private readonly IConfiguration configuration;

        public CoursesController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration(Courses courses)
        {
            //send it to the DB
            //validate the info

            //string connStr = configuration.GetConnectionString("DefaultConnection");
            DALCourses dp = new DALCourses(configuration);
            int uID = dp.addCourses(courses);

            courses.UID = uID;

            //save the User ID to the session
            HttpContext.Session.SetString("uID", uID.ToString()); //write to the session
            string strUID = HttpContext.Session.GetString("uID"); //reads from the session


            return View(courses);
        }

        public IActionResult EditCourse()
        {
            //get the UID from the Session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session

            //get the Course object from the DB using the DALCourse class
            DALCourses dp = new DALCourses(configuration);
            Courselist courseList = new Courselist
            {
                Courses = dp.GetCourseAvailableForStudent(uID)
            };

            //send the view 
            return View(courseList);
        }


        public IActionResult UpdateCourse(Courses courses)
        {
            //get the uid from the session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session
            courses.UID = uID;

            DALCourses dp = new DALCourses(configuration);
            dp.UpdateCourses(courses);
            return View("Registration", courses);
        }

        public IActionResult DeleteStudent()
        {
            //get the uid from the session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session
            DALCourses dp = new DALCourses(configuration);
            Courses courses= dp.getCourses(uID);

            dp.DeleteCourses(uID);

                       
            return View(courses);


        }
    }
}