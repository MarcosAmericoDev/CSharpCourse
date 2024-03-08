using Heranca.Entitites;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200);
            Account acc3 = new SavingsAccount(1004, "Robson", 0.00, 300);

            // DOWNCASTING (Tipo inseguro = estudar o
            // caso para saber se precisa da utilização)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            if(acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de converter
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!!");
            }
        }
    }
}
