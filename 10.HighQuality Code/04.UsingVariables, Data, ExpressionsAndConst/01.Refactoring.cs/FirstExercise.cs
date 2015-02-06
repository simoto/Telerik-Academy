namespace FigureOperations
{
	using System;
	
    public class Size
    {
        private double width, height;
		
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { 
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
		
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public static Size GetRotatedSize(Size size, double rotationAngle)
        {
            return new Size(
               Math.Abs(Math.Cos(rotationAngle)) * size.Width +
               Math.Abs(Math.Sin(rotationAngle)) * size.Height,
               Math.Abs(Math.Sin(rotationAngle)) * size.Width +
               Math.Abs(Math.Cos(rotationAngle)) * size.Height);
        }
    }
}