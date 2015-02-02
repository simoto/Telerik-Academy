namespace SomeExercises
{
    using System;
    using System.Collections.Generic;
    
    [Version(1.22)]
    class MainMenu
    {
        static void Main()
        {         
            Point3D one = new Point3D(1, 2, 3);
            Point3D two = new Point3D(4, 5, 6);
            Point3D three = new Point3D(7, 5, 8);

            Path newPath = new Path();
            newPath.AddNewPath(one);
            newPath.AddNewPath(two);
            newPath.AddNewPath(three);

            PathStorage.SavePath(newPath);
            List<Point3D> loaded = new List<Point3D>();
            loaded = PathStorage.LoadPath(@"..\..\savedPaths.txt");

            Type type = typeof(MainMenu);
            object[] versionAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine("The version of the class VersionDemo is {0:0.00}.",
                    versionAttribute.GetVersion());
            }

            Console.WriteLine();
        }
    }
}
