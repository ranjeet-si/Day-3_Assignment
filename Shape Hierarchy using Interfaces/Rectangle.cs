using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Hierarchy_using_Interfaces
{
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

}
