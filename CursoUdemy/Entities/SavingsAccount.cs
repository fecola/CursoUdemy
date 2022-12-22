namespace CursoUdemy.Entities
{
    internal class SavingsAccount : Account
    {
        public double InteresetRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InteresetRate = interestRate;
        }


        public void UpdateBalance ()
        {
            Balance += Balance * InteresetRate;
        }

    }
}
