using CursoUdemy.Enum;

namespace CursoUdemy
{
    internal class Peca
    {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; } // Usada para controlar movimentação dos peões
        public Tabuleiro Tabuleiro { get; protected set; }



        public Peca (Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QuantidadeMovimentos = 0;
        }

    }
}
