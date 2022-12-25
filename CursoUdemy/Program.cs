using CursoUdemy.Entities;
using CursoUdemy.Entities.Exceptions;
using System.Globalization;

namespace CursoUdemy
{
    internal class Program
    {

        public static void Main (String[] args)
        {


            Console.WriteLine("Enter account data:");

            try
            {

                Console.Write("Number account: ");
                int numberAccount = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Account account = new Account(numberAccount, holder, initialBalance, withdrawLimit);


                Console.Write("\n\nEnter amout for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amountWithdraw);

                Console.WriteLine("\n\nNew Balance: " + account.CheckBalance().ToString("F2", CultureInfo.InvariantCulture));


            } catch (FormatException error) {
                Console.WriteLine(error.Message);

            } catch (AccountException error)
            {
                Console.WriteLine("ERRO: " + error.Message);

            } finally
            {
                Console.WriteLine("\n\nOperação concluída!!!");
            }





            /*
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkinDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkoutDate = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(roomNumber, checkinDate, checkoutDate);

                Console.WriteLine(reservation);


                Console.WriteLine("\n\nEnter data to update reservation: ");

                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkinDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkoutDate = DateTime.Parse(Console.ReadLine());


                reservation.UpdateDate(checkinDate, checkoutDate);

                Console.WriteLine("Reservation: " + reservation);

            } catch (DomainException error)
            {
                Console.WriteLine("Error in reservation: " + error.Message);

            } catch (FormatException error)
            {
                Console.WriteLine("Erro: " + error.Message);

            } catch (Exception error)
            {
                Console.WriteLine(error.Message);

            }*/

        }

    }

}
