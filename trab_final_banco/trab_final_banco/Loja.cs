using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final_banco
{
    class Loja
    {
        private string cidade;
        private int ano;
        private int qntFuncionario;

        public Loja(string cidade, int ano, int qntFuncionario)
        {
            this.cidade = cidade;
            this.ano = ano;
            this.qntFuncionario = qntFuncionario;
        }

        public string Cidade { get => cidade; set => cidade = value; }
        public int Ano { get => ano; set => ano = value; }
        public int QntFuncionario { get => qntFuncionario; set => qntFuncionario = value; }

        public double calcCusto()
        {
            return (qntFuncionario * 1212) + 4000;
        }

    }
}
