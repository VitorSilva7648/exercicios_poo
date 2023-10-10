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

namespace WinFormsBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mtbcpf.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[1].Value); 
            tbnome.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value);
            tbsalario.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[3].Value);
        }

        public void limpartextbox()
        {
            mtbcpf.Text = String.Empty;
            tbnome.Text = String.Empty;
            tbsalario.Text = String.Empty;  
        }

        private void mtbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void btexibir_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();
            
            string conexao = stringConexao.ConnString();
            
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            
            con.Open();
            
            DataTable dt = new DataTable();
            
            string commandText = "SELECT * FROM cliente ORDER BY id_cliente";
            
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            {
                Adpt.Fill(dt);
            }
            
            dGV.DataSource = dt;

            con.Close();
        }

        private void btinserir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(mtbcpf.Text, tbnome.Text, Convert.ToDouble(tbsalario.Text));

            ConexaoString stringConexao = new ConexaoString();
            
            string conexao = stringConexao.ConnString();
            
            NpgsqlConnection con = new NpgsqlConnection(conexao);
            
            con.Open();

            string commandText = String.Format("INSERT INTO cliente(cpf_cliente, nome_cliente, salario_cliente, credito_cliente)" + "values('{0}', '{1}', '{2}, '{3}) ", objPessoa.Cpf, objPessoa.Nome, objPessoa.Salario, objPessoa.CalcCred());

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Dados cadastrados com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpartextbox();
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(mtbcpf.Text, tbnome.Text, Convert.ToDouble(tbsalario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("UPDATE cliente SET cpf_cliente = '" + objPessoa.Cpf+ "' , nome_cliente = '" + objPessoa.Nome+ "', salario_cliente =" + objPessoa.Salario+ " , credito_cliente = " +objPessoa.CalcCred() + "Where cpf_cliente = '" +cpf+ "'");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Dados cadastrados com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpartextbox();
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(mtbcpf.Text, tbnome.Text, Convert.ToDouble(tbsalario.Text));

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao);

            con.Open();

            string commandText = String.Format("DELETE FROM cliente WHERE cpf_cliente = '{0}'" , cpf );

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Dados cadastrados com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpartextbox();
        }
    }
}
