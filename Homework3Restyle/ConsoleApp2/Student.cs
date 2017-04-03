using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public   class Student
    {
        private string name;
        public string Name { get; set; }
        private string surname;
        public string Surname { get; set;  }
        private int birth;
        public int  Birth { get; set; }
        private int knowoflanguage;
        public int Knowoflanguage { get; set; }
        private string phone;
        public string Phone {  get; set; }

        public void Print()
        {
            Console.WriteLine(" {0} {1} {2} {3} {4} ",Name,Surname,Birth,Knowoflanguage,Phone)
            ;


        }
    }
}
