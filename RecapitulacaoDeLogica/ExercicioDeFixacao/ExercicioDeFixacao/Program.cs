using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char sexo = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("\n------------------------------Utilizando Interpolação------------------------------\n");

            Console.WriteLine($"Produtos\n{produto1}, cujo preço eh de: ${preco1:F2}\n{produto2}, cujo preço eh de: ${preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro\n{idade} anos de idade, codigo {codigo} e gênero: {sexo}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida}\nArredondado(3 casas decimais): {medida:F3}\nSeparador decimal invariante culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
