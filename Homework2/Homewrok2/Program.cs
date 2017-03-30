using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static class Menu
        {

            private static bool flag = true;
           static  List<string> data = new List<string>();
            /// <summary>
            /// function start for start avtorization
            /// </summary>
            public static void start()
            {
               
                Console.WriteLine("For Admin press 1,for Editor press 2,for Guest press 3");
                int temp = Convert.ToInt32(Console.ReadLine());

                switch (temp) //Menu for avtorization;
                {
                    case 1:
                        User user = new Admin();
                        if (Avtorizator.Login(user))
                        {data.Add(user.username+" Admin,");
                            while (flag)
                            {
                                Print();
                            }
                        }
                
                break;
                    case 2:
                        User user1 = new Editor();
                        if (Avtorizator.Login(user1))
                        { data.Add(user1.username+" Editor,");
                            while (flag)
                            {
                                Print();

                            }}
                        break;
                    case 3:
                        User user2 = new Guest();
                        if (Avtorizator.Login(user2))
                        { data.Add(user2.username+" Guset,");
                            while (flag)
                                Print();}
                        break;

                }
            }

            /// <summary>
            /// function for input message
            /// if input "Exit" you are log out
            /// </summary>
            public static void Print()
            {
                Console.WriteLine("Input message, for log out enter Exit");
                string temp = Console.ReadLine();
                if (temp == "Exit")
                {
                  for(int i=0;i<data.Count();i++)
                      Console.WriteLine(data[i]);
                    start();
                }

            }


        }

        static void Main(string[] args)
        {
           Menu.start();
            
         
        }
    }
}