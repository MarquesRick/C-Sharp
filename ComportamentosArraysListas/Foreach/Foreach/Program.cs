using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect1 = new string[] { "Maria", "Bob", "Alex" };
            for(int i = 0; i < vect1.Length; i++)
            {
                Console.WriteLine(vect1[i]);
            }
            Console.WriteLine("----------------------------------");

            //Mais simples utilizar foreach
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
