using CursoUdemy.Enum;

namespace CursoUdemy
{
    internal class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {

            for (int l = 0; l < tabuleiro.linhas; l++)
            {
                Console.Write(8 - l + " ");

                for (int c = 0; c < tabuleiro.colunas; c++)
                {

                    if (tabuleiro.Peca(l, c) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Tela.ImprimirPeca(tabuleiro.Peca(l, c));
                        Console.Write(" ");
                        //Console.Write(tabuleiro.Peca(l, c) + " ");
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine("\n   A  B  C  D  E  F  G  H");

        }



        public static void ImprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            } else
            {
                ConsoleColor cor = ConsoleColor.Black;

                switch(peca.cor.ToString())
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
}
