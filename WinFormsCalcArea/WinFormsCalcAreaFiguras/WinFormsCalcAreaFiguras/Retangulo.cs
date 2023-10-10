using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalcAreaFiguras
{
    class Retangulo:FormasGeometricas
    {
        private int baseRetangulo;
        private int altura;

        public Retangulo(int baseRetangulo, int altura, string nome):base(nome)
        {
            this.baseRetangulo = baseRetangulo;
            this.altura = altura;
        }

        public int BaseRetangulo { get => baseRetangulo; set => baseRetangulo = value; }
        public int Altura { get => altura; set => altura = value; }

        public override double CalcArea()
        {
            double area;
            area = (baseRetangulo * altura);
            return area;
        }

        public override double CalcPerimetro()
        {
            double perimetro;
            perimetro = (baseRetangulo * 2) + (altura * 2);
            return CalcPerimetro();
        }

    }//FIM DA CLASSE
}
