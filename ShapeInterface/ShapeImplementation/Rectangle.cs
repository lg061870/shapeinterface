using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double Perimeter
        {
            get
            {
                return 2 * Width + 2 * Length;
            }
        }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}
