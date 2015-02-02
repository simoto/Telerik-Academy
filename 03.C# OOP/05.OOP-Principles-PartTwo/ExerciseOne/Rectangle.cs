namespace ExerciseOne
{
    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculateSurface()
        {
            return this.height * this.height;
        }
    }
}