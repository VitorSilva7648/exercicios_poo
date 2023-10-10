namespace WinFor_Imc
{
    partial class FormPrincipal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(544, 312);
            this.Controls.Add(this.textBox1);
            this.Name = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox tbImc;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

