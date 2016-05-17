using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequent_number
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            
            for (int i = 0; i <N ; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int frequentNumber=0;
            int frequentNumberTester;
            int counter = 1;
            int frequentTimes = 0;
            for (int i = 0; i < N; i++)
            {
                counter = 1;
                frequentNumberTester = array[i];
                for (int j = i+1; j < N; j++)
                {    
                    if (frequentNumberTester == array[j])
                    {
                        counter++;
                    }
                }
                if (counter>frequentTimes)
                {
                    frequentTimes = counter;
                    frequentNumber = frequentNumberTester;
                }                  
            }
            Console.WriteLine("{0} ({1} times)",frequentNumber,frequentTimes);
        }
    }
}
