using System;
using System.IO;

namespace TestCSharp
{
    class WorkingWithFile
    {
        static void runFile()
        {
            StreamWriter file = File.AppendText("F:/TestCSharp/test.txt");
            Console.WriteLine("Enter some text in here: ");
            string s = "";
            do
            {
                s = Console.ReadLine();
                if(s.Length != 0)
                file.WriteLine(s);

            } while (s.Length != 0);
            file.Close();

        }
        public delegate int MyDelegate(int a, int b);
        public static int sum(int a, int b)
        {
            return a + b;
        }

        //static void Main(string[] arg)
        //{
        //    try
        //    {
        //        MyDelegate myDelegate = new MyDelegate(sum);
        //        Console.WriteLine(myDelegate(2, 4));
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Always printed!");
        //    }
        //}

       
    }
}
