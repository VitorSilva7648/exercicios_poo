using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final_banco
{
    class Veiculo
    {
        private string fabricante;
        private int ano;
        private double precoBase;
        private int qntVeiculo;

        public Veiculo(string fabricante, int ano, double precoBase, int qntVeiculo)
        {
            this.fabricante = fabricante;
            this.ano = ano;
            this.precoBase = precoBase;
            this.qntVeiculo = qntVeiculo;
        }

        public string Fabricante { get => fabricante; set => fabricante = value; }
        public int Ano { get => ano; set => ano = value; }
        public double PrecoBase { get => precoBase; set => precoBase = value; }
        public int QntVeiculo { get => qntVeiculo; set => qntVeiculo = value; }

        public double calcFinal()
        {
            return precoBase + 14000;
        }
    }
}
