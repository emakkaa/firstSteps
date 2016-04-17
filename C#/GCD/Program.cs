using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int A = int.Parse(numbers[0]);
            int B = int.Parse(numbers[1]);
            int r = 1;
            int q = A / B;
            if (A!=0 && B!=0) {
                if (A > B)
                {
                    while (r != 0)
                    {
                        if (A % B == 0)
                        {
                            Console.WriteLine(B);
                            break;
                        }
                        r = A % B;
                        q = A / B;
                        A = B;
                        B = r;
                    }
                }
                else if (B > A)
                {
                    while (r != 0)
                    {

                        if (B % A == 0)
                        {
                            Console.WriteLine(A);
                            break;
                        }
                        r = B % A;
                        q = B / A;
                        B = A;
                        A = r;
                    }
                }
                else
                {
                    Console.WriteLine(A);
                }
            }
        }
    }
}