using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
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


            //Para cima
            pos.DefinirPosicaoDestino(posicao.linha - 1, posicao.coluna);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para nordeste
            pos.DefinirPosicaoDestino(posicao.linha - 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para leste
            pos.DefinirPosicaoDestino(posicao.linha, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para sudeste
            pos.DefinirPosicaoDestino(posicao.linha + 1, posicao.coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para sul
            pos.DefinirPosicaoDestino(posicao.linha + 1, posicao.coluna );
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para sudoeste
            pos.DefinirPosicaoDestino(posicao.linha + 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para oeste
            pos.DefinirPosicaoDestino(posicao.linha, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Para noroeste
            pos.DefinirPosicaoDestino(posicao.linha - 1, posicao.coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;

        }

        public override string ToString()
        {
            return " R";
        }
    }
}
