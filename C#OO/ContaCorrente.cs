using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OO
{
	public class ContaCorrente
	{
        public int Agencia { get; set; }
        public string Conta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor) 
        {
            Saldo -= valor;
        }
    }
}
