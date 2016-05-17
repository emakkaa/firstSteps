using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_as_array
{
    class Program
    {
        static List<int> sumNumbersAsArray(List<int> input1,List<int> input2)
        {
            List<int> result = new List<int>();
            int transition = 0;
            for (int i = 0; i < input1.Count; i++)
            {
                int currentSum = input1[i] + input2[i] + transition;
                if (currentSum<10)
                {
                    result.Add(currentSum);
                    transition = 0;
                }
                else
                {
                    
                    int currentDigit = currentSum % 10;
                    result.Add(currentDigit);
                    currentDigit = currentSum /= 10;
                    transition = currentDigit;
                    if (i == input1.Count - 1 && transition != 0)
                    {
                        result.Add(transition);
                    }
                }
            }
            return result;
        }

        private static List<int> InitialiseIntarray(string input,int size)
        {
            List<int> array = new List<int>();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < size; i++)
            {
                if (i < numbers.Length)
                {
                    array.Add(numbers[i]);
                }
                else
                {
                    array.Add(0);
                }
            }
            return array;
        }

        static void Main()
        {
            int[] sizes = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            int maxSize = Math.Max(sizes[0], sizes[1]);
            var firstNumber = InitialiseIntarray(firstInput, maxSize);
            var secondNumber = InitialiseIntarray(secondInput, maxSize);

            var result = sumNumbersAsArray(firstNumber, secondNumber);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
