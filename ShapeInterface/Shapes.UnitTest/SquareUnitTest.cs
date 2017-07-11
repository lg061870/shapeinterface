using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class SquareUnitTest
    {
        [TestMethod]
        public void SquareMeasurement()
        {
            var square = new Square();

            square.Side = 4;

            Assert.AreEqual(square.Perimeter, 16.0);
            Assert.AreEqual(square.GetArea(), 16.0);
        }
    }
}
