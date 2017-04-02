using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ConsoleApp2
{
    /// <summary>
    /// class to filter list 
    /// </summary>
    public  class Filter
    {
        private string pathlist;
        public string Pathlist { get { return pathlist; } set { pathlist = value; } }
        private string pathfilter;
        public string Pathfilter { get { return pathfilter; } set { pathfilter = value; } }
       
        public  List<Student>  Filterlist(List<Student> objList)
        {
           List<Student>temp=new List<Student>();
           Parser parser=new Parser();
           string[] filterlines = parser.Parserfilter(this.pathfilter);
           string[] birth = filterlines[2].Split(' ');
           int birthfrom=Int32.Parse(birth[0]);
           int tobirth=Int32.Parse(birth[1]);
           temp = objList.FindAll(el =>el.Birth>birthfrom && el.Birth<tobirth);
            return temp;
        }
       
    }
}
