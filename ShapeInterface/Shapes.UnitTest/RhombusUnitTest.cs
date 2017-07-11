using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class RhombusUnitTest
    {
        [TestMethod]
        public void RhombusMeasurement()
        {
            var rhombus = new Rhombus();

            rhombus.Height = 3;
            rhombus.Side = 2;

            Assert.AreEqual(rhombus.Perimeter, 8.0);
            Assert.AreEqual(rhombus.GetArea(), 6.0);
        }
    }
}
