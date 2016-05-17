using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            long productOdd = 1;
            long productEven = 1;
            int n = int.Parse(Console.ReadLine());
            if (n>=4 && n<=50)
            {
                var a = Console.ReadLine();
                string[] numbers = a.Split(' ');
                for (int i = 0; i < n; i++)
                {
                    int copyValue =int.Parse(numbers[i]);
                    if((i+1) % 2 == 0)
                    {
                        productEven *= copyValue;
                    }
                    else
                    {
                        productOdd *= copyValue;
                    }
                }
            }
            if (productOdd == productEven)
            {
                Console.WriteLine("yes {0}",productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}",productOdd , productEven);
            }
        }
   }
}
