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
    class Manager
    {
        public List<Student> Begin(string pathl,string pathf)//path of list and path of filter
        {
            List<Student> temp = new List<Student>();
            List<Student> temp1 = new List<Student>();
            Filter filter = new Filter();
            filter.Pathlist = pathl;
            filter.Pathfilter = pathf;
            Factory factory = new Factory();
            temp=  factory.Createlist(filter.Pathlist);
            temp1 = filter.Filterlist(temp);
            return temp1;
        }
    }
}
