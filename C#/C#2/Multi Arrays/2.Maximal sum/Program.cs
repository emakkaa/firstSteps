using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numberNandM = input.Split(' ');
            int n = int.Parse(numberNandM[0]);
            int m = int.Parse(numberNandM[1]);
            int[,] array = new int[n, m];
            for (int k = 0; k < n; k++)
            {
                string currentLine = Console.ReadLine();
                string[] currentLineString = currentLine.Split(' ');
                for (int f = 0; f < m; f++)
                {
                    array[k, f] = int.Parse(currentLineString[f]);
                }
            }
            int maxSum = int.MinValue;
            int sum = 0;
            int i = 0;
            int j = 0;
            while (true)
            {
                
                sum = 0;
                sum += array[i, j] + array[i, j + 1] +
                       array[i, j + 2] + array[i + 1, j] +
                       array[i + 1, j + 1] + array[i + 1, j + 2] +
                       array[i + 2, j] + array[i + 2, j + 1] +
                       array[i + 2, j + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                j++;
                if (j > m - 3)
                {
                    i++;
                    j = 0;
                }
                if ((i >= n - 3) && (j >= m - 3))
                {
                    break;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
