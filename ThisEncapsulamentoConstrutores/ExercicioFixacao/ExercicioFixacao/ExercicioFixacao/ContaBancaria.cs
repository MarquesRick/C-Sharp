using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }      
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular; 
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) //Método para reutilizar o construtor padrão criado acima
        {
            Deposito(depositoInicial);
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0; //desconta a quantia e R$5
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
