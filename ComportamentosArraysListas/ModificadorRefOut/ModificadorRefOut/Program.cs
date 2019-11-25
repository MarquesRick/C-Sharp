using System;

namespace ModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando REF: 
            //• Conclusão: ambos são muito similares, mas ref é uma forma de fazer
            //o compilador obrigar o usuário a iniciar a variável.
            //• Nota: ambos são considerados "code smells"(design ruim) e devem
            //ser evitados.

            int a = 10;
            Calculatos.Triple1(ref a);
            Console.WriteLine(a);

            //Utilizando Out:
            //O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável
            //original), mas não exige que a variável original seja iniciada.
            int b = 10;
            int c;
            Calculatos.Triple2(b, out c);
            Console.WriteLine(c);
            

        }
    }
}
