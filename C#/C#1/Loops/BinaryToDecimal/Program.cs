using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            //BigInteger decimalNumber = 0;
            //int counter = 0;
            //BigInteger binaryNumber = BigInteger.Parse(Console.ReadLine());
            //BigInteger copy = binaryNumber;
            //while (copy>0)
            //{
            //    copy /= 10;
            //    counter++;
            //}
            //BigInteger flag = (BigInteger)Math.Pow(2, counter);
            //for (int i = 1; i <=flag ; i*=2)
            //{
            //    if (binaryNumber%10==1)
            //    {
            //        decimalNumber += i;
            //        binaryNumber /= 10;
            //    }
            //    else
            //    {
            //        binaryNumber /= 10;
            //    }
            //}
            //Console.WriteLine(decimalNumber);
            var number = Console.ReadLine();
            var dec=0;
            for(int i = 0; i < number.Length; i++)
            {
                if (number[number.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine(dec);

        }
    }
}
