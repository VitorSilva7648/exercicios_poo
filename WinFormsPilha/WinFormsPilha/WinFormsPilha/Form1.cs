using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPilha
{
    public partial class Palindromo : Form
    {
        public Palindromo()
        {
            InitializeComponent();
        }

        private void btverificar_Click(object sender, EventArgs e)
        {
            Pilha pilha = new Pilha();

            string palavra = tbpalavra.Text.ToUpper();

            for (int i = 0; i < palavra.Length; i++)
            {
                pilha.push(tbpalavra.Text[i]);
            }

            var palavraInvertida = new List<string>();

            for (int i = 0; i < palavra.Length; i++)
            {
                palavraInvertida.Add(pilha.pop().ToString());
            }

            string palavraInvertidaConvertida = "";

            foreach (var item in palavraInvertida)
            {
                palavraInvertidaConvertida += item.ToString().ToUpper();
            }

            if (palavra.Equals(palavraInvertidaConvertida))
            {
                MessageBox.Show("É um Palíndromo!", "Resposta");
            }
            else
            {
                MessageBox.Show("Esta palavra não é um Palíndromo!", "Resposta");
            }
        }
    }
}
