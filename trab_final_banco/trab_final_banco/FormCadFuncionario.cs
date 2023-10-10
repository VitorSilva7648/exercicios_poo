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
    public partial class CadFuncionario : Form
    {
        public CadFuncionario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbmatricula.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tbnome.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            cbcargo.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            tbsalario.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            tbdependente.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btexibir_Click(object sender, EventArgs e)
        {
            Conexao objConexao = new Conexao();
            string contemConexao = objConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            DataTable dt = new DataTable();

            string stringSql = "SELECT * FROM funcionario ORDER BY id_matricula";

            using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(stringSql, objConnection)) 
            {
                npgsqlDataAdapter.Fill(dt);
            }

            dataGridView1.DataSource = dt;

            objConnection.Close();
            MessageBox.Show("Dados exibidos com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            try
            {
            Funcionario objFuncionario = new Funcionario(tbmatricula.Text, tbnome.Text, cbcargo.Text, Convert.ToDouble(tbsalario.Text), Convert.ToInt32(tbdependente.Text));

            Conexao objConexao = new Conexao();
            string contemConexao = objConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();


                string stringSql = $"INSERT INTO funcionario(nome_funcionario, cargoAtual_funcionario, " +
                    $"salarioBase_funcionario, qntDependentes_funcionario, salarioTotal_funcionario) " +
                    $"VALUES ('{objFuncionario.Nome}', '{objFuncionario.CargoAtual}', {objFuncionario.SalarioBase}, " +
                    $"{objFuncionario.QntDependente}, {objFuncionario.calSalario()})";

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
            } // fim do catch
        }
        private void limparTextBox()
        {
            tbmatricula.Text = String.Empty;
            tbnome.Text = String.Empty; 
            cbcargo.Text = String.Empty;
            tbsalario.Text = String.Empty;
            tbdependente.Text = String.Empty;
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario objFuncionario = new Funcionario(tbmatricula.Text, tbnome.Text, cbcargo.Text, Convert.ToDouble(tbsalario.Text), Convert.ToInt32(tbdependente.Text));

                string matricula = tbmatricula.Text;

                Conexao objConexao = new Conexao();
                string contemConexao = objConexao.Conectar();

                NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
                objConnection.Open();

                string stringSql = $"UPDATE funcionario SET nome_funcionario = '{objFuncionario.Nome}', cargoAtual_funcionario ='{objFuncionario.CargoAtual}', " +
                    $"salarioBase_funcionario = {objFuncionario.SalarioBase}, qntDependentes_funcionario = {objFuncionario.QntDependente}, " +
                    $"salarioTotal_funcionario = {objFuncionario.calSalario()} WHERE id_matricula = {matricula}";

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
            string matricula = tbmatricula.Text;

            Conexao objConexao = new Conexao();
            string contemConexao = objConexao.Conectar();

            NpgsqlConnection objConnection = new NpgsqlConnection(contemConexao);
            objConnection.Open();

            string stringSql = $"DELETE FROM funcionario WHERE id_matricula = '{matricula}' ";

            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(stringSql, objConnection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }

            objConnection.Close();
            MessageBox.Show("Dados deletados: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTextBox();
        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }
    }

}
