using CursoUdemy.Entities.ENUMs;

namespace CursoUdemy.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker (string nome, WorkerLevel level, double salario, Department dept)
        {
            Name = nome;
            Level = level;
            BaseSalary = salario;
            Department = dept;
        }


        public void AddContract (HourContract hourContract)
        {
            Contracts.Add(hourContract);
        }

        public void RemoveContract (HourContract hourContract)
        {
            Contracts.Remove(hourContract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Data.Month == month && contract.Data.Year == year)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;

        }


    }
}
