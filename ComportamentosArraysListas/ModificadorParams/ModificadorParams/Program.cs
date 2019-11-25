using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3); //Sem o params teriamos que instanciar as variaveis.
            //Forma sem Params: int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
        }
    }
}
