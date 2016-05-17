using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FromOneNumeralSystemToAnyAnother
{
    class Program
    {
        //1st step:Convert the number to decimal
        public static long ToBase10(string number, int baseS)
        {
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (String.IsNullOrEmpty(number))
                return 0;

            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    result = -result;
                    break;
                }

                int digit = digits.IndexOf(c);

                result += digit * multiplier;
                multiplier *= baseS;
            }

            return result;
        }
        //2nd step:Convert the number from decimal
        static void NumeralConvertor(long number,long toSystem)
        {
            List<long> result = new List<long>();
            if (toSystem > 10)
            {
                while (number > 0)
                {
                    result.Add(number % toSystem);
                    number /= toSystem;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    switch (item)
                    {
                        case 10: Console.Write('A'); break;
                        case 11: Console.Write('B'); break;
                        case 12: Console.Write('C'); break;
                        case 13: Console.Write('D'); break;
                        case 14: Console.Write('E'); break;
                        case 15: Console.Write('F'); break;
                        default: Console.Write(item); break;
                    }
                }
                Console.WriteLine();
            }
            else
            {
                while (number > 0)
                {
                    result.Add(number % toSystem);
                    number /= toSystem;
                }
                result.Reverse();
                foreach (var item in result)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int firstNumeralSystem = int.Parse(Console.ReadLine());
            string number = Console.ReadLine().ToUpper();
            long secondNumeralSystem = int.Parse(Console.ReadLine());
            NumeralConvertor(ToBase10(number, firstNumeralSystem),secondNumeralSystem);
            

        }
    }
}
