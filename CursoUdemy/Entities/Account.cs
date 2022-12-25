using CursoUdemy.Entities.Exceptions;

namespace CursoUdemy.Entities
{
    internal class Account
    {

        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }



        public Account() { }

        public Account(int numberAccount, string holder, double balance, double withdrawLimit)
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }



        public double CheckBalance()
        {
            return Balance;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void WithDraw (double amount)
        {

            if (amount > Balance)
            {
                throw new AccountException("Saldo insuficiente para saque!");

            }

            if (amount > WithdrawLimit)
            {
                throw new AccountException("Valor excede o limite permitido para saque!");
            }

            Balance -= amount;

        }

    }
}
