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

           
            DALCourses dp = new DALCourses(configuration);
            int uID = dp.addCourses(courses);

            courses.UID = uID;

            //save the User ID to the session
            HttpContext.Session.SetString("uID", uID.ToString()); //write to the session
            string strUID = HttpContext.Session.GetString("uID"); //reads from the session


            return View(courses);
        }

        [HttpGet]
        public IActionResult EditCourse(int? id)
        {
            //get the UID from the Session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session

            //get the Course object from the DB using the DALCourse class
            DALCourses dp = new DALCourses(configuration);
            DALStudent ds = new DALStudent(configuration);
            Student stu = ds.getStudent(uID);
            viewModelStudentCourse courseList = new viewModelStudentCourse();
            courseList.UID = stu.UID;
            courseList.AddedCourse = new Courses();
            courseList.AddedCourse.UID = stu.UID;  /// This is new

            courseList.SelectedCourses = new Courselist();
            courseList.SelectedCourses.Courses = dp.getCourses(stu.UID.ToString());

            courseList.FirstName = stu.FirstName;
            courseList.LastName = stu.LastName;
            courseList.StudentEmail = stu.StudentEmail;
            courseList.Courses = new Courselist();
            courseList.Courses.Courses = dp.GetCourseAvailableForStudent(uID);

           

            //send the view 
            return View(courseList);
        }

        [HttpPost]
        public IActionResult EditCourse(viewModelStudentCourse viewModel)
        {
            //get the UID from the Session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session

            //get the Course object from the DB using the DALCourse class
            DALCourses dp = new DALCourses(configuration);
            DALStudent ds = new DALStudent(configuration);

            Student stu = ds.getStudent(uID);
            dp.UpdateCourses(viewModel.AddedCourse.ClassID.ToString(), viewModel.AddedCourse.UID);
            viewModelStudentCourse courseList = new viewModelStudentCourse();
            courseList.UID = stu.UID;

            courseList.FirstName = stu.FirstName;
            courseList.LastName = stu.LastName;
            courseList.StudentEmail = stu.StudentEmail;
            courseList.Courses = new Courselist();
            courseList.Courses.Courses = dp.GetCourseAvailableForStudent(uID);

            //send the view 
            // return View(courseList);
            return RedirectToAction("EditCourse", new { uID = uID });
        }

        public IActionResult UpdateCourse(string class1,string class2, string class3)
        {
            //get the uid from the session
            int uID = Convert.ToInt32(HttpContext.Session.GetString("uID")); //reads from the session
    

            DALCourses dp = new DALCourses(configuration);
            dp.UpdateCourses(class1,uID);
            dp.UpdateCourses(class2, uID);
            dp.UpdateCourses(class3, uID);
            viewModelStudentCourse vwcourse = new viewModelStudentCourse();
            vwcourse.Courses = new Courselist();
            vwcourse.Courses.Courses = new List<Courses>();
            //vwcourse.Courses.Courses.Add(dp.getCourses(class1));
            //vwcourse.Courses.Courses.Add(dp.getCourses(class2));
            //vwcourse.Courses.Courses.Add(dp.getCourses(class3));

            DALStudent ds = new DALStudent(configuration);
            Student stu = ds.getStudent(uID);
            vwcourse.UID = uID;
            vwcourse.FirstName = stu.FirstName;
            vwcourse.LastName = stu.LastName;
            vwcourse.StudentEmail = stu.StudentEmail;
            //vwcourse.ClassTime = stu.ClassTime;
           return View("UpdateCourse", vwcourse);

        }





    }
}