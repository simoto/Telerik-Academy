namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            DistanceCalculator.Width = 3;
            DistanceCalculator.Height = 4;
            DistanceCalculator.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", DistanceCalculator.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", DistanceCalculator.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", DistanceCalculator.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", DistanceCalculator.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", DistanceCalculator.CalcDiagonalYZ());
        }
    }
}
