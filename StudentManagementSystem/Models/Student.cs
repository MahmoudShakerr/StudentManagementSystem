using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSystem.Models
{
    internal class Student : Person
    {
        public Department Department { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }

        public Student(int id, string NewName, int NewAge, Department NewDepartment, List<Course> NewCourses) 
                    : base(id, NewName, NewAge)
        {
            Department = NewDepartment;
            Courses = NewCourses ?? new List<Course>();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Department: {Department?.Name}");
            Console.WriteLine("Courses :");
            foreach (var course in Courses)
            {
                Console.WriteLine($"\tCourseID: {course.CourseID}, Name: {course.Name}, CreditHours: {course.CreditHours}");
            }
        }

        public override string ToString()
        {
            var coursesInfo = string.Join(", ", Courses.Select(c => c.Name));
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Department: {Department?.Name}, Courses: {coursesInfo}";
        }
    }
}
