using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class PessoaJudirica : Pessoa
    {
        public List<PessoaFisica> Socios { get; set; }
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int InscrEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        private readonly int Idade;
        public double Faturamento { get; set; }

        public PessoaJudirica(List <PessoaFisica> Socios, int Cnpj, string RazaoSocial, string NomeFantasia, int InscrEstadual, DateTime DataAbertura,  double Faturamento)
        {
            Auxiliar aux = new Auxiliar();
            this.Socios = Socios;
            this.Cnpj = Cnpj;
            this.RazaoSocial = RazaoSocial;
            this.NomeFantasia = NomeFantasia;
            this.InscrEstadual = InscrEstadual;
            this.DataAbertura = DataAbertura;
            this.Idade = aux.CalculaIdade(this.DataAbertura);
            this.Faturamento = Faturamento;
        }




    }
}
