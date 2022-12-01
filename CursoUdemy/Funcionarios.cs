namespace CursoUdemy
{
    internal class Funcionarios
    {

        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }


        public Funcionarios (int id, string nome, double salario)
        {
            this.ID = id;
            this.Nome = nome;
            this.Salario = salario;
        }



        public void AumentarSalario (double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString()
        {
            return "ID: " + ID + ", Nome Funcionário: " + Nome + ", Salário: R$" + Salario.ToString("F2");
        }

    }
}
