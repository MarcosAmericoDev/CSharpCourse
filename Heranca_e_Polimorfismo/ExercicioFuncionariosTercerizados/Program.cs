using ExercicioFuncionariosTercerizados.Entities;
using System.Globalization;

namespace ExercicioFuncionariosTercerizados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int nEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nEmployee; i++) 
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                Char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string tempName = Console.ReadLine();
                Console.Write("Hours worked: ");
                int tempHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double tempValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y') 
                {
                    Console.Write("Addicional charge: ");
                    double tempAddicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfEmployees.Add(new OutSourcedEmployee(tempName, tempHours, tempValuePerHour, tempAddicionalCharge));
                } 
                else
                {
                    listOfEmployees.Add(new Employee(tempName, tempHours, tempValuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in listOfEmployees)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }
    }
}
