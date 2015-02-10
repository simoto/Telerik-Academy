namespace SecondExercise
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string rootPath = @"C:\WINDOWS";
            string fileExtension = "*.exe";

            try
            {
                TraverseDirectory(rootPath, fileExtension);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't access directory");
            }
            

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
           
        }

        private static List<string> files = new List<string>();

        private static void TraverseDirectory(string currentPath, string fileExtension)
        {
            string[] currentDirFiles = Directory.GetFiles(currentPath, fileExtension);
            files.AddRange(currentDirFiles);

            string[] curretDirDirectories = Directory.GetDirectories(currentPath);
            foreach (var dir in curretDirDirectories)
            {
                TraverseDirectory(dir, fileExtension);
            }
        }
    }
}
