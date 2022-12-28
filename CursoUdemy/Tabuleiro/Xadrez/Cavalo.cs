using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo (Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }


        public override string ToString()
        {
            return "C";
        }

    }
}
