namespace CursoUdemy.Entities
{
    internal class Account
    {
        public int NumAccount { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account() { }

        public Account(int numAccount, string holder, double balance)
        {
            NumAccount = numAccount;
            Holder = holder;
            Balance = balance;
        }


        public void Withdraw (double amount)
        {
            Balance -= amount;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}
