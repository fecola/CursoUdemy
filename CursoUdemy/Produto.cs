using System;
using System.Globalization;

namespace CursoUdemy
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int qtd)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = qtd;
        }

        public double ValorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidade(s)" + ", Total: " + ValorTotalEmEstoque().ToString("F2");
        }

    }
}
