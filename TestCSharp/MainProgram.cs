using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class MainProgram
    {
       static StudentManagement studentManagement = new StudentManagement();
        static void addStudent()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter birth day(dd/mm/yyyy): ");
            DateTime birthDate = new DateTime();
            try
            {
                string date = Console.ReadLine();
                birthDate = DateTime.Parse(date);
            }catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Student student;
            if(true == studentManagement.Add(student = new Student(name, birthDate)))
            {
                Console.WriteLine(student.ToString());
            }
            else
            {
                Console.WriteLine("Cannot add");
            }
           
        }
        static void run()
        {
            addStudent();
            
        }
        static void Main()
        {
            run();
        }
    }
}
