using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Auxiliar
    {
        public int CalculaIdade(DateTime data)
        {
            var hoje = DateTime.Today;

            var a = (hoje.Year * 100 + hoje.Month) * 100 + hoje.Day;
            var b = (data.Year * 100 + data.Month) * 100 + data.Day;

            return (a - b) / 10000;
        }

        public string FaixaEtaria(int idade)
        {
            string faixa;
            switch (idade)
            {
                case int i when (i <= 11):
                    faixa = "criança";
                    break;
                case int i when (i > 11 && i <= 21):
                    faixa = "jovem";
                    break;
                case int i when (i > 21 && i <= 59):
                    faixa = "adulto";
                    break;
                default:
                    faixa = "idoso";
                    break;
            }

            return faixa;

            
        }

    }
}
