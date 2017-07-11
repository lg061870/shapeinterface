using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeImplementation;

namespace Shapes.UnitTest
{
    [TestClass]
    public class ParallelogramUnitTest
    {
        [TestMethod]
        public void ParallelogramMeasurement()
        {
            var parallelogram = new Parallelogram();

            parallelogram.Base = 4;
            parallelogram.Side = 2;
            parallelogram.Height = 3;

            Assert.AreEqual(parallelogram.Perimeter, 12.0);
            Assert.AreEqual(parallelogram.GetArea(), 12.0);

        }
    }
}
