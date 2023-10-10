namespace trab_final_banco
{
    partial class CadFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.tbmatricula = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.tbsalario = new System.Windows.Forms.TextBox();
            this.tbdependente = new System.Windows.Forms.TextBox();
            this.btexibir = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.lbldependentes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbmatricula
            // 
            this.tbmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbmatricula.Location = new System.Drawing.Point(267, 18);
            this.tbmatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbmatricula.Name = "tbmatricula";
            this.tbmatricula.Size = new System.Drawing.Size(174, 26);
            this.tbmatricula.TabIndex = 0;
            this.tbmatricula.Visible = false;
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbnome.Location = new System.Drawing.Point(267, 63);
            this.tbnome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(174, 26);
            this.tbnome.TabIndex = 1;
            // 
            // cbcargo
            // 
            this.cbcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Items.AddRange(new object[] {
            "Vendedor",
            "Gerente",
            "Serviços Gerais"});
            this.cbcargo.Location = new System.Drawing.Point(267, 99);
            this.cbcargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(174, 28);
            this.cbcargo.TabIndex = 2;
            // 
            // tbsalario
            // 
            this.tbsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbsalario.Location = new System.Drawing.Point(267, 136);
            this.tbsalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbsalario.Name = "tbsalario";
            this.tbsalario.Size = new System.Drawing.Size(174, 26);
            this.tbsalario.TabIndex = 3;
            // 
            // tbdependente
            // 
            this.tbdependente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbdependente.Location = new System.Drawing.Point(267, 178);
            this.tbdependente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbdependente.Name = "tbdependente";
            this.tbdependente.Size = new System.Drawing.Size(174, 26);
            this.tbdependente.TabIndex = 4;
            // 
            // btexibir
            // 
            this.btexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexibir.Location = new System.Drawing.Point(17, 249);
            this.btexibir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(96, 39);
            this.btexibir.TabIndex = 5;
            this.btexibir.Text = "Exibir";
            this.btexibir.UseVisualStyleBackColor = true;
            this.btexibir.Click += new System.EventHandler(this.btexibir_Click);
            // 
            // btinserir
            // 
            this.btinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btinserir.Location = new System.Drawing.Point(187, 249);
            this.btinserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(96, 39);
            this.btinserir.TabIndex = 6;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btatualizar.Location = new System.Drawing.Point(370, 249);
            this.btatualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(96, 39);
            this.btatualizar.TabIndex = 7;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexcluir.Location = new System.Drawing.Point(542, 249);
            this.btexcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(96, 39);
            this.btexcluir.TabIndex = 8;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblmatricula.Location = new System.Drawing.Point(13, 24);
            this.lblmatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(78, 20);
            this.lblmatricula.TabIndex = 9;
            this.lblmatricula.Text = "Matricula";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblnome.Location = new System.Drawing.Point(13, 70);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(53, 20);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Nome";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblcargo.Location = new System.Drawing.Point(13, 107);
            this.lblcargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(97, 20);
            this.lblcargo.TabIndex = 11;
            this.lblcargo.Text = "Cargo Atual";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblsalario.Location = new System.Drawing.Point(13, 142);
            this.lblsalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(105, 20);
            this.lblsalario.TabIndex = 12;
            this.lblsalario.Text = "Salario Base";
            // 
            // lbldependentes
            // 
            this.lbldependentes.AutoSize = true;
            this.lbldependentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbldependentes.Location = new System.Drawing.Point(13, 184);
            this.lbldependentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldependentes.Name = "lbldependentes";
            this.lbldependentes.Size = new System.Drawing.Size(217, 20);
            this.lbldependentes.TabIndex = 13;
            this.lbldependentes.Text = "Quantidade de dependentes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 147);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbldependentes);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblmatricula);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.tbdependente);
            this.Controls.Add(this.tbsalario);
            this.Controls.Add(this.cbcargo);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.tbmatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.CadFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbmatricula;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.TextBox tbsalario;
        private System.Windows.Forms.TextBox tbdependente;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lbldependentes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}