using System;
using System.Globalization;

namespace PrimeirosExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("-------------Exercicio Pessoa-------------\n");

            Console.WriteLine("Digite seu nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("A idade de {0} é maior que a idade de {1}", p1.nome, p2.nome);
            }
            else
            {
                Console.WriteLine("A idade de {0} é maior que a idade de {1}", p2.nome, p1.nome);
            }

            Console.WriteLine("\n-------------Exercicio Funcionario-------------\n");

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite seu nome: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Digite seu salario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Digite seu salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("A media dos salarios é: " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
