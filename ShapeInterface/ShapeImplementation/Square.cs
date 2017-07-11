﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
