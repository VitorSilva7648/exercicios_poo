using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(tbnome.Text, tbcpf.Text, tbdisciplina.Text, Convert.ToDouble(tbnota1.Text), Convert.ToDouble(tbnota2.Text), Convert.ToDouble(tbnota3.Text), Convert.ToDouble(tbnota4.Text));
            MessageBox.Show(aluno.Nome + " a media de suas notas sao: " + aluno.CalcMedia() + " por isso voce esta "+aluno.Sit());
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbnome.Text = "";
            tbcpf.Text = "";
            tbdisciplina.Text = "";
            tbnota1.Text = "";
            tbnota2.Text = "";
            tbnota3.Text = "";
            tbnota4.Text = "";

        }

        private void tbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
