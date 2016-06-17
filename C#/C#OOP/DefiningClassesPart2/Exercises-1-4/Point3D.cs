using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1_4
{
    public struct Point3D
    {
        private static readonly Point3D PointO;


        static Point3D()
        {
            PointO = new Point3D(0, 0, 0);
        }


        public Point3D(double x,double y,double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"({this.X},{this.Y},{this.Z})";
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D Point0
        {
            get
            {
                return PointO;
            }
        }

    }
}
