using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gerarGradelistViem();
        }

        private void rbcaminhao_CheckedChanged(object sender, EventArgs e)
        {
            mtbplaca.Mask = ">LLL-0000";
            lblano.Text = "Ano";
            lblqnt.Text = "Qnt Eixos";

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void gerarGradelistViem()
        {
            listView.Columns.Add("Placa", 80).TextAlign = HorizontalAlignment.Center;
            listView.Columns.Add("Ano", 80).TextAlign = HorizontalAlignment.Center;
            listView.Columns.Add("Assentos", 100).TextAlign = HorizontalAlignment.Center;
            listView.Columns.Add("Eixos", 80).TextAlign = HorizontalAlignment.Center;
            listView.Columns.Add("Diaria", 80).TextAlign = HorizontalAlignment.Center;
            listView.View = View.Details;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            mtbplaca.Text = string.Empty;
            tbano.Text = string.Empty;
            tbqnt.Text = string.Empty;
        }

        private void rbonibus_CheckedChanged(object sender, EventArgs e)
        {
            mtbplaca.Mask = ">LLL-0000";
            lblano.Text = "Ano";
            lblqnt.Text = "Qnt Assentos";
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (rbonibus.Checked == true)
            {
                //objOnibus
                Onibus onibus = new Onibus(mtbplaca.Text, Convert.ToInt32(tbano.Text), Convert.ToInt32(tbqnt.Text));

                string[] cliente = new string[6]; //cria um vetor de strings
                cliente[0] = onibus.Placa;
                cliente[1] = Convert.ToString(onibus.Ano);
                cliente[2] = Convert.ToString(onibus.assentos);
                cliente[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", onibus.CalcAluguel());

                //inserir umvetor com os dados criados
                listView.Items.Add(new ListViewItem(cliente));

                //mensagem na tela de "dados cadastrados com sucesso"
                MessageBox.Show("Dados cadastrados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (rbcaminhao.Checked == true)
            {
                //objPessoaFisica
                Caminhao caminhao = new Caminhao(mtbplaca.Text, Convert.ToInt32(tbano.Text), Convert.ToInt32(tbqnt.Text));

                string[] clienteCa = new string[6]; //cria um vetor de strings
                clienteCa[0] = caminhao.Placa;
                clienteCa[1] = Convert.ToString(caminhao.Ano);
                clienteCa[3] = Convert.ToString(caminhao.eixos);
                clienteCa[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", caminhao.CalcAluguel());

                //inserir umvetor com os dados criados
                listView.Items.Add(new ListViewItem(clienteCa));

                //mensagem na tela de "dados cadastrados com sucesso"
                MessageBox.Show("Dados cadastrados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void mtbplaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //if (mtbplaca.Text == string.Empty)
            //{
            //    MessageBox.Show("Dados incorretos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            
        }

        private void tbano_TextChanged(object sender, EventArgs e)
        {
            //if(tbano.Text == string.Empty)
            //{
            //    MessageBox.Show("Dados incorretos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void tbqnt_TextChanged(object sender, EventArgs e)
        {
            //if (tbqnt.Text == string.Empty)
            //{
            //    MessageBox.Show("Dados incorretos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }
    }
}
