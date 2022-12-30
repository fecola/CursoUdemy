using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Rainha : Peca
    {
        public Rainha (Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return " D";
        }

    }
}
