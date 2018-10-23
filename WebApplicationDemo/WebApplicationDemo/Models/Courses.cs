using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplicationDemo.Models
{
    public class Courses
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public DateTime ClassTime { get; set; }
        public int UID { get; set; }
        public object StudentID { get;  set; }
    }

    public class Courselist
    {

        public List<Courses> Courses { get; set; }

    }



}
