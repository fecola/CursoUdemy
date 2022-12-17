using System;
using System.Globalization;
using CursoUdemy.Entities;
using CursoUdemy.Entities.ENUMs;
using System.Globalization;

namespace CursoUdemy
{

    internal class Program
    {

        static void Main(String[] args)
        {

            // Criando objetos
            Worker worker;
            WorkerLevel workerLevel;
            HourContract hourContract;
            Department dept;

            Console.Write("Informe o nome do departamento: ");
            dept = new Department(Console.ReadLine());

            Console.WriteLine("\nEnter work data:");
            Console.Write("Name: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior): ");
            workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            worker = new Worker(nameWorker, workerLevel, salary, dept);

            Console.Write("\nHow many contracts to this work? ");
            int qtdContracts = int.Parse(Console.ReadLine());

            for (int c = 1; c <= qtdContracts; c++)
            {
                Console.WriteLine($"\nEnter #{c} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                
                hourContract = new HourContract(dateContract, valuePerHours, hours);

                worker.AddContract(hourContract);

            }


            Console.Write("\n\nEnter month and year to calculate income (MM/YYYY): ");
            string incomeDate = Console.ReadLine();
            int month = int.Parse(incomeDate.Substring(0, 2));
            int year = int.Parse(incomeDate.Substring(3, 4));


            double incomevalue = worker.Income(year, month);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {incomeDate}: " + incomevalue);

        }

    }

}
