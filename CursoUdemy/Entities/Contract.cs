namespace CursoUdemy.Entities
{
    internal class Contract
    {

        public int Number { get; set; }
        public DateTime Data { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set;}



        public Contract (int number, DateTime date, double totalValue)
        {
            Number = number;
            Data = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }


        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
