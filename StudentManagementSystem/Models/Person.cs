using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            
        }

        public Person(int id , string name , int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        public void UpdatePersonInfo(string NewName, int NewAge)
        {
            this.Name = NewName;
            this.Age = NewAge;
        }
    }
}
