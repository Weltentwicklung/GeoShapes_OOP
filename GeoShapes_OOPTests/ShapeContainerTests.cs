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
    public class ShapeContainerTests
    {
        [TestMethod()]
        public void ShapeContainerTest_CorrectParameter_InstantiatesCorrectly()
        {
            //arrange Not necessary as it can be declared in the call directly
            
            //act "_" can be used because we just want to test the Constructor
            _ = new ShapeContainer("testName", 2, 2);

            //assert not needed as a faild object construction will automatically give an exception
        }

        [TestMethod()]
        public void ShapeContainerTest_TooFewTriangles_ThrowsException()
        {
            //arrange Not necessary as it can be declared in the call directly
            //act not necessary as it is implemented in the assert-methode call
            //assert
            Assert.ThrowsException<ArgumentException>(() => new ShapeContainer("testName", -1, 1));
        }

        [TestMethod()]
        public void ShapeContainerTest_TooFewCircles_ThrowsException()
        {
            //arrange Not necessary as it can be declared in the call directly
            //act not necessary as it is implemented in the assert-methode call
            //assert
            Assert.ThrowsException<ArgumentException>(() => new ShapeContainer("testName", 1, 0));
        }

        [TestMethod()]
        public void ShapeContainerTest_TooMuchTriangles_ThrowsException()
        {
            //arrange Not necessary as it can be declared in the call directly
            //act not necessary as it is implemented in the assert-methode call
            //assert
            Assert.ThrowsException<ArgumentException>(() => new ShapeContainer("testName", 5, 1));
        }

        [TestMethod()]
        public void ShapeContainerTest_TooMuchCircles_ThrowsException()
        {
            //arrange Not necessary as it can be declared in the call directly
            //act not necessary as it is implemented in the assert-methode call
            //assert
            Assert.ThrowsException<ArgumentException>(() => new ShapeContainer("testName", 1, 4));
        }
    }
}