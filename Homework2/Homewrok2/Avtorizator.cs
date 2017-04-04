using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class Avtorizator
    {
        public static bool Login(User obj)
        {return obj.avtorization;}
    
    }
 
}
