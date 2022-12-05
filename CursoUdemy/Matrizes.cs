using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    static class Matrizes
    {

        public static CheckValor (int[,] matriz, int numero)
        {
            for(int linha = 0; linha < matriz.Length; linha++)
            {
                for (int coluna = 0; coluna < matriz.Length; coluna++)
                {
                    if (matriz[linha, coluna] == numero)
                    {

                    }
                }
            }
        }

    }
}
