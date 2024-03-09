using ExercicioPropostoHerancaEPolimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoHerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #1 data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch(typeOfProduct) 
                {
                    case 'i':
                        Console.Write("Costums fee: ");
                        double productCostumsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        listOfProducts.Add(new ImportedProduct(productName, productPrice, productCostumsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime productManufactureDate = DateTime.Parse(Console.ReadLine());
                        listOfProducts.Add(new UsedProduct(productName, productPrice, productManufactureDate));
                        break;
                    default:
                        listOfProducts.Add(new Product(productName, productPrice));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in listOfProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
