using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy_using_Interfaces
{
    class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculatePerimeter()
        {
            return 3 * Base;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Shape: Triangle");
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }
}
