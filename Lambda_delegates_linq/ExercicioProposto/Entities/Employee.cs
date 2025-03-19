using System.Globalization;

namespace ExercicioProposto.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email:{Email}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
