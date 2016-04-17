using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] spiralMatrix = new int[n, n];
            int start = 0;
            int end = n;
            int flag = 1;
            while (end - start >= 1)
            {
                for (int i = start; i < end; i++)
                {
                    spiralMatrix[start, i] = flag;
                    flag++;
                }
                for (int j = start+1; j < end; j++)
                {
                    spiralMatrix[j, end-1] = flag;
                    flag++;
                }
                for(int k = end-2; k >= start; k--)
                {
                    spiralMatrix[end-1, k] = flag;
                    flag++;
                }
                for(int p = end-2;p>=start+1;p--)
                {
                    spiralMatrix[p,start]=flag;
                    flag++;
                }
                start++;
                end--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write("{0} ",spiralMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
