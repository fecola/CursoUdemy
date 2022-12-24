using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.Entities
{
    internal class PessoaJuridica : Person
    {

        public int QuantidadeFuncionarios { get; set; }


        public PessoaJuridica(string nome, double rendaAnual, int qtdFuncionarios) : base (nome, rendaAnual)
        {
            QuantidadeFuncionarios = qtdFuncionarios;
        }


        public override double CalcularRendaAnual()
        {

            double valor;
            
            if (QuantidadeFuncionarios < 10)
            {
                valor = RendaAnual * 0.16;

            } else
            {
                valor = RendaAnual * 0.14;

            }

            return valor;

        }
    }
}
