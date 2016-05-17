using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Larger_than_neighbours
{
    class Program
    {
        static void biggerCount(string input,int size)
        {
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if(array[i]>array[i+1] && array[i] > array[i - 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            biggerCount(input, n);
        }
    }
}
