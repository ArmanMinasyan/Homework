using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          Manager manager=new Manager();
          List<Student> list=new List<Student>();
          list=manager.Begin(@"C:\Users\Arman\Documents\Visual Studio 2017\Projects\Homework3Restyle\ConsoleApp2\list student.txt", @"C:\Users\Arman\Documents\Visual Studio 2017\Projects\Homework3Restyle\ConsoleApp2\New Text Document.txt");
          foreach (var e in list)
            {
                e.Print();
            }

        }
    }
}
