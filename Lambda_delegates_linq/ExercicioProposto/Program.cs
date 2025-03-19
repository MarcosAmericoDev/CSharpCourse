using ExercicioProposto.Entities;
using System.Globalization;
namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string source = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(source)) 
            {
                while (!sr.EndOfStream) 
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee { Name = name, Email = email, Salary = salary});
                }
            }

            Console.WriteLine($"Email of people whose salary is more than {salaryBase.ToString("F2", CultureInfo.InvariantCulture)}");
            var employeesBaseSalary = employees.Where(e => e.Salary >= salaryBase).Select(e => e.Email);
            foreach (var employee in employeesBaseSalary)
            {
                Console.WriteLine(employee);
            }

            var salarySum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salarySum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
