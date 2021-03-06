﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimal
{
    class Program
    {
        static void hexadecimalToDecimal(string hexaNumber)
        {
            ulong decimalNumber = 0;
            
            int counter = hexaNumber.Length - 1;
            for (int i = 0; i < hexaNumber.Length; i++)
            {
                ulong helper = 0;
                switch (hexaNumber[i])
                {

                    case 'A': decimalNumber += (10 * (ulong)Math.Pow(16, counter)); break;
                    case 'B': decimalNumber += (11 * (ulong)Math.Pow(16, counter)); break;
                    case 'C': decimalNumber += (12 * (ulong)Math.Pow(16, counter)); break;
                    case 'D': decimalNumber += (13 * (ulong)Math.Pow(16, counter)); break;
                    case 'E': decimalNumber += (14 * (ulong)Math.Pow(16, counter)); break;
                    case 'F': decimalNumber += (15 * (ulong)Math.Pow(16, counter)); break;
                    default:
                        helper = (ulong)hexaNumber[i] - 48;
                        decimalNumber += (helper * (ulong)Math.Pow(16, counter)); break;

                }
                counter--;
            }
            Console.WriteLine(decimalNumber);
        }
        static void Main(string[] args)
        {
            string hexaNumber = Console.ReadLine();
            hexadecimalToDecimal(hexaNumber);
        }
    }
}
