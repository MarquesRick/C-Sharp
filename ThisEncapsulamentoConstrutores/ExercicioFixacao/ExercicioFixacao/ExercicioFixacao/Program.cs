using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do Titular");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicia (S/N)?");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp.Equals('s'))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
