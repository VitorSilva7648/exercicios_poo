﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCalcMedia
{
     class Aluno
    {
        private string nome;
        private string cpf;
        private string disciplina;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;



        public Aluno(string nome, string cpf, string disciplina, double nota1, double nota2, double nota3, double nota4)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.disciplina = disciplina;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Disciplina { get => disciplina; set => disciplina = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }


        public double CalcMedia()
        {
            double media;
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            return media;
        }

        public string Sit()
        {
            string Sit;
            double media = CalcMedia();
            if (media > 7)
            {
                Sit = "Aprovado";
            }
            else if (media < 6)
            {
                Sit = "Reprovado";
            }
            else
            {
                Sit = "de Recuperação";
            }

            return Sit;
        }
        public void Mensage()
        {
           // Console.WriteLine(nome + "a media de suas notas e: " + CalMedia() + "por isso voce esta " + Sit());
        }
    }
}
