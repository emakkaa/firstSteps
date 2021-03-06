﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main()
        {
            ulong decimalNumber = ulong.Parse(Console.ReadLine());
            string result = String.Empty;
            if (decimalNumber > 15)
            {
                while (decimalNumber > 0)
                {
                    ulong flag = decimalNumber % 16;
                    switch (flag)
                    {
                        case 15: result += 'F'; break;
                        case 14: result += 'E'; break;
                        case 13: result += 'D'; break;
                        case 12: result += 'C'; break;
                        case 11: result += 'B'; break;
                        case 10: result += 'A'; break;
                        default:
                            result += flag.ToString();
                            break;
                    }
                    decimalNumber /= 16;
                }
            }
            else
            {
                switch (decimalNumber)
                {
                    case 15: result += 'F'; break;
                    case 14: result += 'E'; break;
                    case 13: result += 'D'; break;
                    case 12: result += 'C'; break;
                    case 11: result += 'B'; break;
                    case 10: result += 'A'; break;
                    default:
                        result += decimalNumber.ToString();
                        break;
                }
            }
            result = new string(result.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
