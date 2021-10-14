using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class StudentManagement : UserInterface
    {
        List<Student> ls = new List<Student>();
        public bool Add(Student student)
        {
            int currentSize = ls.Count;
            ls.Add(student);
            if (ls.Count > currentSize) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void ShowList()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
