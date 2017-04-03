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
      
        public static  List<Student>  FilterList(List<Student> objList,string pathFilter)
        {
           List<Student>temp=new List<Student>();
           Parser parser=new Parser();
           string[] filterlines = parser.ParserFilter(pathFilter);
           string[] birth = filterlines[2].Split(' ');
           int birthFrom=Int32.Parse(birth[0]);
           int tobirth=Int32.Parse(birth[1]);
           temp = objList.FindAll(el => el.Name.Contains(filterlines[0].Remove(3)) && el.Birth>birthFrom && el.Birth<tobirth && el.Surname.Contains(filterlines[1].Remove(3)) && el.Phone.Contains(filterlines[4]));
            return temp;
        }
       
    }
}
