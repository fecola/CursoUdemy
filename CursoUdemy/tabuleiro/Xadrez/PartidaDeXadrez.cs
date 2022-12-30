using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {

        public Tabuleiro tabuleiro { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }



        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }



        public void ExecutaMovimento(Posicao posicaoOrigem, Posicao posicaoDestino)
        {

            Peca p = tabuleiro.RetirarPeca(posicaoOrigem);
            p.IncrementarQuantidadeMovimento();


            Peca pecaCapturada = tabuleiro.RetirarPeca(posicaoDestino);
            tabuleiro.ColocarPeca(p, posicaoDestino);

        }



        private void ColocarPecas()
        {

            // Peças Brancas
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Rainha(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('a', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('b', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('f', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('g', 2).ToPosicao());
            //tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('h', 2).ToPosicao());


            // Peças Coloridas
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('a', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('h', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('b', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('g', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('f', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Rainha(tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('a', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('b', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('f', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('g', 7).ToPosicao());
            tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('h', 7).ToPosicao());

        }

    }
}
