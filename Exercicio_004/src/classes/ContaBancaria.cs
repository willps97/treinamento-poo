using System;
using System.Globalization;


namespace Exercicio_004.src.classes
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + Numero
                    + " , Titular: " + Titular
                    + " , Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
