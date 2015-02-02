/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
  Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure
  (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at
  initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that 
  tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored
  in an array. */

namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestProgram
    {
        static void Main()
        {
            List<Shape> someShapes = new List<Shape>()
            {
              new Circle(3, 3),
              new Triangle(4, 5),
              new Rectangle(6, 4)
            };

            var sortedShapeBySurface = from shape in someShapes
                                       orderby shape.CalculateSurface()
                                       select shape;

            foreach (var item in sortedShapeBySurface)
            {
                Console.WriteLine("{0} surface: {1}", item.GetType().Name, item.CalculateSurface());
            }
        }
    }
}