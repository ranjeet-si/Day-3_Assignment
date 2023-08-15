namespace Employee_Hierarchy_using_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Ranjeet", 01, 35000);
            
            manager.DisplayManagerDetails();

            Developer developer = new Developer("Ranjeet", 01, 35000);
            
            developer.DisplayDeveloperDetails();

            SalesPerson salesPerson = new SalesPerson("Ranjeet", 01, 35000);
           
            salesPerson.DisplaySalesPersonDetails();
        }
    }
}