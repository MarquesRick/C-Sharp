using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            p.SetNome(Console.ReadLine());
            p.GetNome();
         
            Console.WriteLine(p);

        }
    }
}
