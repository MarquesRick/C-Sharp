using System;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //Forma para delimitar duas casas decimais
            Console.WriteLine(x.ToString("F4")); //Forma para delimitar quatro casas decimais
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //Forma para desconsiderar formatação especifica do país
                                                                               //(na qual sua maquina está rodando) usa o '.' ao invés da ','.

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            //Placehoder
            Console.WriteLine("A paciente {0} tem {1} anos e seu saldo eh: {2:F2}", z, y, x); //{2:F2} forma para trazer a segunda variável delimitando as casas decimais. Essa forma não possui o globalization
            //Interpolação
            Console.WriteLine($"A paciente {z} tem {y} anos e seu saldo eh: {x:F2}"); //{x:F2} forma para trazer a segunda variável delimitando as casas decimais. Essa forma não possui o globalization
            //Concatenação
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu saldo eh: " + x.ToString("F2", CultureInfo.InvariantCulture)); //Essa forma possui o globalization

            Console.ReadLine();
        }
    }
}