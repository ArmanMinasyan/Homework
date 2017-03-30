using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{/// <summary>
/// class for parsing .txt file 
/// </summary>
  public static  class ReadfromExcel
    {
        public static string[] Parser()
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Arman\Documents\Visual Studio 2015\Projects\Homework3\Homework3\list student.txt");
            string[] lines = text.Split('\n');
            return lines;

        }
    }
}
