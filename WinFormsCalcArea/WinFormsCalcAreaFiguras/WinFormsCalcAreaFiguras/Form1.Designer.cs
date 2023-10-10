namespace WinFormsCalcAreaFiguras
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
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbLosango = new System.Windows.Forms.RadioButton();
            this.rbHexagono = new System.Windows.Forms.RadioButton();
            this.rbTrapezio = new System.Windows.Forms.RadioButton();
            this.rbPentagono = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbBranco = new System.Windows.Forms.RadioButton();
            this.lblFormas = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagens
            // 
            this.pbImagens.Image = global::WinFormsCalcAreaFiguras.Properties.Resources.branco;
            this.pbImagens.Location = new System.Drawing.Point(12, 12);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(281, 243);
            this.pbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagens.TabIndex = 0;
            this.pbImagens.TabStop = false;
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbQuadrado.Location = new System.Drawing.Point(364, 66);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(100, 24);
            this.rbQuadrado.TabIndex = 1;
            this.rbQuadrado.TabStop = true;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbRetangulo.Location = new System.Drawing.Point(505, 66);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(102, 24);
            this.rbRetangulo.TabIndex = 2;
            this.rbRetangulo.TabStop = true;
            this.rbRetangulo.Text = "Retangulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            // 
            // rbLosango
            // 
            this.rbLosango.AutoSize = true;
            this.rbLosango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbLosango.Location = new System.Drawing.Point(505, 107);
            this.rbLosango.Name = "rbLosango";
            this.rbLosango.Size = new System.Drawing.Size(91, 24);
            this.rbLosango.TabIndex = 4;
            this.rbLosango.TabStop = true;
            this.rbLosango.Text = "Losango";
            this.rbLosango.UseVisualStyleBackColor = true;
            // 
            // rbHexagono
            // 
            this.rbHexagono.AutoSize = true;
            this.rbHexagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbHexagono.Location = new System.Drawing.Point(364, 107);
            this.rbHexagono.Name = "rbHexagono";
            this.rbHexagono.Size = new System.Drawing.Size(102, 24);
            this.rbHexagono.TabIndex = 3;
            this.rbHexagono.TabStop = true;
            this.rbHexagono.Text = "Hexagono";
            this.rbHexagono.UseVisualStyleBackColor = true;
            // 
            // rbTrapezio
            // 
            this.rbTrapezio.AutoSize = true;
            this.rbTrapezio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbTrapezio.Location = new System.Drawing.Point(505, 148);
            this.rbTrapezio.Name = "rbTrapezio";
            this.rbTrapezio.Size = new System.Drawing.Size(92, 24);
            this.rbTrapezio.TabIndex = 6;
            this.rbTrapezio.TabStop = true;
            this.rbTrapezio.Text = "Trapezio";
            this.rbTrapezio.UseVisualStyleBackColor = true;
            // 
            // rbPentagono
            // 
            this.rbPentagono.AutoSize = true;
            this.rbPentagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbPentagono.Location = new System.Drawing.Point(364, 148);
            this.rbPentagono.Name = "rbPentagono";
            this.rbPentagono.Size = new System.Drawing.Size(106, 24);
            this.rbPentagono.TabIndex = 5;
            this.rbPentagono.TabStop = true;
            this.rbPentagono.Text = "Pentagono";
            this.rbPentagono.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbTriangulo.Location = new System.Drawing.Point(505, 188);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(96, 24);
            this.rbTriangulo.TabIndex = 8;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbCirculo.Location = new System.Drawing.Point(364, 188);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(80, 24);
            this.rbCirculo.TabIndex = 7;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            // 
            // rbBranco
            // 
            this.rbBranco.AutoSize = true;
            this.rbBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbBranco.Location = new System.Drawing.Point(654, 23);
            this.rbBranco.Name = "rbBranco";
            this.rbBranco.Size = new System.Drawing.Size(81, 24);
            this.rbBranco.TabIndex = 0;
            this.rbBranco.TabStop = true;
            this.rbBranco.Text = "Branco";
            this.rbBranco.UseVisualStyleBackColor = true;
            this.rbBranco.Visible = false;
            // 
            // lblFormas
            // 
            this.lblFormas.AutoSize = true;
            this.lblFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFormas.Location = new System.Drawing.Point(456, 23);
            this.lblFormas.Name = "lblFormas";
            this.lblFormas.Size = new System.Drawing.Size(80, 20);
            this.lblFormas.TabIndex = 19;
            this.lblFormas.Text = "FORMAS";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btCalcular.Location = new System.Drawing.Point(364, 231);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 38);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btLimpar.Location = new System.Drawing.Point(505, 231);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(100, 38);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 360);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 76);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(26, 460);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(581, 76);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(100, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBase.Location = new System.Drawing.Point(23, 278);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(48, 20);
            this.lblBase.TabIndex = 23;
            this.lblBase.Text = "Base";
            this.lblBase.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAltura.Location = new System.Drawing.Point(23, 315);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(53, 20);
            this.lblAltura.TabIndex = 25;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox2.Location = new System.Drawing.Point(100, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 26);
            this.textBox2.TabIndex = 24;
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 548);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblFormas);
            this.Controls.Add(this.rbBranco);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.rbTrapezio);
            this.Controls.Add(this.rbPentagono);
            this.Controls.Add(this.rbLosango);
            this.Controls.Add(this.rbHexagono);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.rbQuadrado);
            this.Controls.Add(this.pbImagens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbLosango;
        private System.Windows.Forms.RadioButton rbHexagono;
        private System.Windows.Forms.RadioButton rbTrapezio;
        private System.Windows.Forms.RadioButton rbPentagono;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbBranco;
        private System.Windows.Forms.Label lblFormas;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox textBox2;
    }
}

