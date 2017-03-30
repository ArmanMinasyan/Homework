using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
  public  class students
    {
     public    struct student
        {
            public string name;
            public string surname;
            public int knowoflanguage;
            public int birth;
            public int phone;
            /// <summary>
            /// constructor initalizated by string
            /// </summary>
            /// <param name="str">
            /// line of the txt file</param>
            public student(string str)

            {
                string[] temp = str.Split(' ');
                this.name = temp[0];
                this.surname = temp[1];
                this.birth = Int32.Parse(temp[2]);
                this.knowoflanguage = Int32.Parse(temp[3]);
                this.phone = Int32.Parse(temp[4]);
            }
            /// <summary>
            /// method for print struct
            /// </summary>
            public void Print()
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, birth, knowoflanguage, phone);
            }
        }
    }
}
