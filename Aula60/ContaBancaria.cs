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
        public string NumeroConta;
        public string Titular;
        public double Saldo;

        public void Depositar(double valor)
        {

            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo.ToString("F2") + " R$");
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", " + "Titular: " + Titular + ", ";
        }
    }
}

