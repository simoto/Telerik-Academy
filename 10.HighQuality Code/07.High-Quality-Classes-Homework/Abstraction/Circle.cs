namespace Abstraction
{
    using System;

    class Circle : IFigure
    {
        public double Radius {
            get 
            {
                return this.Radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The Radius cant be less or equal to 0!");
                }
            } 
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
