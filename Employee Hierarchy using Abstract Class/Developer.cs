using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Hierarchy_using_Abstract_Class
{
    class Developer : Employee
    {

        public Developer(String name, int emId, double sal) : base(name, emId, sal)
        {

        }
        public override double CalculateBonus()
        {
            return Salary * 0.10; 
        }

        public void DisplayDeveloperDetails()
        {
            DisplayDetails();
            Console.WriteLine($"Bonus: {CalculateBonus()}");
        }
    }
}
