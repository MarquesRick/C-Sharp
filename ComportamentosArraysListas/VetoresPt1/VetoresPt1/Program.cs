using System;
using System.Globalization;

namespace VetoresPt1
{
//    Fazer um programa para ler um número inteiro N e a altura de N pessoas
//    Armazene as N alturas em um vetor.Em seguida, mostrar a altura média dessas
//    pessoas.
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //declaracao de vetor
            double[] vect = new double[n];

            for(int i = 0; i<n; i++)
            {
                //Tudo o que o usuário digitar vai ser armazenado nas posições do vetor;
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //mostrar média das alturas
            double sum = 0.0;

            //mostrar média das alturas
            for (int i = 0; i < n; i++)
            {
                sum += vect[i]; 
            }

            double avg = sum / n;

            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2")}");
        }
    }
}
