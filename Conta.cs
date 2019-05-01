using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    abstract class Conta
    {
        public Pessoa Titular;
        public long Numero;
        public int Agencia;
        private double Saldo;
        public double TaxaSaque { get; private set; }

        public Conta (Pessoa Titular, long Numero, int Agencia, double Saldo, double TaxaSaque)
        {
            this.Titular = Titular;
            this.Numero = Numero;
            this.Agencia = Agencia;
            this.Saldo = Saldo;
            this.TaxaSaque = TaxaSaque;

        }

        public virtual void Sacar (double valor)
        {
            this.Saldo -= valor;
        }

        public double ConsultarSaldo()
        {
            return Saldo;
        }

        public virtual void Transferir(Conta conta, double valor)
        {
            this.Saldo -= valor;
            conta.Saldo += valor;
        }
  

    }
}
