using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsP1
{
     public abstract class Veiculo
     {
        protected string placa;
        protected int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        public Veiculo(string placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
        }
        public abstract double CalcAluguel();

     }//fim da classe
}
