using System;

namespace Ex01
{
    /*
       - Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
       - Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
       - Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
       - Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
     */


    public abstract class Shape
    {
        protected double width;
        protected double height;

        public abstract double CalculateSurface();

        public Shape(double w,double h)
        {
            this.width = w;
            this.height = h;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = new Shape[3];
            array[0] = new Square(10);
            array[1] = new Triangle(9, 5);
            array[2] = new Rectangle(8, 6);

            foreach(Shape x in array)
            {
                Console.WriteLine($" the Surface is : {x.CalculateSurface()}");
            }
        }


    }
}

