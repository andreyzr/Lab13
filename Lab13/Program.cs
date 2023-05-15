using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularTriangle regularTriangle = new RegularTriangle();
            /*RectangularTriangle rectangularTriangle = new RectangularTriangle(4,5); //Экземпляр дочернего класса*/
            Triangle triangle = regularTriangle;
            if (triangle is RectangularTriangle)
            {
                RectangularTriangle rectangularTriangle = (RectangularTriangle)triangle;
            }

            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b)

        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }
    }
    class RegularTriangle : Triangle
    {

    }
}
