using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class TrapezoidUnitTest
    {
        [TestMethod]
        public void TrapezoidMeasurement()
        {
            var trapezoid = new Trapezoid();
            trapezoid.Height = 3;
            trapezoid.ShortBase = 2;            
            trapezoid.Leg1 = 2;
            trapezoid.Leg2 = 2;
            trapezoid.LongBase = 4;

            Assert.AreEqual(trapezoid.Perimeter, 10.0);
            Assert.AreEqual(trapezoid.GetArea(), 9.0);

        }
    }
}
