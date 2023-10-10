using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalcCredito
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private int qtdFun;
        private double faturamento;
        private string nomeFantasia;

        public PessoaJuridica(string cnpj, string nome, string cidade, int qtdFun, double faturamento, string nomeFantasia) : base(nome, cidade)
        {
            this.cnpj = cnpj;
            this.qtdFun = qtdFun;
            this.faturamento = faturamento;
            this.nomeFantasia = nomeFantasia;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int QtdFun { get => qtdFun; set => qtdFun = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }

        public override double CalcCred()
        {
            double credito;
            credito = (faturamento * 12) + (qtdFun * 10);
            return credito;
        }
    }
}   
