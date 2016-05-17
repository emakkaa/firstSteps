using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            string firstArray = Console.ReadLine();
            string secondArray = Console.ReadLine();
            int firstArrayLength = firstArray.Length;
            int secondArrayLength = secondArray.Length;
            int bigger;
            if (firstArrayLength>secondArrayLength)
            {
                bigger = secondArrayLength;
            }
            else
            {
                bigger = firstArrayLength;
            }
            int i = 0;
            bool flag = true;
            for (i=0; i <bigger ; i++)
            {
                if (firstArray[i]<secondArray[i])
                {
                    Console.WriteLine("<");
                    flag = false;
                    break;
                }
                else if (firstArray[i]>secondArray[i])
                {
                    Console.WriteLine(">");
                    flag = false;
                    break;
                }
            }
            if (i==firstArrayLength && i==secondArrayLength)
            {
                Console.WriteLine("=");
            }
            if (flag && firstArrayLength<secondArrayLength)
            {
                Console.WriteLine("<");
            }
            if (flag && firstArrayLength>secondArrayLength)
            {
                Console.WriteLine(">");
            }
        }
    }
}
