using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    public class Triangle:Shape
    {

        public Triangle(double w, double h): base(w, h)
        {

        }
        public override double CalculateSurface()
        {
            return width*height/2;
        }
    }
}
