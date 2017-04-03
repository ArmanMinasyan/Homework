using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// method for start to filter
    /// </summary>
   public static class Manager
    {
        public static void Run(string pathl,string pathf)//path of list and path of filter
        {
            List<Student> temp = new List<Student>();
            List<Student> temp1 = new List<Student>();
            Factory factory = new Factory();
            temp=  factory.CreateStudentList(pathl);
            temp1 = Filter.FilterList(temp,pathf);
            foreach (var el in temp1)
            {
                el.Print();
            }
        }
      
    }
}
