using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Parallelogram : IShape
    {
        public double Base { get; set; }
        public double Side { get; set; }
        public double Height { get; set; }

        public double Perimeter
        {
            get
            {
                return 2 * (Base + Side);
            }
        }

        public double GetArea()
        {
            return Base * Height;
        }
    }
}
