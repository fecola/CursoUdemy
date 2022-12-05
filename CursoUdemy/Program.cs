using System.Globalization;

namespace CursoUdemy
{

    internal class Program
    {

        static void Main(String[] args)
        {

            Console.Write("Quantidade de linhas: ");
            int qtdLinhas = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int qtdColunas = int.Parse(Console.ReadLine());


            int[,] matriz = new int[qtdLinhas, qtdColunas];


            for (int linha = 0; linha < qtdLinhas; linha++)
            {

                Console.WriteLine("\n\nLinha " + (linha + 1));

                for (int coluna = 0; coluna < qtdColunas; coluna++)
                {
                    Console.Write("Coluna " + (coluna + 1) + ": ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nInforme um número para buscar: ");
            int numero = int.Parse(Console.ReadLine());

        }

    }

}
