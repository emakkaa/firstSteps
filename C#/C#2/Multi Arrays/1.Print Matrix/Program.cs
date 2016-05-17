using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            char x = char.Parse(Console.ReadLine());
            if (x == 'a')
            {
                for (int row = 0; row < n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        array[row, column] = 1 + row + column * n;
                    }
                }
                for (int row = 0; row < n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        if (column != n - 1)
                        {
                            Console.Write("{0} ", array[row, column]);
                        }
                        else
                        {
                            Console.Write("{0}", array[row, column]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (x == 'b')
            {
                int counter = 1;
                bool flag = true;
                for (int column = 0; column < n; column++)
                {
                    if (flag)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            array[row, column] = counter;
                            counter++;
                        }
                        flag = false;
                    }
                    else
                    {
                        for (int row = n - 1; row >= 0; row--)
                        {
                            array[row, column] = counter;
                            counter++;
                        }
                        flag = true;
                    }
                }
                for (int row = 0; row < n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        if (column != n - 1)
                        {
                            Console.Write("{0} ", array[row, column]);
                        }
                        else
                        {
                            Console.Write("{0}", array[row, column]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (x == 'c')
            {
                int flag = 1;
                int limit = 0;
                while (limit < n)
                {
                    limit++;
                    int row = n - limit;
                    int column = 0;
                    for (int i = 0; i < limit; i++)
                    {
                        array[row,column] = flag;
                        flag++;
                        row++;
                        column++;
                    }
                }
                while (limit>=0)
                {
                    limit--;
                    int row = 0;
                    int column = n-limit;
                    for (int i = 0; i < limit; i++)
                    {
                        array[row, column] = flag;
                        flag++;
                        row++;
                        column++;
                    }
                }

                //drugiq while

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != n - 1)
                        {
                            Console.Write("{0} ", array[i, j]);
                        }
                        else
                        {
                            Console.Write("{0}", array[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (x=='d')
            {
                int start = 0;
                int end = n;
                int flag = 1;
                while (end - start >= 1)
                {
                    for (int i = start; i < end; i++)
                    {
                        array[i, start] = flag;
                        flag++;
                    }
                    for (int j = start + 1; j < end; j++)
                    {
                        array[end-1, j] = flag;
                        flag++;
                    }
                    for (int k = end - 2; k >= start; k--)
                    {
                        array[k, end-1] = flag;
                        flag++;
                    }
                    for (int p = end - 2; p >= start + 1; p--)
                    {
                        array[start, p] = flag;
                        flag++;
                    }
                    start++;
                    end--;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != n - 1)
                        {
                            Console.Write("{0} ", array[i, j]);
                        }
                        else
                        {
                            Console.Write("{0}", array[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
