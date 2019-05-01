using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaSalario : Conta
    {
        public ContaSalario(Pessoa Titular, long Numero, int Agencia, double Saldo, double TaxaSaque) : base(Titular, Numero, Agencia, Saldo, TaxaSaque)
        {

        }

        public override void Sacar(double valor)

        {
            double saldo = ConsultarSaldo();
            if (saldo >= valor) {
                base.Sacar(valor);
            } else
                Console.WriteLine("Saldo Insuficiente");
        }


        public override void Transferir(Conta conta, double valor)
        {
            if (conta.Titular == this.Titular)
            {
                if (ConsultarSaldo() >= valor)
                {
                    base.Transferir(conta, valor);
                }
                else
                    Console.WriteLine("Saldo Insuficiente");
            }
            else
                Console.WriteLine("Não foi possível fazer a transferência");
        }
    }
}
