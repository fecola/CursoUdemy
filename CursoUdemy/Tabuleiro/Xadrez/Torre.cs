using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Torre : Peca
    {

        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }


        private bool PodeMover(Posicao posicao)
        {
            Peca p = tabuleiro.Peca(posicao);

            return p == null || p.cor != this.cor;
        }


        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);


            // Para cima
            pos.DefinirPosicaoDestino(posicao.linha - 1, posicao.coluna);

            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }

                pos.linha = pos.linha - 1;
            }

            // Para baixo
            pos.DefinirPosicaoDestino(posicao.linha + 1, posicao.coluna);

            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }

                pos.linha = pos.linha + 1;
            }

            // Para direita
            pos.DefinirPosicaoDestino(posicao.linha, posicao.coluna + 1);

            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }

                pos.coluna = pos.coluna + 1;
            }

            // Para esquerda
            pos.DefinirPosicaoDestino(posicao.linha, posicao.coluna - 1);

            while (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                if (tabuleiro.Peca(pos) != null && tabuleiro.Peca(pos).cor != cor)
                {
                    break;
                }

                pos.coluna = pos.coluna - 1;
            }

            return mat;

        }

        public override string ToString()
        {
            return " T";
        }

    }
}
