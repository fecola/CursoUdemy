using CursoUdemy.Enum;
using System.Runtime.ConstrainedExecution;
using Xadrez;

namespace CursoUdemy
{
    internal class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {

            ConsoleColor aux = Console.ForegroundColor;

            for (int l = 0; l < tabuleiro.linhas; l++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(8 - l + " ");
                Console.ForegroundColor = aux;

                for (int c = 0; c < tabuleiro.colunas; c++)
                {

                    Tela.ImprimirPeca(tabuleiro.Peca(l, c));
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n   A  B  C  D  E  F  G  H");
            Console.ForegroundColor = aux;

        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {

            ConsoleColor aux = Console.ForegroundColor;
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int l = 0; l < tabuleiro.linhas; l++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(8 - l + " ");
                Console.ForegroundColor = aux;

                for (int c = 0; c < tabuleiro.colunas; c++)
                {
                    if (posicoesPossiveis[l, c])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }

                    Tela.ImprimirPeca(tabuleiro.Peca(l, c));
                    Console.Write(" ");
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n   A  B  C  D  E  F  G  H");
            Console.ForegroundColor = aux;
            Console.BackgroundColor = fundoOriginal;

        }



        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write(" -");

            } else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                } else
                {
                    ConsoleColor cor = ConsoleColor.Black;

                    switch (peca.cor.ToString())
                    {
                        case "Amarela":
                            cor = ConsoleColor.Yellow;

                            break;

                        case "Azul":
                            cor = ConsoleColor.DarkBlue;

                            break;

                        case "Verde":
                            cor = ConsoleColor.DarkGreen;

                            break;

                        case "Vermelha":
                            cor = ConsoleColor.DarkRed;

                            break;

                        case "Laranja":
                            cor = ConsoleColor.DarkYellow;

                            break;

                        case "Preta":
                            cor = ConsoleColor.Yellow;

                            break;
                    }

                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = cor;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
            }
        }


        public static PosicaoXadrez LerPosicaoXadrez()
        {

            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);

        }

    }
}
