using CursoUdemy;

namespace Xadrez
{
    internal class PosicaoXadrez
    {

        public char coluna { get; set; }
        public int linha { get; set; }


        public PosicaoXadrez (char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }



        public Posicao ToPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
            /* 
             * ao subtrair coluna por um char, estou dizendo que vou fazer subtração entre código unicode
             * exemplo: vou digitar que vai para a posição coluna = C e linha = 7.
             * então quando informo a coluna C será feito uma subtração entre c = 99 - a = 97 (TUDO EM UNICODE), o que vai me dar o resultado de 2 que corresponde ao valor na matriz de C
             * "a" será sempre a base de calculo para a coluna, gerando assim o valor da posição coluna na matriz
            */

        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}
