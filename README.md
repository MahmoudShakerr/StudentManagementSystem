# 🎓 Student Management System  

A simple **console-based application** built in **C# (.NET)** to manage students, departments, and courses.  
This project applies **Object-Oriented Programming (OOP)** concepts like **Encapsulation**, **Inheritance**, and **Composition** in a practical, real-world example.

---

## 🚀 Project Overview
This system allows you to:
- Add new students with their details  
- Assign students to departments  
- Add courses for each student  
- Update or remove students  
- Display student information  

It’s a basic management system that simulates how a university might organize student data.

---

## 🧠 Concepts Used
This project is built with a focus on **OOP principles**:
- **Encapsulation:** Each class manages its own data (e.g., `Student`, `Department`, `Course`)
- **Inheritance:** `Student` inherits from `Person`
- **Composition:** Each `Student` has a `Department` and a list of `Courses`
- **Abstraction:** Logic separated into classes with clear responsibilities

---

## 🧱 Project Structure


- **Models:** Contain the main entities (Student, Department, Course, Person)
- **Services:** Contain the logic for managing students (add, update, remove, display)

---

## 🧩 Classes Overview

### `Person`
Base class with:
- `ID`, `Name`, `Age`
- `UpdatePersonInfo()` method

### `Student`
Inherits from `Person`, includes:
- `Department`
- `List<Course>`
- `DisplayInfo()` to print student data

### `Department`
Represents a department with:
- `ID`, `Name`

### `Course`
Represents a course with:
- `CourseID`, `Name`, `CreditHours`

### `StudentManager`
Handles:
- Adding / Updating / Removing students
- Displaying all students
- Searching by name

---

## ⚙️ How to Run
1. Open the project in **Visual Studio**  
2. Set the console project as **Startup Project**  
3. Run the project (`Ctrl + F5`)  
4. Use the provided methods in `StudentManager` to manage students  

> 💡 You can extend the project by adding user input via console menus.

---

## 🧰 Technologies Used
- **C#**
- **.NET**
- **OOP**
- **Console Application**

---

## 📸 Example Output

---

## 🔮 Future Improvements
- Add console menu for user interaction  
- Save data to a file or database  
- Implement searching and filtering  

---

## 👨‍💻 Author
**Mahmoud Shaker**  
📧 [Email: mahmoudshaker073@gmail.com]  
💼 [LinkedIn Profile: www.linkedin.com/in/mahmoud-shakerr]  
