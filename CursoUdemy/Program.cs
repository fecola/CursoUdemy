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

            List<Shape> listShapes = new List<Shape>();


            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int c = 1; c <= numberOfShapes; c++)
            {
                Console.WriteLine($"\nShape #{c} data:");

                Console.Write("Rectangle or Circle (r / c)?: ");
                char shape = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Color (Black / Blue / Red): ");
                Color colorShape = Enum.Parse<Color>(Console.ReadLine());


                if (shape == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Circle(radius, colorShape));

                } else if (shape == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShapes.Add(new Rectangle(width, height, colorShape));

                }

            }


            Console.WriteLine("\n\nSHAPE AREAS: ");
            foreach(Shape shape in listShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
