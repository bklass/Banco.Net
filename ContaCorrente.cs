using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta, Depositavel
    {
        private readonly string Tipo;
        private readonly double Limite;
        private readonly double TaxaDoLimite;



        public ContaCorrente(Pessoa Titular, long Numero, int Agencia, double Saldo, double TaxaSaque, string Tipo) : base(Titular, Numero, Agencia, Saldo, TaxaSaque)
        {
            this.Tipo = Tipo;
            double valor = 0;
            if (Titular is PessoaFisica)
            {
                PessoaFisica pf = (PessoaFisica)Titular;
                valor = pf.Renda;
            }
            else
            {
                PessoaJudirica pj = (PessoaJudirica)Titular;
                valor = pj.Faturamento;
            }
            
            if (this.Tipo == "ESPECIAL")
            {
               
                if (valor >= 5000.00 )
                {
                    double lEspecial = (valor * 2.5);
                    this.Limite = lEspecial;
                    double tEspecial = (this.Limite * 0.02);
                    this.TaxaDoLimite = tEspecial;
                }
                else
                    Console.WriteLine("Não atende os requisitos da conta especial");
            }
            else
            {
                double lEspecial = (valor * 1.5);
                this.Limite = lEspecial;
                double tEspecial = (this.Limite * 0.05);
                this.TaxaDoLimite = tEspecial;

            }          
            
        }

        public void Pagar(string codigoBarras, double valorBoleto)
        {
            Sacar(valorBoleto);

        }

        public void Emprestimo(double valor)
        {
            Depositar(valor);
        }


        public override void Sacar(double valor)

        {
            double saldoTotal = (ConsultarSaldo() + Limite);
            double newValor = valor + TaxaSaque;
            if (newValor <= saldoTotal)
            {
                base.Sacar(newValor);
            }
            else
                Console.WriteLine("Saldo Insuficiente");
        }

        public override void Transferir(Conta conta, double valor)
        {
            double saldoTotal = (ConsultarSaldo() + Limite);
            if (saldoTotal >= valor)
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
