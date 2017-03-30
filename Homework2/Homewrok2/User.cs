using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// class user and avtorization function
    /// </summary>
  public  abstract class User
    {
        public bool avtorization;
        public string username;
        public string key;
        public string password;
        public abstract void Log();
    }
}
