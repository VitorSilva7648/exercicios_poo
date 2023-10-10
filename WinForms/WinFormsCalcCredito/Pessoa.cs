using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalcCredito
{
    public abstract class Pessoa
    {
        protected string nome;
        protected string cidade;

        protected Pessoa(string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public abstract double CalcCred();
    }
}

