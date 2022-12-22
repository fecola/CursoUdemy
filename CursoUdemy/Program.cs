using CursoUdemy.Entities;
using System.Globalization;

namespace CursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int c = 1; c <= numberOfProducts; c++)
            {

                Console.WriteLine($"\nProduct #{c} data:");

                Console.Write("Common, used or imported? (c / u / i) ");
                char typeOfProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                switch (typeOfProduct)
                {
                    case 'c':
                        listProducts.Add(new Product(nameProduct, priceProduct));

                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        listProducts.Add(new ImportedProducts(nameProduct, priceProduct, customFee));

                        break;

                    case 'u':
                        Console.Write("Manufactured Date: ");
                        DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());

                        listProducts.Add(new UsedProduct(nameProduct, priceProduct, manufacturedDate));

                        break;

                }

            }


            Console.WriteLine("\n\nPRICE TAGS:");
            foreach(Product product in listProducts)
            {
                Console.WriteLine(product);
            }

        }
    }
}
