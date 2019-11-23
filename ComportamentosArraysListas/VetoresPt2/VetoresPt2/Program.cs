using System;
using System.Globalization;
namespace VetoresPt2
{
//    Fazer um programa para ler um número inteiro N e os dados(nome e
//preço) de N Produtos.Armazene os N produtos em um vetor.Em
//seguida, mostrar o preço médio dos produtos.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero de produtos:");
            int n = int.Parse(Console.ReadLine());

            //Definindo vetor da classe produtos
            Product[] vector = new Product[n];

            for(int i = 0; i < n; i++)
            {
                //Nesta caso é necessário instanciar o Product
                Console.WriteLine("Entre com nome do produto:");
                string name = Console.ReadLine();
                Console.WriteLine("Entre com o preço do produto:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Metodo de instanciar sem construtor: vector[i] = new Product { Name = name, Price = price };
                vector[i] = new Product (name, price);
            }

            double sum = 0.0;
            //Metodo para somar todos os preços;
            for(int i = 0; i < n; i++)
            {
                sum += vector[i].Price; //Forma para acessar o atributo Price de Product
            }

            double avg = sum / n;
            Console.WriteLine($"SUM PRICE = {sum.ToString("F2")}");
            Console.WriteLine($"AVARAGE PRICE = {avg.ToString("F2")}");
            Console.WriteLine(  );
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNome do produto: " + vector[i].Name + "\nPreço do produto: " +  vector[i].Price);
                
            }
           
        }
    }
}
