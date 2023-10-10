using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalcAreaFiguras
{
    class Quadrado:FormasGeometricas
    {
        private int baseQuadrado;

        public Quadrado(int baseQuadrado, string nome): base(nome)
        {
            this.baseQuadrado = baseQuadrado;
        }

        public int BaseQuadrado { get => baseQuadrado; set => baseQuadrado = value; }

        public override double CalcArea()
        {
            double area;
            area = (baseQuadrado * baseQuadrado);
            return area;
        }

        public override double CalcPerimetro()
        {
            double perimetro;
            perimetro = baseQuadrado * 4;
            return CalcPerimetro();    
        }
    }//FIM DA CLASSE
}
