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

            Console.Write("Informe o nome do departamento: ");
            string dept = Console.ReadLine();

            Console.WriteLine("\nEnter work data:");
            Console.Write("Name: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior): ");
            string level = Console.ReadLine();

            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(level);

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(nameWorker, workerLevel, salary);

            Console.WriteLine("\nHow many contracts to this work? ");
            int qtdContracts = int.Parse(Console.ReadLine());

        }

    }

}
