using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_4
{
    public static class CalculateDistanceBetweenPoints
    {
        public static double CalcDist(Point3D firstPoint,Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2)
                    + Math.Pow(secondPoint.Y - firstPoint.Y, 2)
                    + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
        }

    }
}
