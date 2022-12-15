using CursoUdemy.Entities.ENUMs;

namespace CursoUdemy.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }


        public Worker (string nome, WorkerLevel level, double salario)
        {
            Name = nome;
            Level = level;
            BaseSalary = salario;
        }


        public void AddContract (HourContract hourContract)
        {

        }

        public void RemoveContract (HourContract hourContract)
        {

        }

        public double Income (int year, int month)
        {

        }

    }
}
