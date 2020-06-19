using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Product() { }
        public Product(string name, double unitPrice, int quantite)
        {
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantite;
        }

        public double Total()
        {
            return UnitPrice * Quantity;
        }
    }
}
