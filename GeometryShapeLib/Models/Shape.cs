using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryShapeLib.Models
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public override abstract string ToString();
    }
}
