using ExercicioPropostoExceções.Entities;
using ExercicioPropostoExceções.Entities.Exceptions;
using System.Globalization;

namespace ExercicioPropostoExceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                acc.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

            } 
            catch (DomainExceptions error)
            {
                Console.WriteLine($"Error in create account: {error.Message}");
            }
            catch (FormatException error)
            {
                Console.WriteLine($"Format error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Unexpected error: {error.Message}");
            }
        }
    }
}
