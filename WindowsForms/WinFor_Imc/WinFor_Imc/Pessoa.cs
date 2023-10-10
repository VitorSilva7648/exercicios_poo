using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFor_Imc
{
    namespace exer_aula
    {
        internal class Pessoa
        {
            public string nome;
            public double peso;
            public double altura;

            public Pessoa(string nome, double peso, double altura)
            {
                this.nome = nome;
                this.peso = peso;
                this.altura = altura;
            }
            public Pessoa()
            {

            }
            public double CalImc()
            {
                double imc;
                imc = peso / (altura * altura);
                return imc;
            }
            public string Sit()
            {
                string Sit;
                double imc = CalImc();
                if (imc < 18.5)
                {
                    Sit = "abaixo do peso";
                }
                else if (imc > 30)
                {
                    Sit = "obsidade";
                }
                else
                {
                    Sit = "peso normal";
                }

                return Sit;
            }
            public void Mensage()
            {
                Console.WriteLine(nome + "seu IMC e: " + CalImc() + "por isso voce esta " + Sit());
            }
        }
    }

}
