namespace WinFormsPilha
{
    partial class Palindromo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpalavra = new System.Windows.Forms.Label();
            this.tbpalavra = new System.Windows.Forms.TextBox();
            this.btverificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpalavra
            // 
            this.lblpalavra.AutoSize = true;
            this.lblpalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblpalavra.Location = new System.Drawing.Point(12, 33);
            this.lblpalavra.Name = "lblpalavra";
            this.lblpalavra.Size = new System.Drawing.Size(65, 20);
            this.lblpalavra.TabIndex = 0;
            this.lblpalavra.Text = "Palavra";
            // 
            // tbpalavra
            // 
            this.tbpalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbpalavra.Location = new System.Drawing.Point(99, 27);
            this.tbpalavra.Name = "tbpalavra";
            this.tbpalavra.Size = new System.Drawing.Size(180, 26);
            this.tbpalavra.TabIndex = 1;
            // 
            // btverificar
            // 
            this.btverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btverificar.Location = new System.Drawing.Point(298, 26);
            this.btverificar.Name = "btverificar";
            this.btverificar.Size = new System.Drawing.Size(87, 35);
            this.btverificar.TabIndex = 2;
            this.btverificar.Text = "Verificar";
            this.btverificar.UseVisualStyleBackColor = true;
            this.btverificar.Click += new System.EventHandler(this.btverificar_Click);
            // 
            // Palindromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 97);
            this.Controls.Add(this.btverificar);
            this.Controls.Add(this.tbpalavra);
            this.Controls.Add(this.lblpalavra);
            this.Name = "Palindromo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpalavra;
        private System.Windows.Forms.TextBox tbpalavra;
        private System.Windows.Forms.Button btverificar;
    }
}

