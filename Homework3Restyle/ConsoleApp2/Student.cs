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
        public string Name { get{return name; } set { name = value; } }
        private string surname;
        public string Surname { get { return surname; } set { surname = value; } }
        private int birth;
        public int  Birth { get { return birth; } set { birth = value; } }
        private int knowoflanguage;
        public int Knowoflanguage { get { return knowoflanguage; } set { knowoflanguage = value; } }
        private string phone;
        public string Phone { get { return phone; } set { phone = value; } }

        public void Print()
        {
            Console.WriteLine(" {0} {1} {2} {3} {4} ",Name,Surname,Birth,Knowoflanguage,Phone)
            ;


        }
    }
}
