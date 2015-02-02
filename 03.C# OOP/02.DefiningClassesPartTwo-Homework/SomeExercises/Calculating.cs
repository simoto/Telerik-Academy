namespace SomeExercises
{
    using System;

    public static class Calculating
    {
        public static Point3D CalcDistance(Point3D firstPoint, Point3D secondPoint)
        {
            Point3D calculated = new Point3D();

            if (firstPoint.X > secondPoint.X)
            {
                calculated.X = firstPoint.X - secondPoint.X;
            }
            else if (secondPoint.X > firstPoint.X)
            {
                calculated.X = secondPoint.X - firstPoint.X;
            }
            else
            {
                calculated.X = 0;
            }

            if (firstPoint.Y > secondPoint.Y)
            {
                calculated.Y = firstPoint.Y - secondPoint.Y;
            }
            else if (secondPoint.Y > firstPoint.Y)
            {
                calculated.Y = secondPoint.Y - firstPoint.Y;
            }
            else
            {
                calculated.Y = 0;
            }

            if (firstPoint.Z > secondPoint.Z)
            {
                calculated.Z = firstPoint.Z - secondPoint.Z;
            }
            else if (secondPoint.Z > firstPoint.Z)
            {
                calculated.Z = secondPoint.Z - firstPoint.Z;
            }
            else
            {
                calculated.Z = 0;
            }

            return calculated;
        }
    }
}