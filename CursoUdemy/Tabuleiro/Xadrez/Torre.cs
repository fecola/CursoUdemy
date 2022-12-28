using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Torre : Peca
    {

        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }


        public override string ToString()
        {
            return " T";
        }

    }
}
