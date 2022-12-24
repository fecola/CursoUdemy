using CursoUdemy.Entities;
using CursoUdemy.Entities.Enums;
using CursoUdemy.Entities.ENUMs;
using System.Globalization;

namespace CursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double totalTaxes = 0;
            List<Person> listPersons = new List<Person>();


            Console.Write("Enter the number of tax payers: ");
            int numberPayers = int.Parse(Console.ReadLine());

            for (int c = 1; c <= numberPayers; c++)
            {
                Console.WriteLine($"\nTaz payer #{c} data: ");

                Console.Write("Individual or companu (i / c)? ");
                char typePerson = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (typePerson == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double helthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPersons.Add(new PessoaFisica(name, anualIncome, helthExpenditures));

                } else if (typePerson == 'C')
                {
                    Console.Write("Numbers employees: ");
                    int numbersEmployess = int.Parse(Console.ReadLine());

                    listPersons.Add(new PessoaJuridica(name, anualIncome, numbersEmployess));

                }

            }


            Console.WriteLine("\n\nTAXES PAID: ");
            foreach(Person person in listPersons)
            {
                totalTaxes += person.CalcularRendaAnual();

                Console.WriteLine(person.Nome + ": R$" + person.CalcularRendaAnual().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\nTOTAL TAXES: R$" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
