//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using WebApplicationDemo.Models;
//using System.Text;


//namespace WebApplicationDemo.Controllers
//{
//    public class CheckboxController : Controller
//    {
//        public IActionResult EditCourse()
//        {
//            List<Courses> ls = new List<Courses>()
//            {
//                new Courses
//                {
//                    ClassID = 1, ClassName = "Math"

//                },
//                new Courses
//                {
//                    ClassID = 2, ClassName = "English"

//                },
//                new Courses
//                {
//                    ClassID = 3, ClassName = "Math"

//                },
//                new Courses
//                {
//                    ClassID = 4, ClassName = "Math"

//                },

//            };
//            Courselist clist = new Courselist();
//            clist.Courses = ls;
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Index(Courselist courselists)
//        {
//            StringBuilder sb = new StringBuilder();
//            foreach (var item in courselists.Courses)
//            {
//                if (item.ischecked)
//                {
//                    sb.Append(item.ClassName + " ");
//                }
//            }

//            ViewBag.chkmsg = "Selected Checkboxlist Items Are " + sb.ToString();
//                return View(courselists);

//        }
//    }
//}