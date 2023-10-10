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
    public partial class CadVeiculo : Form
    {
        public CadVeiculo()
        {
            InitializeComponent();
        }

        private void btexibir_Click(object sender, EventArgs e)
        {
            ConexaoVeiculo objConexaoVeiculo = new ConexaoVeiculo();
            string contemConexao = objConexaoVeiculo.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            DataTable dt = new DataTable();

            string stringSql = "SELECT * FROM veiculo ORDER BY id_chassi";

            using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection))
            {
                npgsqlDataAdapter.Fill(dt);
            }

            dataGridView1.DataSource = dt;

            objConnection.Close();
            MessageBox.Show("Dados exibidos com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbchassi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tbfabricante.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            tbano.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            tbprecoBase.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            tbqntVeiculo.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo objVeiculo = new Veiculo(tbfabricante.Text, Convert.ToInt16(tbano.Text), Convert.ToDouble(tbprecoBase.Text), Convert.ToInt32(tbqntVeiculo.Text));

                ConexaoVeiculo objConexaoVeiculo = new ConexaoVeiculo();
                string contemConexao = objConexaoVeiculo.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
                objConnection.Open();

                string stringSql = $"INSERT INTO veiculo(fabricmodelo_veiculo, ano_veiculo, " +
                    $"precoBase_veiculo, qnt_veiculo, precofinal_veiculo) " +
                    $"VALUES ('{objVeiculo.Fabricante}', '{objVeiculo.Ano}', {objVeiculo.PrecoBase}, " +
                    $"{objVeiculo.QntVeiculo}, {objVeiculo.calcFinal()})";

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

        private void btatualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo objVeiculo = new Veiculo(tbfabricante.Text, Convert.ToInt16(tbano.Text), Convert.ToDouble(tbprecoBase.Text), Convert.ToInt32(tbqntVeiculo.Text));

                string chassi = tbchassi.Text;

                ConexaoVeiculo objConexaoVeiculo = new ConexaoVeiculo();
                string contemConexao = objConexaoVeiculo.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
                objConnection.Open();

                string stringSql = $"UPDATE veiculo SET fabricmodelo_veiculo = '{objVeiculo.Fabricante}', ano_veiculo ='{objVeiculo.Ano}', " +
                    $"precoBase_veiculo = {objVeiculo.PrecoBase}, qnt_veiculo = {objVeiculo.QntVeiculo}, " +
                    $"precoFinal_veiculo = {objVeiculo.calcFinal()} WHERE id_chassi = '{chassi}'";

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

        private void btexcluir_Click(object sender, EventArgs e)
        {
            string chassi = tbchassi.Text;

            ConexaoVeiculo objConexaoVeiculo = new ConexaoVeiculo();
            string contemConexao = objConexaoVeiculo.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            string stringSql = $"DELETE FROM veiculo WHERE id_chassi = '{chassi}'";

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }

            objConnection.Close();
            MessageBox.Show("Dados deletados: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextBox();
        }
        private void limparTextBox()
        {
            tbfabricante.Text = String.Empty;
            tbano.Text = String.Empty;
            tbprecoBase.Text = String.Empty;
            tbprecoBase.Text = String.Empty;
            tbqntVeiculo.Text = String.Empty;
            
        }

        private void CadVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
