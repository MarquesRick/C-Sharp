using System;

namespace ExemploCriacaoDeStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; //Não necessário definir com new Point();
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p); //Necessário inicializar a variavel acima senão o sistema não permite o uso.

            p = new Point();
            Console.WriteLine(p);
        }

    }
}
