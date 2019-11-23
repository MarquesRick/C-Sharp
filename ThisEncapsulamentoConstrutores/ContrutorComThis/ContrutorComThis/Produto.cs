using System;
using System.Collections.Generic;
using System.Text;

namespace ContrutorComThis
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {
            Quantidade = 10;
        }

        //Forma para reaproveitar o construtor padrão, mantendo o Quantidade = 10
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Forma para reaproveitar o construtor de 2 argumentos, não sendo necessário referenciar novamente os atributos
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}
