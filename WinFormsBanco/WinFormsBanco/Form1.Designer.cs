namespace WinFormsBanco
{
    partial class Form1
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
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbsalario = new System.Windows.Forms.TextBox();
            this.btinserir = new System.Windows.Forms.Button();
            this.btexibir = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbcpf
            // 
            this.mtbcpf.BackColor = System.Drawing.Color.AliceBlue;
            this.mtbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mtbcpf.Location = new System.Drawing.Point(134, 12);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(142, 26);
            this.mtbcpf.TabIndex = 1;
            this.mtbcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbcpf_MaskInputRejected);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(12, 253);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(520, 118);
            this.dGV.TabIndex = 1;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellContentClick);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblcpf.Location = new System.Drawing.Point(13, 12);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(42, 20);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF";
            this.lblcpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblnome.Location = new System.Drawing.Point(13, 64);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 20);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "NOME";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblsalario.Location = new System.Drawing.Point(13, 134);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(81, 20);
            this.lblsalario.TabIndex = 4;
            this.lblsalario.Text = "SALARIO";
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbnome.Location = new System.Drawing.Point(134, 66);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(142, 26);
            this.tbnome.TabIndex = 2;
            // 
            // tbsalario
            // 
            this.tbsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbsalario.Location = new System.Drawing.Point(134, 136);
            this.tbsalario.Name = "tbsalario";
            this.tbsalario.Size = new System.Drawing.Size(142, 26);
            this.tbsalario.TabIndex = 3;
            // 
            // btinserir
            // 
            this.btinserir.Location = new System.Drawing.Point(160, 186);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(97, 34);
            this.btinserir.TabIndex = 5;
            this.btinserir.Text = "INSERIR";
            this.btinserir.UseVisualStyleBackColor = true;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // btexibir
            // 
            this.btexibir.Location = new System.Drawing.Point(27, 186);
            this.btexibir.Name = "btexibir";
            this.btexibir.Size = new System.Drawing.Size(97, 34);
            this.btexibir.TabIndex = 4;
            this.btexibir.Text = "EXIBIR";
            this.btexibir.UseVisualStyleBackColor = true;
            this.btexibir.Click += new System.EventHandler(this.btexibir_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Location = new System.Drawing.Point(292, 186);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(97, 34);
            this.btatualizar.TabIndex = 6;
            this.btatualizar.Text = "ATUALIZAR";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(421, 186);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(97, 34);
            this.btexcluir.TabIndex = 7;
            this.btexcluir.Text = "EXCLUIR";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 395);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btexibir);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.tbsalario);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.mtbcpf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbsalario;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btexibir;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Button btexcluir;
    }
}

