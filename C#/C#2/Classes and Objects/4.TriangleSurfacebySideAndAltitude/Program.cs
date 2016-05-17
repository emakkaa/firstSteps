using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TriangleSurfacebySideAndAltitude
{
    class Triangle
    {
        static double Surface(double side,double altitude)
        {
            return (side * altitude) / 2;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",Surface(side,altitude));
        }
    }
}
