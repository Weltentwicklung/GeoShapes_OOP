using System;
using static GeoShapes_OOP.Shapes;

namespace GeoShapes_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduction; No userimput possible at the current form
            Console.WriteLine("In its current form, this program does not allow user input, as this would exceed the scope of the given task.");
            Console.WriteLine($"To fulfill the task, I created a shape container which contains two rectangles, one triangle, and two circles.\n\n");

            // Instatiates a ShapeContainer with the ID firstLight, which will instatiate 2 Rectangles, one Triangle and two Circles. The shapes consits of Lines. 
            ShapeContainer shapeContainer_1 = new ShapeContainer("firstLight", 1, 2);

            // Prints the Numbers of each Shape to the console
            Console.Write($"\n \n \nThe shape container you created contains {shapeContainer_1.RectangleList.Count} Rectangle(s)\n");
            Console.Write($"\nThe shape container you created contains {shapeContainer_1.TriangleList.Count} Triangle(s)\n");
            Console.Write($"\nThe shape container you created contains {shapeContainer_1.CircleList.Count} Circle(s)\n");

        }
    }
}
