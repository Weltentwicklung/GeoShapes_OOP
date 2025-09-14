using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_OOP
{
    // Creation of a class Shapes that contains the 3 shapes Rectangle Triangle and Circle
    // They consist of the Class Line
    public class Shapes
    {
        // Class Rectangle using exaclty 4 lines input control will 
        public class Rectangle
        {
            private string _rectangleId;
            private Line _length = new Line();
            private Line _length2 = new Line();
            private Line _height = new Line();
            private Line _height2 = new Line();

            public string RectangleId 
            {
                get 
                { 
                    return _rectangleId; 
                } 
                set
                {
                    _rectangleId = value;                   
                }
            }

            // Constructor for Rectanle, only needs 2 Lines as Parameters because the can be used 2 times
            public Rectangle(int id, double lengthInput, double heightInput)
            {
                _rectangleId = $"Rectangle_{id}";
                _length.Length = lengthInput;
                _length2.Length = lengthInput;
                _height.Length = heightInput;
                _height2.Length = heightInput;
                Console.WriteLine($"You created the Triangle {_rectangleId} with the length {lengthInput} and the height {heightInput}.");
                Console.WriteLine($"the perimeter of {_rectangleId} is {RectanglePerimeter()} and the area is {RectangleArea()}\n");
                return;
            }

            // Methods for perimeter and Area
            public double RectanglePerimeter()
            {
                double rectanglePerimeter = (_length.Length * 2) + (_height.Length * 2);
                return rectanglePerimeter;
            }

            public double RectangleArea()
            {
                double rectangleArea = _length.Length * _height.Length;
                return rectangleArea;
            }
        }

        public class Triangle
        {
            private string _triangleId;
            private Line _length1 = new Line();
            private Line _length2 = new Line();
            private Line _length3 = new Line();

            public string TriangleId
            {
                get
                {
                    return _triangleId;
                }
                set
                {
                    _triangleId = value;
                }
            }

            // Constructor for Trinagle. Needs 3 Lines as it is not clear whether all angles are 60°
            public Triangle(int id, double length1Input, double length2Input, double length3Input)
            {
                _triangleId = $"Triangle_{id}";
                _length1.Length = length1Input;
                _length2.Length = length2Input;
                _length3.Length = length3Input;
                Console.WriteLine($"You created the Triangle {_triangleId} with the lengths {length1Input}, {length2Input} and {length3Input}.");
                Console.WriteLine($"the perimeter of {_triangleId} is {TrianglePerimeter()} and the area is {TriangleArea()}\n");
                return;
            }

            // Methods for perimeter and Area
            public double TrianglePerimeter()
            {
                double TrianglePerimeter = _length1.Length + _length2.Length + _length3.Length;
                return TrianglePerimeter;
            }
            public double TriangleArea() 
            {
                double s = (_length1.Length + _length2.Length + _length3.Length) / 2;
                double triangleArea = Math.Sqrt(s * (s - _length1.Length) * (s - _length2.Length) * (s - _length3.Length));
                return triangleArea; 
            }
        }

        public class Circle
        {
            private string _circleId;
            private Line _length = new Line();

            public string CircleId
            {
                get
                {
                    return _circleId;
                }
                set
                {
                    _circleId = value;
                }
            }

            // Constructor for Circle
            public Circle (int id, double lengthInput)
            {
                _circleId = $"Circle_{id}";
                _length.Length = lengthInput;
                Console.WriteLine($"You created the Triangle {_circleId} with the perimeter {lengthInput}.");
                Console.WriteLine($"the area of {_circleId} is {CircleArea()}\n");
                return;
            }

            // Methodes for perimeter and area. The perimeter is equal to the line length
            public double CirclePerimeter()
            {
                double CirclePerimeter = _length.Length;
                return CirclePerimeter;
            }

            public double CircleArea()
            {
                double circleArea = Math.Pow(((_length.Length/Math.PI) / 2),2)*Math.PI;
                return circleArea;
            }
        }

    }
}
