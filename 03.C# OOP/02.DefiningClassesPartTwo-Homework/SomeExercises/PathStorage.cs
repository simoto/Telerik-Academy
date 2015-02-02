namespace SomeExercises
{
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path somePoint)
        {
            StreamWriter savePath = new StreamWriter(@"..\..\savedPaths.txt");

            foreach (var item in somePoint.Sequences)
            {
                savePath.WriteLine("{0}-{1}-{2}", item.X, item.Y, item.Z);
            }

            savePath.Close();
        }

        public static List<Point3D> LoadPath(string path)
        {
            StreamReader loadPath = new StreamReader(path);
            List<Point3D> loadedPoints = new List<Point3D>();
            string line = loadPath.ReadLine();
            while (line != null)
            {
                string[] currentLine = line.Split(new[] { '-' });
                loadedPoints.Add(new Point3D(int.Parse(currentLine[0]), int.Parse(currentLine[1]), int.Parse(currentLine[2])));
                line = loadPath.ReadLine();
            }

            return loadedPoints;
        }
    }
}