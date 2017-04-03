using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// class for read from txt files
    /// </summary>
 public  class Parser
    {

        public string[] ParserList(string path)
        {

            string text = System.IO.File.ReadAllText(path);
            string[] lineslist = text.Split('\n');
            return lineslist;

        }

        public string[] ParserFilter(string path)
        {
            string textfilter = System.IO.File.ReadAllText(path);
            string[] linesfilter = textfilter.Split('\n');
            return linesfilter;

        }
    }
}

