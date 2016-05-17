using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.English_Word
{
    class Program
    {
        static void getLastDigit(int number)
        {
            string myString = number.ToString();
            switch (myString[myString.Length-1])
            {
                case '1': Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            getLastDigit(input);

        }
    }
}
