using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma para definir Nullable desta forma o valor aceira null;
            Nullable<double> x = null;

            //Forma simplificada pra aceitar Null
            double? y = null;

            double? z = 10.0;

            //Pega ou o valor ou o valor padrão
            Console.WriteLine(x.GetValueOrDefault());
            //Mostra se a variavel tem valor
            Console.WriteLine(x.HasValue);

            //Evitar exception
            if (y.HasValue)
            {
                //Mostra o valor da variavel. Dá erro se chamar apartir de um objeto null
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("O valor é null");

            }
            if (x.HasValue)
            {
                //Mostra o valor da variavel. Dá erro se chamar apartir de um objeto null
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("O valor é null");
            } 
            if (z.HasValue)
            {
                //Mostra o valor da variavel. Dá erro se chamar apartir de um objeto null
                Console.WriteLine(z.Value);
            }
            else
            {
                Console.WriteLine("O valor é null");
            }

            double? i = null;
            //Operador de coalescencia nula: Se o valor de i for nulo ele atribuira o valor 0.9 senão ele atribui o valor de i na variavel m;
            double m = i ?? 0.9;
        }
    }
}
