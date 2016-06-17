namespace Exercises_1_4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> pointList;

        public Path(params Point3D[] points)
        {
            this.PointList = new List<Point3D>(points);
        }




        public List<Point3D> PointList
        {
            get
            {
                if (this.PointList == null)
                {
                    this.pointList = new List<Point3D>();
                }
                return pointList;
            }
            private set
            {
                this.pointList = value;
            }
        }
    }
}
