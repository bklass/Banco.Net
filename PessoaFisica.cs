using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        private readonly int Idade;
        private readonly string FaixaEtaria;
        public double Renda { get; set; }

        public PessoaFisica (string Nome, string Sobrenome, string Rg, string Cpf, DateTime DataNasc,  double Renda)
        {
            Auxiliar aux = new Auxiliar();
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Rg = Rg;
            this.Cpf = Cpf;
            this.DataNasc = DataNasc;
            this.Idade = aux.CalculaIdade(this.DataNasc);
            this.FaixaEtaria = aux.FaixaEtaria(this.Idade);
            this.Renda = Renda;
        }


    }
}
