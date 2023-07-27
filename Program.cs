using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_17.circle;
using static Assignment_17.rectangle;
using static Assignment_17.triangle;

namespace Assignment_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle(6, 4);
            rectangle.PrintInfo();

            Triangle triangle = new Triangle(2, 4, 7);
            triangle.PrintInfo();
        }
    }
}

