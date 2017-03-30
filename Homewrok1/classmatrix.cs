using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tnayin_1
{
    class multiply
    {

        public double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2)
        {
         
            double temp = 0;
            double[,] res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1)!=matrix2.GetLength(0))
                throw new Exception("exception");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    temp = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    res[i, j] = temp;
                }
            }
            return res;

        }
    }
}
