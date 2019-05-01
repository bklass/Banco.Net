using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaPoupanca : Conta, Depositavel
    {
        public ContaPoupanca(Pessoa Titular, long Numero, int Agencia, double Saldo, double TaxaSaque):base(Titular, Numero, Agencia, Saldo, TaxaSaque)
        {

        }

        public override void Sacar(double valor)

        {
            double saldo = ConsultarSaldo();
            double newValor = valor + TaxaSaque;
            if (saldo >= newValor)
            {
                base.Sacar(newValor);
            }
            else
                Console.WriteLine("Saldo Insuficiente");
        }

        public override void Transferir(Conta conta, double valor)
        {
            if (ConsultarSaldo() >= valor)
            {
                base.Transferir(conta, valor);
            }
            else
                Console.WriteLine("Saldo Insuficiente");
        }



        public void Depositar(double valor)
        {
            Sacar(-valor - TaxaSaque);
        }


    }
}
