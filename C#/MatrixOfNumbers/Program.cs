using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);
                for (int j = i+1; j <= n+i-1; j++)
                {
                    Console.Write("{0} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
