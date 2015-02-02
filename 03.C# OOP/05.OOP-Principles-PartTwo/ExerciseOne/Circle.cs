namespace ExerciseOne
{
    using System;

    class Circle : Shape
    {
        public Circle()
        {
            this.height = this.width;
        }

        public Circle(double height, double width)
        {
            height = width;
            this.height = height;
            this.width = height;
        }

        public override double CalculateSurface()
        {
            return this.height * Math.PI;
        }
    }
}
