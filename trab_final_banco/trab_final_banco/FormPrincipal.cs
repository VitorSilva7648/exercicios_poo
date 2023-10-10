using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace trab_final_banco
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFuncionario objCadFuncionario = new CadFuncionario();
            objCadFuncionario.ShowDialog();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVeiculo objCadVeiculo = new CadVeiculo();
            objCadVeiculo.ShowDialog();
        }

        private void lojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLoja objCadLoja = new CadLoja();
            objCadLoja.ShowDialog();
        }
    }
}
