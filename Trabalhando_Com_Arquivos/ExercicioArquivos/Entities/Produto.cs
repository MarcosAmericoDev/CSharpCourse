using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivos.Entities
{
    class Produto
    {

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int QuantityInStorage { get; private set; }

        public Produto(string name, double price, int quantityInStorage)
        {
            Name = name;
            Price = price;
            QuantityInStorage = quantityInStorage;
        }

        public double TotalPrice()
        {
            return Price * QuantityInStorage;
        }
    }
}
