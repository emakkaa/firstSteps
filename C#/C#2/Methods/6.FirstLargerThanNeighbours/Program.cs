using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Larger_than_neighbours
{
    class Program
    {
        static void biggerCount(string input, int size)
        {
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            int result = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            biggerCount(input, n);
        }
    }
}

