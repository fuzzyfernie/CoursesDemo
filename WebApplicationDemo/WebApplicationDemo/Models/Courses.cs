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
        public int ClassTime { get; set; }
        public int UID { get; set; }
        public bool ischecked { get; set; }
    }

    public class Courselist
    {

        public List<Courses> courses { get; set; }
    }



}
