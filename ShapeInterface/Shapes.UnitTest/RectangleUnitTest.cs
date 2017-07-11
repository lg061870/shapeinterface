using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod]
        public void RectangleMeasurement()
        {
            var rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Width = 6;

            Assert.AreEqual(rectangle.Perimeter, 22.0);
            Assert.AreEqual(rectangle.GetArea(), 30.0);

        }
    }
}
