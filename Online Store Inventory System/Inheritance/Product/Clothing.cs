using System;

namespace Inheritance.Product
{
    public class Clothing:Product
    {
        public string Size { get;}

        public Clothing(string productID, string name, double price, uint quality, string size) : base(productID, name, price, quality)
        {
            Size = size;
        }

        public void PrintDetail(string productID, string name, double price, uint quality, string size)
        {
            Console.WriteLine($"ProductID: {productID}");
            Console.WriteLine($"Name:      {name}");
            Console.WriteLine($"Price:    ${price}");
            Console.WriteLine($"Quality:   {quality}");
            Console.WriteLine($"Size:      {size}");
        }
    }
}
