using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    internal class StudentManager
    {
        public List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void AddStudent(int id, string name, int age, Department department, List<Course> courses)
        {
            var newStudent = new Student(id, name, age, department, courses);
            students.Add(newStudent);
            Console.WriteLine($"Student '{name}' added successfully!");
        }

        public void RemoveStudent(int id)
        {
            // Implementation for removing a student
            Student StudentToRemove = null;
            foreach (var student in students)
            {
                if (student.ID == id)
                {
                    StudentToRemove = student;
                    break;
                }
            }

            if (StudentToRemove != null)
            {
                students.Remove(StudentToRemove);
                Console.WriteLine($"Student with ID {id} removed successfully!");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        public void UpdateStudentData(int id , string NewName , int NewAge , Department NewDepartment , List<Course> NewCourses) 
        {
            // Implementation for updating student name
            Student StudentToUpdate = null;
            foreach (var student in students)
            {
                if (student.ID == id)
                {
                    StudentToUpdate = student;
                    break;
                }
            }

            if (StudentToUpdate != null)
            {
                StudentToUpdate.UpdatePersonInfo(NewName, NewAge);
                StudentToUpdate.Department = NewDepartment;
                StudentToUpdate.Courses = NewCourses ?? new List<Course>();

                Console.WriteLine($"Student with ID {id} updated successfully!");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        public void DisplayStudents()
        {
            // Implementation for displaying all students
            foreach (var student in students)
            {
                student.DisplayInfo();
                Console.WriteLine("-----------------------");
            }
        }

        public void FindStudentByName(string name)
        {
            // Implementation for finding student by name
            var foundStudents = students.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundStudents.Count > 0)
            {
                Console.WriteLine($"Found {foundStudents.Count} student(s) with the name '{name}':");
                foreach (var student in foundStudents)
                {
                    student.DisplayInfo();
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine($"No students found with the name '{name}'.");
            }
        }
    }
} 
