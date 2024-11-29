﻿using EstudoDelegatesAction.Entities;
using System.Net.NetworkInformation;

namespace EstudoDelegatesAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
    }
}
