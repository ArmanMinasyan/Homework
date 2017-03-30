using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{/// <summary>
/// methods for filter List 
/// </summary>
   public static  class Filter
    {

        public static List<students.student> NameFilter(List<students.student> obj)
        {
            List<students.student> temp = obj.FindAll(el => el.name.Contains("Ham"));
            return temp;
        }
        public static List<students.student> SurnameFilter(List<students.student> obj)
        {
            List<students.student> temp = obj.FindAll(el => el.surname.Contains("yan"));
            return temp;
        }
        public static List<students.student> PhoneFilter(List<students.student> obj)
        {
            List<students.student> temp = obj.FindAll(el => el.phone.ToString().Contains("222"));
            return temp;
        }
        public static List<students.student> BirthFilter(List<students.student> obj)
        {
            List<students.student> temp = obj.FindAll(el => el.birth>2000 && el.birth<2050);
            return temp;
        }
       
        public static List<students.student> KnowofLanguageFilter(List<students.student> obj)
        {
            List<students.student> temp = obj.FindAll(el => el.knowoflanguage>-1 && el.knowoflanguage<10);
            return temp;
        }
    }
}
