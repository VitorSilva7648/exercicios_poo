namespace WinFormsCalc
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.btcalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.tbresultado = new System.Windows.Forms.TextBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(30, 43);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(82, 20);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Numero 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(30, 101);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(82, 20);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Numero 2";
            // 
            // btcalcular
            // 
            this.btcalcular.Location = new System.Drawing.Point(12, 165);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(109, 41);
            this.btcalcular.TabIndex = 2;
            this.btcalcular.Text = "Multiplica";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(130, 37);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(155, 26);
            this.tbnum1.TabIndex = 0;
            // 
            // tbnum2
            // 
            this.tbnum2.Location = new System.Drawing.Point(131, 95);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(155, 26);
            this.tbnum2.TabIndex = 1;
            // 
            // tbresultado
            // 
            this.tbresultado.Location = new System.Drawing.Point(131, 248);
            this.tbresultado.Name = "tbresultado";
            this.tbresultado.Size = new System.Drawing.Size(155, 26);
            this.tbresultado.TabIndex = 6;
            this.tbresultado.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(274, 165);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(109, 41);
            this.btlimpar.TabIndex = 4;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(141, 165);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(109, 41);
            this.btdiv.TabIndex = 3;
            this.btdiv.Text = "Divisão";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 313);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.tbresultado);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Multiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.TextBox tbresultado;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btdiv;
    }
}

