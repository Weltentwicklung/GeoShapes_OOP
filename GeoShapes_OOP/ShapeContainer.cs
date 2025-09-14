using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeoShapes_OOP.Shapes;

namespace GeoShapes_OOP
{
    /// <summary>
    /// Creates a ShapeContainer containing different amouts of different Shapes.
    /// It always contains 2 Rectangles, 0-4 Triangles and 1-3 Circles
    /// </summary>
    public class ShapeContainer
    {

        private string _containerId;
        private Random rnd = new Random();
        private List<Rectangle> _rectangleList = new List<Rectangle>();
        private List<Triangle> _triangleList = new List<Triangle>();
        private List<Circle> _circleList = new List<Circle>();

        /// <summary>
        /// Gets the <c>_rectangleId</c> and returns a value to it
        /// </summary>
        public string ContainerId 
        {
            get 
            {
                return _containerId;
            } 
            set 
            {
                _containerId = value;            
            }
        }

        /// <summary>
        /// Gets the <c>_rectangleList</c> and the set is set to private.
        /// </summary>
        public List<Rectangle> RectangleList
        {
            get
            {
                return _rectangleList;
            }
            private set { }
        }

        /// <summary>
        /// Gets the <c>_triangleList</c> and the set is set to private.
        /// </summary>
        public List<Triangle> TriangleList
        {
            get
            {
                return _triangleList;
            }
            private set { }
        }

        /// <summary>
        /// Gets the <c>_circleList</c> and the set is set to private.
        /// </summary>
        public List<Circle> CircleList
        {
            get
            {
                return _circleList;
            }
            private set { }
        }

        // Constructor for ShapeContainer. Doesn't take values for the amout of Rectangle as this will always be 2
        /// <summary>
        /// Creates a "ShapeContainer" with "containerName" as ID, always 2 Rectangles, between 0 and 4 Triangles according to "nrOfTrinagles" and between 1 and 3 Circles according to "nrOfCircles"
        /// </summary>
        /// <param name="containerName">Will be used to give the ShapeContainer an ID</param>
        /// <param name="nrOfTriangles">Is used to create that amout of Triangles</param>
        /// <param name="nrOfCircles">Is used to create that amout of Circles</param>
        /// <exception cref="ArgumentException">
        /// Throws an ArgumentException if the number of Rectangle is not 2
        /// Throws an ArgumentException if the number of Triangles is not between 0 and 4
        /// Throws an ArgumentException if the number of Circles is not between 1 and 3
        /// </exception>
        public ShapeContainer(string containerName, int nrOfTriangles, int nrOfCircles)
        {
            _containerId = containerName;
            int nrOfRectangles = 2;
            int idRectangles = nrOfTriangles + 1;
            int idTriangles = nrOfTriangles + 1;
            int idCircles = nrOfCircles + 1;

            // Parameter check for the numbers or Shapes
            if (nrOfRectangles != 2)
            {
                throw new ArgumentException("Due to an incompatibility between input and the requirement, the ShapeContainer couldn't be initiated!");
            }
            if (nrOfTriangles <0 || nrOfTriangles >4)
            {
                throw new ArgumentException("Due to an incompatibility between input and the requirement, the ShapeContainer couldn't be initiated!");
            }
            if (nrOfCircles < 1 || nrOfCircles > 3)
            {
                throw new ArgumentException("Due to an incompatibility between input and the requirement, the ShapeContainer couldn't be initiated!");
            }

            // Ideally, the function would allow a user to create the desired number of shapes with the desired line lengths within the capabilities of a shape container.
            // In this version, the called constructor in the Main-Method will create a specific numbers of shapes with randomly generated line lengths.

            // Creates always exactly 2 Rectangles, because that is a necessity, the Rectangle ID starts from 1
            for (int i = 0; i < nrOfRectangles; nrOfRectangles--)
            {
                AddRectangle((idRectangles - nrOfRectangles));
            }

            // Creates the choosen amount of Triangles with an ID starting from 1
            for (int i = 0; i < nrOfTriangles; nrOfTriangles--)
            {
                AddTriangle((idTriangles - nrOfTriangles));
            }

            // Creates the choosen amout of Circles with an ID starting from 1
            for (int i = 0; i < nrOfCircles; nrOfCircles--)
            {
                AddCircle((idCircles - nrOfCircles));
            }

        }


        // The following 3 functions creates Shapes with a random Numbers between 0.001 and 100.001
        /// <summary>
        /// Creates a Rectangle with a given parameter as id in the form of "Rectangle{id}".
        /// Adds the Rectangle to a List of Rectangles called <c>_rectangleList</c>
        /// </summary>
        /// <param name="id">Takes an Integer and uses it for the creation of an id</param>
        public void AddRectangle(int id)
        {
            double length = (rnd.NextDouble() + 0.001) * 100;
            double height = (rnd.NextDouble() + 0.001) * 100;
            _rectangleList.Add(new Rectangle(id, length, height));
        }

        /// <summary>
        /// Creates a Triangle with a given parameter as id in the form of "Triangle{id}".
        /// Adds the Triangle to a List of Triangles called <c>_triangleList</c>
        /// </summary>
        /// <param name="id">Takes an Iteger and uses it for the creation of an id</param>
        public void AddTriangle(int id)
        {
            double length1 = (rnd.NextDouble() + 0.001) * 100;
            double length2 = (rnd.NextDouble() + 0.001) * 100;
            double length3 = (rnd.NextDouble() + 0.001) * 100;
            _triangleList.Add(new Triangle(id, length1, length2, length3));
        }

        /// <summary>
        /// Creates a Circle with a given parameter as id in the form of "Circle{id}".
        /// Adds the Circle to a List of Circles called <c>_circleList</c>
        /// </summary>
        /// <param name="id">Takes an Iteger and uses it for the creation of an id</param>
        public void AddCircle(int id)
        {
            double length = (rnd.NextDouble() + 0.001) * 100;
            _circleList.Add(new Circle(id, length));
        }        
    }
}
