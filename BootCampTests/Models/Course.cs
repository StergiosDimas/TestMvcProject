using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootCampTests.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}