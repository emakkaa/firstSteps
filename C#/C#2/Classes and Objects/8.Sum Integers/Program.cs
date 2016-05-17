using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_Integers
{
    class Integers
    {
        static int[] ToIntegerArray(string input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            return array;
        }
        static int SumOfIntegers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(SumOfIntegers(ToIntegerArray(input)));
        }
    }
}
