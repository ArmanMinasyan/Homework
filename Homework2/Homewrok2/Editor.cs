using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Editor and his avtorization
    /// </summary>
    public class Editor:User
    {
       
        public override void Log()
       {
          Console.WriteLine("input username");
           this.username = Console.ReadLine();
           Console.WriteLine("input password");
           this.password = Console.ReadLine();
           avtorization = true;
       }

        public Editor()
        {
            Log();
        }
   }
}
