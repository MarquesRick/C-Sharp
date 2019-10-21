using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Utilizando IF/ELSE----------");

            double a, b, c, delta, x1, x2;

            Console.WriteLine("Digite o valor de A, B e C separados por espaço...");
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }   
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }


            Console.WriteLine("----------Utilizando WHILE----------");

            Console.Write("Digite um numero:");
            double numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            while(numero >= 0.0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero:");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Numero Negativo...");

            Console.WriteLine("----------Utilizando FOR----------");

            Console.Write("Digite o numero de inteiros que voce irá digitar:");

            int soma = 0;
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}:", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");

        }
    }
}
