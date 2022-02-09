using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidades
{
    public abstract class Conta
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public abstract double Rendimento();

        public override string ToString()
        {
            return $"Número da conta: {Numero} | Titular: {Titular} | Saldo: ${Saldo:n2}";
        }
    }
}
