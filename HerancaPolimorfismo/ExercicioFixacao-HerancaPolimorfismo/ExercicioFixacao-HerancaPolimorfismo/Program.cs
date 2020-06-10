using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioFixacao_HerancaPolimorfismo.Entities;

namespace ExercicioFixacao_HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char c = Char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'c')
                {
                    list.Add(new Product(name, price));
                } 
                else if(c == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct (name, price, date));
                }
                else
                {
                    Console.WriteLine("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.ReadLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
