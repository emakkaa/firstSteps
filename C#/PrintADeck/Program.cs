using System;


namespace PrintADeck
{

    class Program
    {
        static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }


        static void Main()
        {
            double sum = 1;
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                sum += Fact(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
