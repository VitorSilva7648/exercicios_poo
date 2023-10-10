using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
             // TRATAMENTO DE EXCECOES
                try  // "tente" rodar o codigo abaixo
                {
                    int num_1 = Convert.ToInt32(tbnum1.Text);
                    int num_2 = Convert.ToInt32(tbnum2.Text);

                    int resultado = (num_1 * num_2);
                    tbresultado.Text= Convert.ToString(resultado);
                    MessageBox.Show("Números multiplicados com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


                } // fim do try


            //catch (ArithmeticException arithmeticException)
            //    {
       
            //        MessageBox.Show("Ocorreu uma excecao aritimetica. Tente de novo. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        MessageBox.Show("Nao existe divisao por zero. Tente de novo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            //    } // fim do catch

                catch (FormatException formatException)
                {
                    MessageBox.Show("Ocorreu uma excecao de formato. Precisa ser um numero inteiro. Tente de novo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } // fim do catch
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbnum1.Text = string.Empty;
            tbnum2.Text = string.Empty;
            tbresultado.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            // TRATAMENTO DE EXCECOES
            try  // "tente" rodar o codigo abaixo
            {
                int num_1 = Convert.ToInt32(tbnum1.Text);
                int num_2 = Convert.ToInt32(tbnum2.Text);

                int resultado = (num_1 / num_2);
                tbresultado.Text = Convert.ToString(resultado);
                MessageBox.Show("Números divididos com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            } // fim do try
            catch (ArithmeticException arithmeticException)
            {
                MessageBox.Show("Ocorreu uma excecao aritimetica. Nao existe divisao por zero. Tente de novo. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
     
            } // fim do catch

            catch (FormatException formatException)
            {
                MessageBox.Show("Ocorreu uma excecao de formato. Precisa ser um numero inteiro. Tente de novo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // fim do catch
        }
    }

}
