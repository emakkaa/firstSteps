using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeck
{
    class Program
    {
        static void Main()
        {
            string input =Console.ReadLine();
            string copy = input;
            int flag;
            char c;
            bool temp2=char.TryParse(input, out c);
            bool temp=int.TryParse(copy, out flag);
            if (temp && flag <= 10)
            {
                for (int i=2; i<=flag; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",i);
                }
            }
            else if(temp2)
            {
                switch (c)
                {
                    case 'J':
                        {
                            for (int i = 2; i <= 10; i++)
                            {
                                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                            }
                                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                        }
                        break;
                    case 'Q':
                        {
                            for (int i = 2; i <= 10; i++)
                            {
                                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                            }
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                            break;
                        }
                    case 'K':
                        {
                            for (int i = 2; i <= 10; i++)
                            {
                                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                            }
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                            break;
                        }
                    case 'A':
                        {
                            for (int i = 2; i <= 10; i++)
                            {
                                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                            }
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "J");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "Q");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "K");
                            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", "A");
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
