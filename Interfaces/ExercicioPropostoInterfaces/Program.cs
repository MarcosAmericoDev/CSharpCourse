
using ExercicioPropostoInterfaces.Entites;
using ExercicioPropostoInterfaces.Services;
using System.Globalization;

namespace ExercicioPropostoInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);

            Console.Write("Enter number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PayPalPayment());
            contractService.ProcessContract(contract, numInstallments);

            Console.WriteLine("Installments:");
            for (int i = 0; i < numInstallments; i++)
            {
                Console.WriteLine(contract.Installments[i]);
            }
        }
    }
}
