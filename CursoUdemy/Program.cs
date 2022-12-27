
namespace CursoUdemy
{
    internal class Program
    {

        public static void Main(String[] args)
        {

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.WriteLine();

        }

    }
}
