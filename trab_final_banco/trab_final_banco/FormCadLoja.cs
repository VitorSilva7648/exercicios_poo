using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trab_final_banco
{
    public partial class CadLoja : Form
    {
        public CadLoja()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadLoja_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoLoja objConexaoLoja = new ConexaoLoja();
            string contemConexao = objConexaoLoja.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            DataTable dt = new DataTable();

            string stringSql = "SELECT * FROM loja ORDER BY id_cnpj";

            using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                npgsqlDataAdapter.Fill(dt);
            }

            dataGridView1.DataSource = dt;

            objConnection.Close();
            MessageBox.Show("Dados exibidos com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Loja objLoja = new Loja(tbcidade.Text, Convert.ToInt16(tbano.Text), Convert.ToInt32(tbqntFuncionario.Text));

                ConexaoLoja objConexaoLoja = new ConexaoLoja();
                string contemConexao = objConexaoLoja.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
                objConnection.Open();

                string stringSql = $"INSERT INTO loja(cidade_loja, ano_loja, qntfuncionario_loja, custo_loja) " +
                    $"VALUES ('{objLoja.Cidade}', '{objLoja.Ano}', {objLoja.QntFuncionario}, " +
                    $"{objLoja.calcCusto()})";

                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }

                objConnection.Close();
                MessageBox.Show("Inserção de dados concluida: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextBox();
            }

            catch (FormatException formatException)
            {
                MessageBox.Show("Ocorreu uma excecao de formato. Precisa ser um numero ou apenas letras. Tente de novo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Loja objLoja = new Loja(tbcidade.Text, Convert.ToInt16(tbano.Text), Convert.ToInt32(tbqntFuncionario.Text), Convert.ToDouble(tbcusto.Text));
                Loja objLoja = new Loja(tbcidade.Text, Convert.ToInt16(tbano.Text), Convert.ToInt32(tbqntFuncionario.Text));

                string cnpj = tbcnpj.Text;

                ConexaoLoja objConexaoLoja = new ConexaoLoja();
                string contemConexao = objConexaoLoja.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
                objConnection.Open();

                //string stringSql = $"UPDATE loja SET cidade_loja = '{objLoja.Cidade}', ano_loja ='{objLoja.Ano}', " +
                //    $"qntfuncionario_loja, = {objLoja.QntFuncionario}, custo_loja = {objLoja.Custo} WHERE id_cnpj = {cnpj}";

                string stringSql = $"UPDATE loja SET cidade_loja = '{objLoja.Cidade}', ano_loja ='{objLoja.Ano}', " +
                    $"qntfuncionario_loja = {objLoja.QntFuncionario}, custo_loja = {objLoja.calcCusto()} WHERE id_cnpj = '{cnpj}'";


                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }

                objConnection.Close();
                MessageBox.Show("Atualização de dados concluida: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextBox();
            }

            catch (FormatException formatException)
            {
                MessageBox.Show("Ocorreu uma excecao de formato. Precisa ser um numero ou apenas letras. Tente de novo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cnpj = tbcnpj.Text;

            ConexaoLoja objConexaoLoja = new ConexaoLoja();
            string contemConexao = objConexaoLoja.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            string stringSql = $"DELETE FROM loja WHERE id_cnpj = '{cnpj}'"; ;

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }

            objConnection.Close();
            MessageBox.Show("Dados deletados: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbcnpj.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tbcidade.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            tbano.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            tbqntFuncionario.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
         
        }
        private void limparTextBox()
        {
            tbcidade.Text = String.Empty;
            tbano.Text = String.Empty;
            tbqntFuncionario.Text = String.Empty; 
           
        }

    }
}
