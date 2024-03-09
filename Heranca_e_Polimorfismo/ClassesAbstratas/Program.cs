using ClassesAbstratas.Entitites;
using System.Globalization;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> listOfAccounts = new List<Account>();

            listOfAccounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            listOfAccounts.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            listOfAccounts.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            listOfAccounts.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0;

            foreach (Account acc in listOfAccounts)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (Account acc in listOfAccounts)
            {
                acc.Withdraw(10.00);
            }

            foreach (Account acc in listOfAccounts)
            {
                Console.WriteLine($"Saldo atualizado de {acc.Holder}: ${acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
