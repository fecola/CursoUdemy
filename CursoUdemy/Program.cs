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
                PartidaDeXadrez partida = new PartidaDeXadrez();


                while(!partida.terminada)
                {

                    Console.Clear();

                    Tela.ImprimirTabuleiro(partida.tabuleiro);

                    Console.WriteLine("\n");
                    Console.Write("Origem: ");
                    Posicao posicaoOrigem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.tabuleiro.Peca(posicaoOrigem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);

                    Console.WriteLine("\n");
                    Console.Write("\nDestino: ");
                    Posicao posicaoDestino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(posicaoOrigem, posicaoDestino);

                }

            }
            catch (TabuleiroException error)
            {
                Console.WriteLine(error.Message);

            }

        }

    }
}
