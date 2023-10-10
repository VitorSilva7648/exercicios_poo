using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Threading.Tasks;

namespace WinFormsBanco
{
    class Pessoa
    {
        private string cpf;
        private string nome;
        private double salario;

        public Pessoa(string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }


        public double CalcCred()
        {
            return salario * 6;
        }

    }
}
