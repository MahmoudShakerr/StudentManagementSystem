using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    internal class Department
    {
        public int ID { get; set; } 
        public string Name { get; set; }

        public Department()
        {

        }

        public Department( int id , string name)
        {
            this.ID = id;
            this.Name = name;
        }
    } 
}
