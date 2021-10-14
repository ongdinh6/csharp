using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Student
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { set; get; }

        public Student() { }
        public Student(string Name, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public override string ToString()
        {
            return "Student: Name = "+Name+", DateOfBirth = "+DateOfBirth+", Age = "+Age;
        }
    }
}
