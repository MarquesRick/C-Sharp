using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Adicionando elementos.. add por padrão insere no final da lista
            list.Add("Maria");
            list.Add("Henrique");
            list.Add("Claudio");
            list.Add("Ana");
            list.Add("Bob");
            //Insert: pode definir em qual posição sera add
            list.Insert(2, "Marques");//Adicionado na posição 2
            list.Insert(5, "Amanda");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //list.count = Mostra o tamando da lista
            Console.WriteLine("List Count: " + list.Count);

            //Predicado é uma função (assunto de Lambda) - Pega um valor e retorna verdadeiro ou falso de acordo com a função
            //Find = encontra na lista de acordo com o parametro
            string find = list.Find(x => x[0].Equals('A'));//Expressão Lambda. x tal que na posição 0 encontre o primeiro caracter 'A';
            Console.WriteLine(find);
            string findLast = list.FindLast(x => x[0].Equals('A'));//encontra a ultima expressão que tenha o A como primeiro caracter;
            Console.WriteLine(findLast);
            int findIndex = list.FindIndex(x => x[0].Equals('A'));//Mostra a posição do primeiro objeto que tem a letra A inicial
            Console.WriteLine(findIndex);
            int findLIndex = list.FindLastIndex(x => x[0].Equals('A'));//Mostra qual a ultima posição que tem a letra A inicial
            Console.WriteLine(findLIndex);
            List<string> list2 = list.FindAll(x => x.Length == 5);//Mostra todos que contenha um length de 5 caracteres
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------------------------------------------------");

            //Remove
            list.Remove("Bob");//Remove da lista os caracteres informados;
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');//Remove todos que contenham M como primeiro caracter do nome;
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(0);//Remove o elemento de acordo com a posição passada;
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(0, 2);//Remove da faixa de acordo com a posição passada e a contagem de quantos serão removidos;
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
