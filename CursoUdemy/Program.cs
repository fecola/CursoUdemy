using CursoUdemy.Entities;
using System.Globalization;

namespace CursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1;
            Employee employee2;
            List<Employee> listEmployee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployess = int.Parse(Console.ReadLine());


            for (int c = 1; c <= numberOfEmployess; c++)
            {
                Console.WriteLine($"\nEmployee #{c} data: ");
                Console.Write("Outsourced? (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameEmployee = Console.ReadLine();

                Console.Write("Hours: ");
                int hoursEmployee = int.Parse(Console.ReadLine());

                Console.Write("value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'n' || outsourced == 'N')
                {
                    employee1 = new Employee(nameEmployee, hoursEmployee, valuePerHour);

                    listEmployee.Add(employee1);

                } else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee2 = new OutsourcedEmployee(nameEmployee, hoursEmployee, valuePerHour, additionalCharge);

                    listEmployee.Add(employee2);

                }

            }


            Console.WriteLine("\n\nPAYMENT:");

            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
