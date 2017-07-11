using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Trapezoid : IShape
    {
        public double LongBase { get; set; }
        public double ShortBase { get; set; }
        public double Leg1 { get; set; }
        public double Leg2 { get; set; }
        public double Height { get; set; }

        public double Perimeter
        {
            get
            {
                return LongBase + ShortBase + Leg1 + Leg2;
            }
        }

        public double GetArea()
        {
            return ((ShortBase + LongBase) / 2) * Height;
        }
    }
}
