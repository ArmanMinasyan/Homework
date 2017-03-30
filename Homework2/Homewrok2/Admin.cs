using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// class Admin and its avtorization
    /// </summary>
  public  class Admin:User
    {
       
      public  override  void  Log()
        {

            Console.WriteLine("input username");
            this.username = Console.ReadLine();
            Console.WriteLine("input password");
            this.password = Console.ReadLine();
            Console.WriteLine("Input your key");
            this.key = Console.ReadLine();
            avtorization = true;


        }

        public Admin()
        {
            Log();
        }
    }
}
