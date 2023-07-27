using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_17.shape;

namespace Assignment_17
{
    internal class circle
    {
        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                ShapeType = "Circle";
                Radius = radius;
            }

            public override double Area
            {
                get { return Math.PI * Math.Pow(Radius, 2); }
            }

            public override double Perimeter
            {
                get { return 2 * Math.PI * Radius; }
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Shape Type: {ShapeType}");
                Console.WriteLine($"Radius: {Radius}");
                Console.WriteLine($"Area: {Area}");
                Console.WriteLine($"Perimeter: {Perimeter}");
            }
        }
    }

    }

