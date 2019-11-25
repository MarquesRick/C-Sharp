using System;

namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Clients[] vect = new Clients[10];

            Console.WriteLine("Digite o numero de quartos que serão alugados");
            int qnt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qnt; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");   
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Clients(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");      
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
