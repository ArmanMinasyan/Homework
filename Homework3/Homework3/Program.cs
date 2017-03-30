using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<students.student> students = new List<students.student>();//create List for students
            for (int i = 0; i < ReadfromExcel.Parser().Length - 2; i++)
            {

                students.Add(new students.student(ReadfromExcel.Parser()[i]));
            }
            List<students.student> filterlist = Filter.KnowofLanguageFilter(students);//there are all filters
            foreach (var el in filterlist)
            {
                el.Print();
            }
        }
    }
    }

