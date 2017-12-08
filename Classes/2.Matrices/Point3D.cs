namespace _2.Matrices
{
    public struct Point3D
    {
        static Point3D()
        {
            Origin = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D Origin { get; }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return $"{this.X}, {this.Y}, {this.Z}";
        }
    }
}