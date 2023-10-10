using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;
using System.Threading.Tasks;

namespace trab_final_banco
{
    class Funcionario
    {
        private string matricula;
        private string nome;
        private string cargoAtual;
        private double salarioBase;
        private int qntDependente;

        public Funcionario(string matricula, string nome, string cargoAtual, double salarioBase, int qntDependente)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.cargoAtual = cargoAtual;
            this.salarioBase = salarioBase;
            this.qntDependente = qntDependente;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CargoAtual { get => cargoAtual; set => cargoAtual = value; }
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }
        public int QntDependente { get => qntDependente; set => qntDependente = value; }

        public  double calSalario()
        {
            return salarioBase + (qntDependente * 100);
        }
    }
}
