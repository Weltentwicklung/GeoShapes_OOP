using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoShapes_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes_OOP.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleTest_CorrectParameter_InstantiatesCorrectly()
        {
            // arrange (done with all steps just to show off
            int id = 1;
            double lengthInput = 10.1;
            double heightInput = 4.553;

            // act
            Shapes.Rectangle rectangle_1 = new (id, lengthInput, heightInput);


            // assert
            Assert.IsNotNull(rectangle_1);
        }

        [TestMethod()]
        public void RectanglePerimeterTest_CalculatesCorrectValue()
        {
            // arrange, the perimeter needs 2 lines both can be doubled
            Shapes.Rectangle rectangle_1 = new Shapes.Rectangle(1, 20, 10);
            double calculatedPerimeter = (20 * 2) + (10 * 2);

            // act
            double perimeter = rectangle_1.RectanglePerimeter();

            // assert
            Assert.IsTrue(perimeter == calculatedPerimeter);
        }

        [TestMethod()]
        public void RectangleAreaTest_CalculatesCorrectValue()
        {
            // arrange
            Shapes.Rectangle rectangle_1 = new Shapes.Rectangle(1, 20, 10);
            double calculatedarea = 20 * 10;

            // act
            double area = rectangle_1.RectangleArea();

            // assert
            Assert.IsTrue(area == calculatedarea);

        }
    }
}