using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triangle_surface_by_two_sides_and_an_angle
{
    class Triangle
    {
        static double Surface(double a,double b,double angle)
        {
            return ((a * b * Math.Sin(angle * Math.PI / 180)) / 2);
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",Surface(a,b,angle));
        }
    }
}
