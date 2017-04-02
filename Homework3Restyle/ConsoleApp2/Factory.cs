using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Create List of students from data source;
/// </summary>
    class Factory
    {
        /// <summary>
        /// student initialization
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Student StudentCreator(string obj)
        {

            {
                string[] temp = obj.Split(' ');
                Student student=new Student();
                student.Name = temp[0];
                student.Surname = temp[1];
                student.Birth = Int32.Parse(temp[2]);
                student.Knowoflanguage = Int32.Parse(temp[3]);
                student.Phone = temp[4];
                return student;
            }
          
        }
        /// <summary>
        ///  list initialization
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Student> Createlist(string path)
        {
            Parser temp=new Parser();
            string[] lines =
            temp.Parserfilter(path);
            List<Student> list=new List<Student>();
            for (int i = 0; i < lines.Length-2; ++i)
            {
                list.Add(StudentCreator(lines[i]));
            }
            return list;
        }
    }
}
