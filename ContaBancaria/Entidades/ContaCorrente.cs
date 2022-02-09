using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidades
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double Rendimento()
        {
            return Saldo * 0.05;
        }
    }
}
