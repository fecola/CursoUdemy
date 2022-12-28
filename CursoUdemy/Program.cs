using Xadrez;
using CursoUdemy.Enum;
using CursoUdemy.Exceptions;

namespace CursoUdemy
{
    internal class Program
    {

        public static void Main(String[] args)
        {

            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.ToPosicao());

            //try
            //{
            //    Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            //    tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            //    tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            //    tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(8, 0));

            //    Tela.ImprimirTabuleiro(tabuleiro);

            //    Console.WriteLine();

            //} catch (TabuleiroException error)
            //{
            //    Console.WriteLine(error.Message);

            //}

        }

    }
}
