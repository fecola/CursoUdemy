namespace CursoUdemy.Entities
{
    internal abstract class Person
    {

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        
        
        public Person (string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }



        public abstract double CalcularRendaAnual();

    }
}
