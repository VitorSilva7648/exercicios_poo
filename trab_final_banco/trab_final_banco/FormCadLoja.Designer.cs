namespace trab_final_banco
{
    partial class CadLoja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcidade = new System.Windows.Forms.TextBox();
            this.tbano = new System.Windows.Forms.TextBox();
            this.tbqntFuncionario = new System.Windows.Forms.TextBox();
            this.btexibir = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblfuncionario = new System.Windows.Forms.Label();
            this.tbcnpj = new System.Windows.Forms.TextBox();
            this.lblcnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcidade
            // 
            this.tbcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbcidade.Location = new System.Drawing.Point(247, 56);
            this.tbcidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcidade.Name = "tbcidade";
            this.tbcidade.Size = new System.Drawing.Size(209, 26);
            this.tbcidade.TabIndex = 0;
            this.tbcidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbano
            // 
            this.tbano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbano.Location = new System.Drawing.Point(247, 102);
            this.tbano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbano.Name = "tbano";
            this.tbano.Size = new System.Drawing.Size(209, 26);
            this.tbano.TabIndex = 1;
            this.tbano.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbqntFuncionario
            // 
            this.tbqntFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbqntFuncionario.Location = new System.Drawing.Point(247, 152);
            this.tbqntFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbqntFuncionario.Name = "tbqntFuncionario";
            this.tbqntFuncionario.Size = new System.Drawing.Size(209, 26);
            this.tbqntFuncionario.TabIndex = 2;
            this.tbqntFuncionario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btexibir
            // 
            this.btexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexibir.Location = new System.Drawing.Point(13, 215);
            this.btexibir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(89, 35);
            this.btexibir.TabIndex = 4;
            this.btexibir.Text = "Exibir";
            this.btexibir.UseVisualStyleBackColor = true;
            this.btexibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btinserir
            // 
            this.btinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btinserir.Location = new System.Drawing.Point(153, 215);
            this.btinserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(87, 35);
            this.btinserir.TabIndex = 5;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btatualizar.Location = new System.Drawing.Point(288, 215);
            this.btatualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(93, 35);
            this.btatualizar.TabIndex = 6;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexcluir.Location = new System.Drawing.Point(427, 215);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(96, 35);
            this.btexcluir.TabIndex = 7;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 151);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblcidade.Location = new System.Drawing.Point(9, 62);
            this.lblcidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(61, 20);
            this.lblcidade.TabIndex = 9;
            this.lblcidade.Text = "Cidade";
            this.lblcidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblano.Location = new System.Drawing.Point(9, 108);
            this.lblano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(43, 20);
            this.lblano.TabIndex = 10;
            this.lblano.Text = "Ano ";
            this.lblano.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfuncionario
            // 
            this.lblfuncionario.AutoSize = true;
            this.lblfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblfuncionario.Location = new System.Drawing.Point(9, 152);
            this.lblfuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfuncionario.Name = "lblfuncionario";
            this.lblfuncionario.Size = new System.Drawing.Size(204, 20);
            this.lblfuncionario.TabIndex = 11;
            this.lblfuncionario.Text = "Qantidade de funcionarios";
            this.lblfuncionario.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbcnpj
            // 
            this.tbcnpj.Location = new System.Drawing.Point(247, 12);
            this.tbcnpj.Name = "tbcnpj";
            this.tbcnpj.Size = new System.Drawing.Size(209, 26);
            this.tbcnpj.TabIndex = 13;
            this.tbcnpj.Visible = false;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(9, 18);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(53, 20);
            this.lblcnpj.TabIndex = 14;
            this.lblcnpj.Text = "CNPJ";
            // 
            // CadLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 432);
            this.Controls.Add(this.lblcnpj);
            this.Controls.Add(this.tbcnpj);
            this.Controls.Add(this.lblfuncionario);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.tbqntFuncionario);
            this.Controls.Add(this.tbano);
            this.Controls.Add(this.tbcidade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadLoja";
            this.Text = "Cadastro Loja";
            this.Load += new System.EventHandler(this.CadLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcidade;
        private System.Windows.Forms.TextBox tbano;
        private System.Windows.Forms.TextBox tbqntFuncionario;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblfuncionario;
        private System.Windows.Forms.TextBox tbcnpj;
        private System.Windows.Forms.Label lblcnpj;
    }
}