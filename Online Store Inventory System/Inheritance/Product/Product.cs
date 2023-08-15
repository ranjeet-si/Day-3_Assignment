
namespace Inheritance.Product
{
    public class Product
    {
        public string ProductID { get; }
        public string Name { get; }
        public double Price { get; }
        public uint Quality { get; }

        public Product(string productID,string name,double price,uint quality)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Quality = quality;
        }

    }
}
