using System;

namespace _2.Matrices
{
    class Program
    {
        static void Main()
        {
            Point3D p = new Point3D(0, 1, 2);
            Point3D p2 = new Point3D(3, 4, 5);

            Console.WriteLine(Geometry.Distance(p, p2));

            Path path = new Path();
            path.Points.Add(p);
            path.Points.Add(p2);

            PathStorage.SavePath("path.txt", path);

            Path newPath = PathStorage.LoadPath("path.txt");

            Console.WriteLine();

            GenericList<int> list = new GenericList<int>(1, 2, 3, 4, 5, 6);

            Console.WriteLine(list);
            list.InsertAt(100, 6);

            Console.WriteLine(list);
        }

        public static T Max<T>(GenericList<T> list) where T : IComparable<T>
        {
            if (list.Count <= 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            var max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (max.CompareTo(list[i]) == -1)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public static T Min<T>(GenericList<T> list) where T : IComparable<T>
        {
            if (list.Count <= 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            var min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min.CompareTo(list[i]) == 1)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}