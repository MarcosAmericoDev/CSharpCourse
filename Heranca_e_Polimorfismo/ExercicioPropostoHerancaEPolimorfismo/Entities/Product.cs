using System.Globalization;

namespace ExercicioPropostoHerancaEPolimorfismo.Entities
{
    internal class Product
    {
        // Auto properts
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructors
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Methods

        public virtual string PriceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
