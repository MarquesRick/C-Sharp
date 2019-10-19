using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------------------Utilizando SPLIT------------------------------\n");

            //Cada ' ' ele salvara os dados em um Array
            Console.WriteLine("Digite seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            string[] n = nomeCompleto.Split(' ');

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"n[{i}]: " + n[i]); //Utilizando Interpolação + concatenação 
            }
            for (int m = n.GetLowerBound(0); m <= n.GetLowerBound(0); m++)
            {
                Console.WriteLine($"Primeiro nome é: {n[m]}");
            }
            for (int j = n.GetUpperBound(0); j <= n.GetUpperBound(0); j++)
            {
                Console.WriteLine($"Ultimo nome é: {n[j]}"); //Utilizando Interpolação + concatenação
                if (n[j].Equals("Marques", StringComparison.OrdinalIgnoreCase)) //IgnoreCase do C#
                {
                    Console.WriteLine("Membro da minha familia");
                }
                else
                {
                    Console.WriteLine("Não é membro da minha familia");
                }
            }

            Console.WriteLine("\n------------------------------Utilizando CAST------------------------------\n");
            //Necessário utiliza para não haver perda de registro, convertendo int para double
            int a = 2;
            int b = 5;
            double c = (double)b / a;
            Console.WriteLine(c);


        }
    }
}
