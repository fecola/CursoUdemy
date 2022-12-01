using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    internal class ConversorDeMoeda
    {

        public static double IOF = 0.06;


        public static double CalcularCotacao (double valorDolar, double quantidade)
        {
            double valor = valorDolar * quantidade;

            return valor + (valor * IOF);
        }

    }
}
