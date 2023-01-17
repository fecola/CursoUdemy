using CursoUdemy.Entities;
using CursoUdemy.Services;
using System.Globalization;

namespace CursoUdemy
{
    internal class Program
    {

        public static void Main(String[] args)
        {

            Console.WriteLine("Enter rental data:");
            
            Console.Write("Car model: ");
            string modelCar = Console.ReadLine();


            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            DateTime horaEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/mm/yyyy hh:mm): ");
            DateTime horaSaida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental rental = new CarRental(horaEntrada, horaSaida, new Vehicle(modelCar));



            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            RentalService rentalService = new RentalService(priceHour, priceDay);

            rentalService.ProcessInvoice(rental);



            Console.WriteLine("\nINVOICE: ");
            Console.WriteLine(rental.Invoice);


        }

    }
}
 