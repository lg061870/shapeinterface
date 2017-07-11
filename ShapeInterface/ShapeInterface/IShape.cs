using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterface
{
    public interface IShape
    {
        double Perimeter { get; }
        double GetArea();
    }
}
