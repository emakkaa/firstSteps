using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Get_Largest_Number
{
    class Program
    {
        static void GetMax(string input)
        {
            int maxValue = int.MinValue;
            string[] numbers=input.Split(' ');
            int[] myInts = numbers.Select(int.Parse).ToArray();
            for (int i = 0; i < myInts.Length; i++)
            {
                if (myInts[i] > maxValue)
                {
                    maxValue = myInts[i];
                }
            }
            Console.WriteLine(maxValue);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetMax(input);
        }
    }
}
