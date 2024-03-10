using ExercicioPropostoMetodosAbstratos.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> listOfTaxPayers = new List<TaxPayer>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char typeOfTaxPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nameOfTaxPayer = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncomeOfTaxPayer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (typeOfTaxPayer)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthExpendituresOfTaxPayer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        listOfTaxPayers.Add(new Individual(nameOfTaxPayer, annualIncomeOfTaxPayer, healthExpendituresOfTaxPayer));
                        break;

                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberOfEmployeesOfTaxPayer = int.Parse(Console.ReadLine());
                        listOfTaxPayers.Add(new Company(nameOfTaxPayer, annualIncomeOfTaxPayer, numberOfEmployeesOfTaxPayer));
                        break;
                    default: 
                        Console.WriteLine("Type of tax payer incorrect");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach(TaxPayer taxPayer in listOfTaxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.CalculatTax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPayer.CalculatTax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
