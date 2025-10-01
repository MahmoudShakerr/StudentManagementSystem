using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    internal class Course
    {
        public int CourseID { get; set; } 
        public string Name { get; set; } 
        public int CreditHours { get; set; }

        public Course()
        {

        }

        public Course(int courseId, string name, int creditHours)
        {
            this.CourseID = courseId;
            this.Name = name;
            this.CreditHours = creditHours;
        }
    }
}
