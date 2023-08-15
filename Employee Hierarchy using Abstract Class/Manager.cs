using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Hierarchy_using_Abstract_Class
{
    class Manager : Employee
    {

        public Manager(String name, int emId, double sal):base( name,  emId, sal)
        {
            
        }
        public override double CalculateBonus()
        {
            return Salary * 0.15; 
        }

        public void DisplayManagerDetails()
        {
            DisplayDetails();
            Console.WriteLine($"Bonus: {CalculateBonus()}");
        }
    }
}
