using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tnayin_1;

namespace tnayin_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 N, M, N1,M1;
            Random rnd = new Random();
            Console.WriteLine(" count of rows matrix1");
            N = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" count of columns matrix1");
            M = Int32.Parse(Console.ReadLine());
            double[,] matrix1 = new double[N, M];
            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix1.GetLength(1); ++j)
                    matrix1[i, j] = rnd.Next(10);
            }
            Console.WriteLine(" count of rows matrix2");
            N1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" count of columns matrix2");
            M1 = Int32.Parse(Console.ReadLine());
         
            double[,] matrix2 = new double[N1, M1];
            

            for (int i = 0; i < matrix2.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                    matrix2[i, j] = rnd.Next(10);
            }
            multiply temp = new multiply();
            double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            result = temp.MultiplyMatrix(matrix1, matrix2);

            for (int i = 0; i < result.GetLength(0); ++i)
            {
                for (int j = 0; j < result.GetLength(1); ++j)
                {
                    Console.Write(String.Format("{0}\t", result[i, j]));
                }
                    Console.Write(Environment.NewLine);
                
            }
           
            

        }
    }
}
    
