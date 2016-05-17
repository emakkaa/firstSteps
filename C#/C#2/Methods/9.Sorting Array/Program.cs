using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sorting_Array
{
    class Program
    {
        public static void sortArray(string input)
        {
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            sortArray(input);
            
        }
    }
}
