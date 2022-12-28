using CursoUdemy.Exceptions;


namespace CursoUdemy
{
    internal class Tabuleiro
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;



        public Tabuleiro (int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Colunas, Linhas];
        }



        public Peca Peca (Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public Peca Peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }



        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);

            return Peca(posicao) != null;
        }


        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }


        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna <= Colunas)
            {
                return false;
            }

            return true;
        }


        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posicao inválida");
            }
        }

    }
}
