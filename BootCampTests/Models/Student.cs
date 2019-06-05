using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootCampTests.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Age { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual ICollection<Course> Courses { get; set; }
    }
}