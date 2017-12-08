using System.Collections.Generic;

namespace _2.Matrices
{
    public class Path
    {
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public Path(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points { get; set; }
    }
}