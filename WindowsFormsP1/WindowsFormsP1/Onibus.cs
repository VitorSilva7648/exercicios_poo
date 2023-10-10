using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsP1
{
    public class Onibus:Veiculo
    {
        public int assentos;

        public Onibus(string placa, int ano, int assentos):base(placa,ano)
        {
            this.assentos = assentos;
        }

        public int Assentos { get => assentos; set => assentos = value; }

        public override double CalcAluguel()
        {
            double diaria;
            diaria = (30 * assentos) - (2022 - ano) * 70;
            return diaria;
        }

    }//fim da classe
}
