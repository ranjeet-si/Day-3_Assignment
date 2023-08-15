using System;

namespace Inheritance.Product
{
    public class Books : Product
    {
        private string Author { get; }

        public Books(string productID, string name, double price, uint quality, string author) : base(productID, name, price, quality)
        {
            Author = author;    
        }

        public void PrintDetail(string productID, string name, double price, uint quality, string author)
        {
            Console.WriteLine($"ProductID: {productID}");
            Console.WriteLine($"Name:      {name}");
            Console.WriteLine($"Price:    ${price}");
            Console.WriteLine($"Quality:   {quality}");
            Console.WriteLine($"Author:    {author}");
        }
    }
}
