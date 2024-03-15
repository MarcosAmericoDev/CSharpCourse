using ExercicioPropostoExceções.Entities.Exceptions;

namespace ExercicioPropostoExceções.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number <=0)
            {
                throw new DomainExceptions("The account's number can't be a 0 or negative number");
            }
            if (string.IsNullOrEmpty(holder) || string.IsNullOrWhiteSpace(holder))
            {
                throw new DomainExceptions("The holder's name is null or empty");
            }
            if (balance < 0 || withdrawLimit <= 0)
            {
                throw new DomainExceptions("The balance can't be a negative number or withdraw cant be a 0 or negative number");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount) 
        { 
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
