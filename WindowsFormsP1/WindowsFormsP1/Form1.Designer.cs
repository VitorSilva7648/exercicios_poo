namespace WindowsFormsP1
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
            this.rbonibus = new System.Windows.Forms.RadioButton();
            this.rbcaminhao = new System.Windows.Forms.RadioButton();
            this.listView = new System.Windows.Forms.ListView();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbano = new System.Windows.Forms.TextBox();
            this.tbqnt = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblqnt = new System.Windows.Forms.Label();
            this.mtbplaca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // rbonibus
            // 
            this.rbonibus.AutoSize = true;
            this.rbonibus.Location = new System.Drawing.Point(79, 24);
            this.rbonibus.Name = "rbonibus";
            this.rbonibus.Size = new System.Drawing.Size(80, 24);
            this.rbonibus.TabIndex = 1;
            this.rbonibus.TabStop = true;
            this.rbonibus.Text = "Ônibus";
            this.rbonibus.UseVisualStyleBackColor = true;
            this.rbonibus.CheckedChanged += new System.EventHandler(this.rbonibus_CheckedChanged);
            // 
            // rbcaminhao
            // 
            this.rbcaminhao.AutoSize = true;
            this.rbcaminhao.Location = new System.Drawing.Point(246, 24);
            this.rbcaminhao.Name = "rbcaminhao";
            this.rbcaminhao.Size = new System.Drawing.Size(102, 24);
            this.rbcaminhao.TabIndex = 2;
            this.rbcaminhao.TabStop = true;
            this.rbcaminhao.Text = "Caminhão";
            this.rbcaminhao.UseVisualStyleBackColor = true;
            this.rbcaminhao.CheckedChanged += new System.EventHandler(this.rbcaminhao_CheckedChanged);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 256);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(503, 81);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Location = new System.Drawing.Point(121, 203);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(98, 33);
            this.btcadastrar.TabIndex = 6;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(266, 203);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(98, 33);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(410, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inicio";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // tbano
            // 
            this.tbano.Location = new System.Drawing.Point(158, 107);
            this.tbano.Name = "tbano";
            this.tbano.Size = new System.Drawing.Size(152, 26);
            this.tbano.TabIndex = 4;
            this.tbano.TextChanged += new System.EventHandler(this.tbano_TextChanged);
            // 
            // tbqnt
            // 
            this.tbqnt.Location = new System.Drawing.Point(158, 148);
            this.tbqnt.Name = "tbqnt";
            this.tbqnt.Size = new System.Drawing.Size(152, 26);
            this.tbqnt.TabIndex = 5;
            this.tbqnt.TextChanged += new System.EventHandler(this.tbqnt_TextChanged);
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(101, 64);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(51, 20);
            this.lblplaca.TabIndex = 8;
            this.lblplaca.Text = "Placa";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(114, 113);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(38, 20);
            this.lblano.TabIndex = 9;
            this.lblano.Text = "Ano";
            // 
            // lblqnt
            // 
            this.lblqnt.AutoSize = true;
            this.lblqnt.Location = new System.Drawing.Point(41, 154);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(111, 20);
            this.lblqnt.TabIndex = 10;
            this.lblqnt.Text = "Qnt Assentos";
            // 
            // mtbplaca
            // 
            this.mtbplaca.Location = new System.Drawing.Point(158, 61);
            this.mtbplaca.Name = "mtbplaca";
            this.mtbplaca.Size = new System.Drawing.Size(152, 26);
            this.mtbplaca.TabIndex = 3;
            this.mtbplaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbplaca_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 366);
            this.Controls.Add(this.mtbplaca);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.tbqnt);
            this.Controls.Add(this.tbano);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.rbcaminhao);
            this.Controls.Add(this.rbonibus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cadastro de Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbonibus;
        private System.Windows.Forms.RadioButton rbcaminhao;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbano;
        private System.Windows.Forms.TextBox tbqnt;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblqnt;
        private System.Windows.Forms.MaskedTextBox mtbplaca;
    }
}

