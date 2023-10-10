using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalcAreaFiguras
{
    public abstract class FormasGeometricas
    {
        private string nome;

        protected FormasGeometricas(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public abstract double CalcArea();
        public virtual double CalcPerimetro()
        {
            return 0;
        }
    }
}
