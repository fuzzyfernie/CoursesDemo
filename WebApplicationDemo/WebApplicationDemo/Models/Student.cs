using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentEmail { get; set; }
        public int UID { get; set; }

        public int ClassID { get; set; }
        public string ClassName { get; set; }
        //public int ClassTime { get; set; }
        public DateTime ClassTime { get; set; }
        //public int UID { get; set; }
        //public bool ischecked { get; set; }


    }
}
