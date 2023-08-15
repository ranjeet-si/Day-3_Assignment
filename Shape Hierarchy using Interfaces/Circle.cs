using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy_using_Interfaces
{

    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }
}
