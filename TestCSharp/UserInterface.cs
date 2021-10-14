using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestCSharp.Program;

namespace TestCSharp
{
    interface UserInterface
    {

        public bool Add(Student student);
        public bool Delete(int id);
        public bool Update(int id, Student student);
        public void ShowList();

    }
}
