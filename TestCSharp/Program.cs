using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharp
{
    class Program
    {
        static bool stop = false;
        public static string SolveProgram2(int a, int b, int c)
        {
            StringBuilder sb = new StringBuilder();
            if (a == 0) sb.Append("Number a param can not be zero!");
            int delta = b * b - 4 * a * c;
            if (delta < 0) sb.Append("No result");
            if (delta == 0) sb.Append("One result of program is " + (-b / (2 * a)));
            if (delta > 0) sb.Append("Program has two result are " + (-b + Math.Sqrt(delta)) / (2 * a) + " and " + (-b - Math.Sqrt(delta)) / (2 * a));
            return sb.ToString();
        }

        //public static void run()
        //{
        //    StudentManagement stm = new StudentManagement();

        //    Console.WriteLine("Enter your function:\n1. Add\n2. Delete\n3. Update\n4. Show\n5. Exit");
        //    try
        //    {
        //        int choice = int.Parse(Console.ReadLine());
        //        switch (choice)
        //        {
        //            case 1:
        //                Student student = Create();
        //                if (stm.Add(student)) Console.WriteLine("Add successfully!");
        //                else Console.WriteLine("Cannot add new student!");
        //                break;
        //            case 2:
        //                Console.Write("Enter student id to remove: ");
        //                int Id = int.Parse(Console.ReadLine());
        //                if (stm.Delete(Id)) Console.WriteLine("Remove student has id = " + Id + " successfully!");
        //                else Console.WriteLine("Cannot remove this student!");
        //                break;
        //            case 4:
        //                stm.ShowList();
        //                break;
        //            case 5:
        //                Console.WriteLine("Stop!");
        //                stop = true;
        //                break;
        //        }
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine("Your choice is invalid! Try again.");
        //    }
           
        //}
        //private static Student Create()
        //{
        //    Console.Write("Name: ");
        //    string Name = Console.ReadLine();
        //    Console.Write("Age: ");
        //    int Age = 0;
        //    try
        //    {
        //        Age = int.Parse(Console.ReadLine());
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine("Age info invalid! Try again.");
        //    }

        //    return new Student(Name, Age);
        //}

        //class StudentManagement : UserInterface
        //{
        //    static List<Student> ListStudent = new List<Student>();
        //    public bool Add(Student student)
        //    {
        //        int size = ListStudent.Count;
        //        ListStudent.Add(student);

        //        return size < ListStudent.Count ? true : false;
        //    }

        //    public bool Delete(int id)
        //    {
        //        int size = ListStudent.Count;
        //        try
        //        {
        //            Student student = ListStudent.Find(x => x.Id == id);
        //            ListStudent.Remove(student);
        //        }
        //        catch(NullReferenceException e)
        //        {
        //            Console.WriteLine("Error: " + e.Data);
        //        }

        //        return size > ListStudent.Count ? true : false;
        //    }

        //    public void ShowList()
        //    {
        //        Console.WriteLine("====Student====");
        //        ListStudent.ForEach(x =>
        //        {
        //            Console.WriteLine(x.Print());
        //        });
        //    }

        //    public bool Update(int id, Student student)
        //    {
        //        return false;
        //    }

        //}

        //public class Student
        //{
        //    public int Id { set; get; }
        //    public string Name { set; get; }
        //    public int Age { set; get; }
        //    static int autoIncrementId;

        //    public Student() { }

        //    public Student(string Name, int Age)
        //    {
        //        autoIncrementId += 1;
        //        this.Id = autoIncrementId;
        //        this.Name = Name;
        //        this.Age = Age;
        //    }

        //    public string Print()
        //    {
        //        return Id + ", name = " + Name + ", age = " + Age;
        //    }
            
        //}

        //static void Main(string[] args)
        //{
        //    while (!stop)
        //    {
        //        run();
        //    }

        //}
        //    string result = SolveProgram2(4, -2, -6);
        //    Console.WriteLine(result);
        //    dynamic d = null;
        //    string s = "s";
        //    int[] arrInt = new int[] { 1, 2, 3, 4 };
        //    double[] arrDoublde = new double[] { 1, 2, 3, 4 };
        //    bool[] arrBool = new bool[] { false, true, false, false };
        //    float[] arrFloat = new float[] { 1f, 2f, 4f, 5f };
        //    for (float f = 1; f < 2.0f; f += 0.1f)
        //    {
        //        Console.Write(f + ", ");
        //    }
        //    Console.WriteLine("Hello World!, "+d+s);
        //    double x = 1.2d;
        //    bool x2 = false;
        //    switch (x2)
        //    {
        //        case false:
        //            Console.WriteLine(!x2);
        //            break;
        //        default:
        //            Console.WriteLine(x2);
        //            break;
        //    }
        //}

    }
}
