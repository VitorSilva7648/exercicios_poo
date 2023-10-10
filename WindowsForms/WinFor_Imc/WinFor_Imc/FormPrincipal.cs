using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFor_Imc
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(tbNome.Text, Convert.ToDouble(tbPeso.Text), Convert.ToDouble(tbAltura.Text));
            MessageBox.Show(pessoa.Nome + "seu IMC e: " + imc() + Sit());
        }
    }
}
