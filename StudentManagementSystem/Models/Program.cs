using System;
using System.Collections.Generic;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            // أقسام تجريبية جاهزة
            Department csDept = new Department(1, "Computer Science");
            Department itDept = new Department(2, "Information Technology");
            Department aiDept = new Department(3, "Artificial Intelligence");

            // كورسات تجريبية جاهزة
            Course oop = new Course(101, "OOP", 3);
            Course db = new Course(102, "Database", 4);
            Course net = new Course(103, "Networking", 2);

            List<Department> departments = new List<Department> { csDept, itDept, aiDept };
            List<Course> allCourses = new List<Course> { oop, db, net };

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===============================");
                Console.WriteLine("🎓 Student Management System");
                Console.WriteLine("===============================");
                Console.WriteLine("1️⃣ Add Student");
                Console.WriteLine("2️⃣ Update Student");
                Console.WriteLine("3️⃣ Remove Student");
                Console.WriteLine("4️⃣ Display All Students");
                Console.WriteLine("5️⃣ Find Student By Name");
                Console.WriteLine("0️⃣ Exit");
                Console.Write("➡️ Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddStudentMenu(studentManager, departments, allCourses);
                        break;

                    case "2":
                        UpdateStudentMenu(studentManager, departments, allCourses);
                        break;

                    case "3":
                        Console.Write("Enter Student ID to remove: ");
                        int removeID = int.Parse(Console.ReadLine());
                        studentManager.RemoveStudent(removeID);
                        break;

                    case "4":
                        studentManager.DisplayStudents();
                        break;

                    case "5":
                        Console.Write("Enter Student Name to search: ");
                        string searchName = Console.ReadLine();
                        studentManager.FindStudentByName(searchName);
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("👋 Exiting program...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Invalid option! Try again.");
                        break;
                }
            }
        }

        static void AddStudentMenu(StudentManager studentManager, List<Department> departments, List<Course> courses)
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAvailable Departments:");
            foreach (var dept in departments)
                Console.WriteLine($"{dept.ID}. {dept.Name}");

            Console.Write("Choose Department ID: ");
            int deptId = int.Parse(Console.ReadLine());
            Department selectedDept = departments.Find(d => d.ID == deptId);

            Console.WriteLine("\nAvailable Courses:");
            foreach (var course in courses)
                Console.WriteLine($"{course.CourseID}. {course.Name} ({course.CreditHours}h)");

            Console.Write("Enter course IDs separated by comma (e.g. 101,102): ");
            string[] selectedIds = Console.ReadLine().Split(',');
            List<Course> selectedCourses = new List<Course>();
            foreach (var idStr in selectedIds)
            {
                if (int.TryParse(idStr.Trim(), out int courseId))
                {
                    var selected = courses.Find(c => c.CourseID == courseId);
                    if (selected != null)
                        selectedCourses.Add(selected);
                }
            }

            studentManager.AddStudent(id, name, age, selectedDept, selectedCourses);
        }

        static void UpdateStudentMenu(StudentManager studentManager, List<Department> departments, List<Course> courses)
        {
            Console.Write("Enter Student ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAvailable Departments:");
            foreach (var dept in departments)
                Console.WriteLine($"{dept.ID}. {dept.Name}");

            Console.Write("Choose New Department ID: ");
            int deptId = int.Parse(Console.ReadLine());
            Department selectedDept = departments.Find(d => d.ID == deptId);

            Console.WriteLine("\nAvailable Courses:");
            foreach (var course in courses)
                Console.WriteLine($"{course.CourseID}. {course.Name}");

            Console.Write("Enter new course IDs (e.g. 101,103): ");
            string[] selectedIds = Console.ReadLine().Split(',');
            List<Course> selectedCourses = new List<Course>();
            foreach (var idStr in selectedIds)
            {
                if (int.TryParse(idStr.Trim(), out int courseId))
                {
                    var selected = courses.Find(c => c.CourseID == courseId);
                    if (selected != null)
                        selectedCourses.Add(selected);
                }
            }

            studentManager.UpdateStudentData(id, name, age, selectedDept, selectedCourses);
        }
    }
}
