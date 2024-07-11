using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_de_gestionare_a_angajatilor
{
    internal class Example
    {
        static void Main()
        {
            FullTimeEmployee exampleFullTimeEmployee = new FullTimeEmployee()
            {
                Name = "John Davis",
                Id = 101,
                Salary = 3000,
                Bonus = 5000,
            };
            Console.WriteLine($"Full time employee: {exampleFullTimeEmployee.Name}'s annual salary is: {exampleFullTimeEmployee.CalculateAnnualSalary()}");

            PartTimeEmployee examplePartTimeEmployee = new PartTimeEmployee()
            {
                Name = "Mark Bark",
                Id = 105,
                HourlyRate = 20,
                HoursWorkedInAWeek = 80,
            };
            Console.WriteLine($"Part time employee: {examplePartTimeEmployee.Name}'s annual salary is: {examplePartTimeEmployee.CalculateAnnualSalary()}");
        }
        
    }
}
