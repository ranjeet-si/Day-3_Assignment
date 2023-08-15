using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Hierarchy_using_Abstract_Class
{
  
    public abstract class Employee
    {

        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public Employee( String name ,int emId, double sal)
        {
            this.Name = name;
            this.EmployeeID = emId;
            this.Salary = sal;
        }

        public abstract double CalculateBonus();

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
