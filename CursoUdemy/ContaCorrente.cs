using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    internal class ContaCorrente
    {

        private int _numConta;
        private string _nomeTitular;
        private double _saldo;


        public ContaCorrente (string nomeTitular)
        {
            _nomeTitular = nomeTitular;
        }

        public ContaCorrente (string nomeTitular, double saldo)
        {
            _nomeTitular = nomeTitular;
            _saldo = saldo;
        }


        public void Depositar (double valor)
        {
            _saldo += valor;
        }

        public void Sacar (double valor)
        {
            double taxaSaque = 5.00;

            _saldo = _saldo - valor - taxaSaque;
        }


        public override string ToString()
        {
            return "Conta: " + _numConta + ", Titular: " + _nomeTitular + ", Saldo: R$" + _saldo.ToString("F2");
        }

    }

}
