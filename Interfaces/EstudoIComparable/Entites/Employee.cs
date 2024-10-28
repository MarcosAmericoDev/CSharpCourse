using System.Globalization;

namespace EstudoIComparable.Entites
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Employee emp)
        {
            return Name.CompareTo(emp.Name);
        }
    }
}
