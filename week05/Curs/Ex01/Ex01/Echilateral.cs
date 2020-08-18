using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Echilateral:Triangle
    {
        public Echilateral(double width):base(width, width *Math.Sqrt(3)/2)
        {

        }
    }
}
