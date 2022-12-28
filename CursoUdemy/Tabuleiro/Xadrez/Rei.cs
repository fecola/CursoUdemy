using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }


        public override string ToString()
        {
            return "R";
        }
    }
}
