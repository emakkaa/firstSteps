using System;


namespace MMSAofNNumbers
{
    class Program
    {
        static void Main()
        {
            double sum = 0;
            double max = int.MinValue;
            double min = int.MaxValue;
            double avg = 0;
            double counter = 0;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                double a = double.Parse(Console.ReadLine());
                sum += a;
                counter++;
                if (min > a)
                {
                    min = a;
                }
                if (max < a)
                {
                    max = a;
                }
            }
            avg = sum / counter;
            Console.WriteLine("min={0:F2}",min);
            Console.WriteLine("max={0:F2}",max);
            Console.WriteLine("sum={0:F2}",sum);
            Console.WriteLine("avg={0:F2}",avg);
        }
    }
}
