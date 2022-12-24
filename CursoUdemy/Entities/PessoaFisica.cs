namespace CursoUdemy.Entities
{
    internal class PessoaFisica : Person
    {

        public double GastoComSaude { get; set; }


        public PessoaFisica (string nome, double rendaAnual, double gastoComSaude) : base (nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }



        public override double CalcularRendaAnual()
        {

            double valor;
            
            if (RendaAnual <= 20000.00)
            {
                valor = RendaAnual * 0.15;

            } else
            {
                valor = RendaAnual * 0.25;

            }

            if (GastoComSaude > 0)
            {
                valor -= GastoComSaude * 0.5;
            }

            return valor;

        }
    }
}
