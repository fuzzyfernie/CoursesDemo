using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Models
{
    public class viewModelStudentCourse : Student
    {
        public Courselist Courses { get;set; }
    }
}
