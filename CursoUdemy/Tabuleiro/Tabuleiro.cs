using CursoUdemy.Exceptions;


namespace CursoUdemy
{
    internal class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;



        public Tabuleiro (int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[this.colunas, this.linhas];
        }



        public Peca Peca (Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
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
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }

            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }


        public Peca RetirarPeca (Posicao posicao)
        {

            if (Peca(posicao) == null)
            {
                return null;
            }

            Peca aux = Peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;

            return aux;

        }


        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
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
