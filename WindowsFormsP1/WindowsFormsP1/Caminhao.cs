using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsP1
{
    public class Caminhao:Veiculo
    {
        public int eixos;

        public Caminhao(string placa, int ano,int eixos):base(placa, ano)
        {
            this.eixos = eixos;
        }

        public int Eixos { get => eixos; set => eixos = value; }

        public override double CalcAluguel()
        {
            double diaria;
            diaria = (300 * eixos) - (Ano - 2022)*50;
            return diaria;
        }

    }//fim da classe
}
