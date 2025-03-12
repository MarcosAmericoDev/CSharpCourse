﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Demo_LINQ_com_Lambda.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, " +
                $"{Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Category.Name}, {Category.Tier}";
        }
    }
}
