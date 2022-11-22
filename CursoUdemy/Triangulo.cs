using System;

namespace CursoUdemy
{

    internal class Triangulo
    {

        public double A;
        public double B;
        public double C;


        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return raiz;
        }

    }

}
