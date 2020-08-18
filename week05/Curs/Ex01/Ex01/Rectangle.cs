using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Rectangle:Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {

        }
        public override double CalculateSurface()
        {
            return width * height ;
        }
    }
}
