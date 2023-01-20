namespace CursoUdemy.Entities
{
    internal class Contract
    {

        public int Number { get; set; }
        public DateTime Data { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments = new List<Installment>();

    }
}
