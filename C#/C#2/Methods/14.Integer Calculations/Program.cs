using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Integer_Calculations
{
    class Program
    {
        public static void minimum(string input)
        {
            int minimum = int.MaxValue;
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (minimum > array[i])
                {
                    minimum = array[i];
                }
            }
            Console.WriteLine(minimum);
        }
        public static void maximum(string input)
        {
            int maximum = int.MinValue;
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (maximum < array[i])
                {
                    maximum = array[i];
                }
            }
            Console.WriteLine(maximum);
        }
        public static void average(string input)
        {
            double sum = 0;
            double counter = 0;
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                counter++;
            }
            Console.WriteLine("{0:F2}",sum/counter);
        }
        public static void sum(string input)
        {
            int sum = 0;
            
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                
            }
            Console.WriteLine(sum);
        }
        public static void product(string input)
        {
            BigInteger product = 1;
           
            string[] arr = input.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
                
            }
            Console.WriteLine(product);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            minimum(input);
            maximum(input);
            average(input);
            sum(input);
            product(input);
        }
    }
}
