using System.Globalization;

namespace CursoUdemy
{

    internal class Program
    {

        static void Main(String[] args)
        {

            Triangulo t1 = new Triangulo();

            double areaTriangulo;

            Console.WriteLine("valor do lado A");
            t1.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("valor do lado B");
            t1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("valor do lado C");
            t1.C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTriangulo = t1.CalcularArea();

            Console.WriteLine();
            Console.WriteLine("Área do triângulo = " + areaTriangulo.ToString("F2", CultureInfo.InvariantCulture));

        }

    }

}
