using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _2.Matrices
{
    public static class PathStorage
    {
        public static Path LoadPath(string filePath)
        {
            Path result = new Path();

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {

                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] coordinates = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse).ToArray();

                    double x = coordinates[0];
                    double y = coordinates[1];
                    double z = coordinates[2];

                    Point3D point = new Point3D(x, y, z);

                    result.Points.Add(point);

                    line = reader.ReadLine();
                }
            }

            return result;
        }

        public static void SavePath(string filePath, Path path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine(point);
                }
            }
        }
    }
}