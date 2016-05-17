using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Apearence_Count
{
    class Program
    {
        static void apearenceCount(string input,int size,int number)
        {
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] == number)
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
            int x = int.Parse(Console.ReadLine());
            apearenceCount(input,n, x);
        }
    }
}
