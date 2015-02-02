namespace SomeExercises
{
    public struct Point3D
    {
        private static readonly Point3D PointO = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public override string ToString()
        {
            return string.Format("X = {0}\nY = {1}\nZ = {2}", X, Y, Z);
        }

        public static Point3D ReturnPointO
        {
            get { return PointO; }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
