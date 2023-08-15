using Inheritance.Product;
using System;

namespace Inheritance
{
    public class InheritanceProgram
    {
        public static void Main(string[] args)
        {
            try
            {
                Electronic electronic = new Electronic("E001", "Laptop", 800, 10, "Dell");
                electronic.PrintDetail("E001", "Laptop", 800, 10, "Dell");

                Clothing clothing = new Clothing("C001","T-Shirt",20,50,"Medium");
                clothing.PrintDetail("C001", "T-Shirt", 20, 50, "Medium");

                Books books = new Books("B001","Harry Potter",15,20,"Rowling");
                books.PrintDetail("B001", "Harry Potter", 15, 20, "Rowling");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}:{ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
