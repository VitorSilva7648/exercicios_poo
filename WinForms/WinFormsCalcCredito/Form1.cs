using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //usar R$

namespace WinFormsCalcCredito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNomefantasia.Visible = false; //altera a visibilidade do componente
            tbNomefantasia.Visible = false;
            gerarGradelistViemPf(); //inserir grades no inicio do programa
            gerarGradelistViemPj();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbPf.Checked == true)
            {
                //objPf
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpf.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdfilhos.Text), Convert.ToDouble(tbSalario.Text));

                string[] clientePf = new string[6]; //cria um vetor de strings
                clientePf[0] = pessoaFisica.Cpf;
                clientePf[1] = pessoaFisica.Nome;
                clientePf[2] = pessoaFisica.Cidade;
                clientePf[3] = Convert.ToString(pessoaFisica.QtdFilhos);
                clientePf[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.Salario);
                clientePf[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.CalcCred());

                //inserir umvetor com os dados criados
                lvPf.Items.Add(new ListViewItem(clientePf));

                //mensagem na tela de "dados cadastrados com sucesso"
                MessageBox.Show("Dados cadastrados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (rbPj.Checked == true) {
                //objPessoaFisica
                PessoaJuridica pessoaJuridica = new PessoaJuridica(mtbCpf.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdfilhos.Text), Convert.ToDouble(tbSalario.Text), tbNomefantasia.Text);

                string[] clientePj = new string[7]; //cria um vetor de strings
                clientePj[0] = pessoaJuridica.Cnpj;
                clientePj[1] = pessoaJuridica.Nome;
                clientePj[2] = pessoaJuridica.Cidade;
                clientePj[3] = Convert.ToString(pessoaJuridica.QtdFun);
                clientePj[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.Faturamento);
                clientePj[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.CalcCred());
                clientePj[6] = pessoaJuridica.NomeFantasia;

                //inserir umvetor com os dados criados
                lvPj.Items.Add(new ListViewItem(clientePj));

                //mensagem na tela de "dados cadastrados com sucesso"
                MessageBox.Show("Dados cadastrados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void radbut1_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpf.Mask = "000,000,000-00";
            lblCpf.Text = "CPF";
            lblQtdfilhos.Text = "QTD FILHOS";
            lblSalario.Text = "SALARIO";
            lblNomefantasia.Visible = false; //altera a visibilidade do componente
            tbNomefantasia.Visible = false;
        }

        public void gerarGradelistViemPf()
        {
            lvPf.Columns.Add("CPF", 50).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("NOME", 50).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("CIDADE", 80).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("FILHOS", 50).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("SALÁRIO", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("CRÉDITO", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.View = View.Details;
        }

        public void gerarGradelistViemPj()
        {
            lvPj.Columns.Add("CNPJ", 50).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("NOME", 50).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("CIDADE", 60).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("FUNCIONARIOS", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("FATURAMENTO", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("CRÉDITO", 70).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("NOME FANTASIA", 120).TextAlign = HorizontalAlignment.Center;
            lvPj.View = View.Details;
        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpf.Mask = "00,000,000/0000-00";
            lblCpf.Text = "CNPJ";
            lblQtdfilhos.Text = "QTD FUNCIONARIOS";
            lblSalario.Text = "FATURAMENTO";
            lblNomefantasia.Visible = true; //altera a visibilidade do componente
            tbNomefantasia.Visible = true;

        }
        private void limpar()
        {
            mtbCpf.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbCidade.Text = string.Empty;
            tbQtdfilhos.Text = string.Empty;
            tbSalario.Text = string.Empty;
            tbNomefantasia.Text = string.Empty;
        }

        private void tbQtdfilhos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mtbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }//fim da classe
}
