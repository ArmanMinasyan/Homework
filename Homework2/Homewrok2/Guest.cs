using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    ///  Guest and his avtorization
    /// </summary>
   public class Guest:User
    {
      
        public override void  Log()
        {
            Console.WriteLine("input username");
            this.username = Console.ReadLine();

            avtorization = true;
        }

        public Guest()
        {
            Log();
        }
    }
}
