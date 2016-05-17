using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;
            char[] array = new char[27];
            int counter = 0;
            for (int i = 97; i <= 122; i++)
            {
                array[counter] = (char)i;
                counter++;
            }
            for (int i = 0; i < wordLength ; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if (word[i] == array[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
