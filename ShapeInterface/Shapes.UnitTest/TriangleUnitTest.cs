using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void TriangleMeasurement()
        {
            var triangle = new Triangle();

            triangle.Base = 3;
            triangle.Side1 = 2;
            triangle.Side2 = 2;
            triangle.Height = 2;

            Assert.AreEqual(triangle.Perimeter, 7.0);
            Assert.AreEqual(triangle.GetArea(), 3.0);
        }
    }
}
