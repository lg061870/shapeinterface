using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Height { get; set; }

        public double Perimeter
        {
            get
            {
                return Base + Side1 + Side2;
            }
        }

        public double GetArea()
        {
            return (Base * Height) / 2;
        }
    }
    
}
