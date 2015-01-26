using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquare
    {
        // TEST CONSTRUCTOR
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(40);
            Assert.AreEqual(40, square.Side);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityCheckSide()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityCheckSidePositivity()
        {
            Square square = new Square(-1);
        }

/*
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityCheckRequiresValue()
        {
            Square square = new Square();
        }

*/
        // TEST SCALING
        [TestMethod]
        public void TestScaleSquare100Percent()
        {
            Square square = new Square(20);
            square.Scale(100);
            Assert.AreEqual(20, square.Side);
        }

        [TestMethod]
        public void TestScaleSquare200Percent()
        {
            Square square = new Square(20);
            square.Scale(200);
            Assert.AreEqual(40, square.Side);
        }

/*
        [TestMethod]
        public void TestScaleSquare150Percent()
        {
            Square square = new Square(10);
            square.Scale(150);
            Assert.AreEqual(15, square.Side);
        }

        [TestMethod]
        public void TestScaleSquare37Percent()
        {
            Square square = new Square(10);
            square.Scale(37);
            Assert.AreEqual((decimal)3.7, square.Side);
        }

        [TestMethod]
        public void TestScaleSquareUpAndDown()
        {
            Square square = new Square(10);
            square.Scale(40);
            square.Scale(250);
            Assert.AreEqual((decimal)10, square.Side);
        }
       
        [TestMethod]
        public void TestScaleSquare0Percent()
        {
            Square square = new Square(10);
            square.Scale(0);
        }

        [TestMethod]
        public void TestScaleSquareNegativePercent()
        {
            Square square = new Square(10);
            square.Scale(-5);
        }
*/

        // MISC OTHER TESTS
        [TestMethod]
        public void TestSquareSidesCount()
        {
            Square square = new Square(10);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(10);
            Assert.AreEqual(100, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(10);
            Assert.AreEqual(40, square.Perimeter());
        }

        [TestMethod]
        public void TestSquareDefaultColors()
        {
            Square square = new Square(10);
            Assert.AreEqual(System.Drawing.Color.Tomato, square.BorderColor);
            Assert.AreEqual(System.Drawing.Color.Bisque, square.FillColor);
        }

 
    }
}