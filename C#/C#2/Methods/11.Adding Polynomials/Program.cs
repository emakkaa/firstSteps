using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_Polynomials
{
    
    class Program
    {
        static void printArray(int[] array,int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ",array[i]);
            }
        }
        static void sumPolynomials(string array1,string array2,int size)
        {
            string[] arr = array1.Split(' ');
            int[] array = arr.Select(int.Parse).ToArray();
            string[] arr2 = array2.Split(' ');
            
            int[] secondArray = arr2.Select(int.Parse).ToArray();
            int[] resultArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = array[i] + secondArray[i];
            }
            printArray(resultArray, size);
            
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string array1 = Console.ReadLine();
            string array2 = Console.ReadLine();
            sumPolynomials(array1, array2, n);

        }
    }
}
