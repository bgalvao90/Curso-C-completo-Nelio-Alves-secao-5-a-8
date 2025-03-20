using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula60
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;

        }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Depositar(depositoInicial);

        }




        public void Depositar(double valor)
        {

            Saldo += valor;
        }


        public void Sacar(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.0;

        }


        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", " + "Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}

