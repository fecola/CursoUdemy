﻿using CursoUdemy;
using CursoUdemy.Enum;

namespace Xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return " B";
        }

    }
}
