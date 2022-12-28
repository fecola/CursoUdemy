using Xadrez;
using CursoUdemy.Enum;
using CursoUdemy.Exceptions;

namespace CursoUdemy
{
    internal class Program
    {

        public static void Main(String[] args)
        {

            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Vermelha), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Verde), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Laranja), new Posicao(2, 4));
                tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0, 6));

                Tela.ImprimirTabuleiro(tabuleiro);

                Console.WriteLine();

            }
            catch (TabuleiroException error)
            {
                Console.WriteLine(error.Message);

            }

        }

    }
}
