using System;

namespace Inheritance.Product
{
    public class Electronic : Product
    {
        private string Brand { get; }
        public Electronic(string productID, string name, double price, uint quality,string brand) : base(productID, name, price,quality)
        {
            Brand = brand;
        }

        public void PrintDetail(string productID, string name, double price, uint quality,string brand)
        {
            Console.WriteLine($"ProductID: {productID}");
            Console.WriteLine($"Name:      {name}");
            Console.WriteLine($"Price:    ${price}");
            Console.WriteLine($"Quality:   {quality}");
            Console.WriteLine($"Brand:     {brand}");
        }
    }
}
