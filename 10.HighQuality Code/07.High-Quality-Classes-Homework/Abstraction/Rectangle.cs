namespace Abstraction
{
    using System;

    class Rectangle : IFigure
    {
        public double Width 
        {
            get
            {
                return this.Width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The Width cant be less or equal to 0!");
                }
            } 

        }

        public double Height 
        {
            get
            {
                return this.Height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The Height cant be less or equal to 0!");
                }
            } 
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
