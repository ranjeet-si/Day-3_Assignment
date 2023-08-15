namespace Shape_Hierarchy_using_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(56);
            circle.DisplayDetails();

            Rectangle rectangle = new Rectangle(9, 3);
            rectangle.DisplayDetails();

            Triangle triangle = new Triangle(8, 4);
            triangle.DisplayDetails();
        }
    }
}