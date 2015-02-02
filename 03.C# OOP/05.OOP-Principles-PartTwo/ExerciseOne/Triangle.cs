namespace ExerciseOne
{
    class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculateSurface()
        {
            return this.height * this.width / 2;
        }
    }
}