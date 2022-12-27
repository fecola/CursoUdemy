namespace CursoUdemy
{
    internal class Tela
    {

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {

            for (int l = 0; l < tabuleiro.Linhas; l++)
            {

                for (int c = 0; c < tabuleiro.Colunas; c++)
                {
                    if (tabuleiro.Peca(l, c) == null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.Peca(l, c) + " ");
                    }

                }

                Console.WriteLine();

            }

        }

    }
}
