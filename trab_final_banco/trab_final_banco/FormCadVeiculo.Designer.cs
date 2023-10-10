namespace trab_final_banco
{
    partial class CadVeiculo
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
            this.tbchassi = new System.Windows.Forms.TextBox();
            this.tbfabricante = new System.Windows.Forms.TextBox();
            this.tbano = new System.Windows.Forms.TextBox();
            this.tbprecoBase = new System.Windows.Forms.TextBox();
            this.tbqntVeiculo = new System.Windows.Forms.TextBox();
            this.btexibir = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblchassi = new System.Windows.Forms.Label();
            this.lblfabricante = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblqnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbchassi
            // 
            this.tbchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbchassi.Location = new System.Drawing.Point(243, 12);
            this.tbchassi.Name = "tbchassi";
            this.tbchassi.Size = new System.Drawing.Size(189, 26);
            this.tbchassi.TabIndex = 0;
            this.tbchassi.Visible = false;
            // 
            // tbfabricante
            // 
            this.tbfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbfabricante.Location = new System.Drawing.Point(243, 76);
            this.tbfabricante.Name = "tbfabricante";
            this.tbfabricante.Size = new System.Drawing.Size(189, 26);
            this.tbfabricante.TabIndex = 1;
            // 
            // tbano
            // 
            this.tbano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbano.Location = new System.Drawing.Point(243, 128);
            this.tbano.Name = "tbano";
            this.tbano.Size = new System.Drawing.Size(189, 26);
            this.tbano.TabIndex = 2;
            // 
            // tbprecoBase
            // 
            this.tbprecoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbprecoBase.Location = new System.Drawing.Point(243, 183);
            this.tbprecoBase.Name = "tbprecoBase";
            this.tbprecoBase.Size = new System.Drawing.Size(189, 26);
            this.tbprecoBase.TabIndex = 3;
            // 
            // tbqntVeiculo
            // 
            this.tbqntVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbqntVeiculo.Location = new System.Drawing.Point(243, 240);
            this.tbqntVeiculo.Name = "tbqntVeiculo";
            this.tbqntVeiculo.Size = new System.Drawing.Size(189, 26);
            this.tbqntVeiculo.TabIndex = 4;
            // 
            // btexibir
            // 
            this.btexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexibir.Location = new System.Drawing.Point(38, 305);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(92, 36);
            this.btexibir.TabIndex = 6;
            this.btexibir.Text = "Exibir";
            this.btexibir.UseVisualStyleBackColor = true;
            this.btexibir.Click += new System.EventHandler(this.btexibir_Click);
            // 
            // btinserir
            // 
            this.btinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btinserir.Location = new System.Drawing.Point(167, 305);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(92, 36);
            this.btinserir.TabIndex = 7;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btatualizar.Location = new System.Drawing.Point(295, 305);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(92, 36);
            this.btatualizar.TabIndex = 8;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btexcluir.Location = new System.Drawing.Point(415, 305);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(92, 36);
            this.btexcluir.TabIndex = 9;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblchassi
            // 
            this.lblchassi.AutoSize = true;
            this.lblchassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblchassi.Location = new System.Drawing.Point(17, 18);
            this.lblchassi.Name = "lblchassi";
            this.lblchassi.Size = new System.Drawing.Size(61, 20);
            this.lblchassi.TabIndex = 11;
            this.lblchassi.Text = "Chassi";
            // 
            // lblfabricante
            // 
            this.lblfabricante.AutoSize = true;
            this.lblfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblfabricante.Location = new System.Drawing.Point(17, 82);
            this.lblfabricante.Name = "lblfabricante";
            this.lblfabricante.Size = new System.Drawing.Size(148, 20);
            this.lblfabricante.TabIndex = 12;
            this.lblfabricante.Text = "Fabricante-Modelo";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblano.Location = new System.Drawing.Point(21, 134);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(38, 20);
            this.lblano.TabIndex = 13;
            this.lblano.Text = "Ano";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblpreco.Location = new System.Drawing.Point(21, 189);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(97, 20);
            this.lblpreco.TabIndex = 14;
            this.lblpreco.Text = "Preço Base";
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblqnt.Location = new System.Drawing.Point(21, 246);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(94, 20);
            this.lblqnt.TabIndex = 15;
            this.lblqnt.Text = "Quantidade";
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 509);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblfabricante);
            this.Controls.Add(this.lblchassi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.tbqntVeiculo);
            this.Controls.Add(this.tbprecoBase);
            this.Controls.Add(this.tbano);
            this.Controls.Add(this.tbfabricante);
            this.Controls.Add(this.tbchassi);
            this.Name = "CadVeiculo";
            this.Text = "Cadastro Veiculo";
            this.Load += new System.EventHandler(this.CadVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbchassi;
        private System.Windows.Forms.TextBox tbfabricante;
        private System.Windows.Forms.TextBox tbano;
        private System.Windows.Forms.TextBox tbprecoBase;
        private System.Windows.Forms.TextBox tbqntVeiculo;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblchassi;
        private System.Windows.Forms.Label lblfabricante;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblqnt;
    }
}