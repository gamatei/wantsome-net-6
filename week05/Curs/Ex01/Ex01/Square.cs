using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Square:Rectangle
    {
        public Square(double width) : base(width, width)
        {

        }
        public override double CalculateSurface()
        {
            return width * width;
        }
    }
}

