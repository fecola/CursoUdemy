using CursoUdemy.Enum;

namespace CursoUdemy
{
    internal class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; } // Usada para controlar movimentação dos peões
        public Tabuleiro tabuleiro { get; protected set; }



        public Peca (Tabuleiro tabuleiro, Cor cor)
        {
            posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            quantidadeMovimentos = 0;
        }

    }
}
