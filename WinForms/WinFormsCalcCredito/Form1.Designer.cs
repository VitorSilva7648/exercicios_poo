namespace WinFormsCalcCredito
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
            this.btcalcular = new System.Windows.Forms.Button();
            this.rbPf = new System.Windows.Forms.RadioButton();
            this.lvPf = new System.Windows.Forms.ListView();
            this.rbPj = new System.Windows.Forms.RadioButton();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblQtdfilhos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lvPj = new System.Windows.Forms.ListView();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNomefantasia = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbNomefantasia = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbQtdfilhos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcalcular
            // 
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btcalcular.Location = new System.Drawing.Point(137, 330);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(105, 29);
            this.btcalcular.TabIndex = 9;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbPf
            // 
            this.rbPf.AutoSize = true;
            this.rbPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbPf.Location = new System.Drawing.Point(31, 12);
            this.rbPf.Name = "rbPf";
            this.rbPf.Size = new System.Drawing.Size(124, 24);
            this.rbPf.TabIndex = 1;
            this.rbPf.TabStop = true;
            this.rbPf.Text = "Pesoa Fisica";
            this.rbPf.UseVisualStyleBackColor = true;
            this.rbPf.CheckedChanged += new System.EventHandler(this.radbut1_CheckedChanged);
            // 
            // lvPf
            // 
            this.lvPf.HideSelection = false;
            this.lvPf.Location = new System.Drawing.Point(31, 388);
            this.lvPf.Name = "lvPf";
            this.lvPf.Size = new System.Drawing.Size(545, 87);
            this.lvPf.TabIndex = 2;
            this.lvPf.UseCompatibleStateImageBehavior = false;
            // 
            // rbPj
            // 
            this.rbPj.AutoSize = true;
            this.rbPj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbPj.Location = new System.Drawing.Point(326, 12);
            this.rbPj.Name = "rbPj";
            this.rbPj.Size = new System.Drawing.Size(138, 24);
            this.rbPj.TabIndex = 2;
            this.rbPj.TabStop = true;
            this.rbPj.Text = "Pesoa Juridica";
            this.rbPj.UseVisualStyleBackColor = true;
            this.rbPj.CheckedChanged += new System.EventHandler(this.rbPj_CheckedChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCpf.Location = new System.Drawing.Point(36, 73);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 20);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mtbCpf.Location = new System.Drawing.Point(220, 73);
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(201, 26);
            this.mtbCpf.TabIndex = 3;
            this.mtbCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCpf_MaskInputRejected);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNome.Location = new System.Drawing.Point(36, 114);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "NOME";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCidade.Location = new System.Drawing.Point(36, 154);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(73, 20);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "CIDADE";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblQtdfilhos
            // 
            this.lblQtdfilhos.AutoSize = true;
            this.lblQtdfilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblQtdfilhos.Location = new System.Drawing.Point(36, 197);
            this.lblQtdfilhos.Name = "lblQtdfilhos";
            this.lblQtdfilhos.Size = new System.Drawing.Size(140, 20);
            this.lblQtdfilhos.TabIndex = 6;
            this.lblQtdfilhos.Text = "QTD DE FILHOS";
            this.lblQtdfilhos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(326, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lvPj
            // 
            this.lvPj.HideSelection = false;
            this.lvPj.Location = new System.Drawing.Point(31, 506);
            this.lvPj.Name = "lvPj";
            this.lvPj.Size = new System.Drawing.Size(545, 76);
            this.lvPj.TabIndex = 13;
            this.lvPj.UseCompatibleStateImageBehavior = false;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSalario.Location = new System.Drawing.Point(36, 245);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(81, 20);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "SALÁRIO";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNomefantasia
            // 
            this.lblNomefantasia.AutoSize = true;
            this.lblNomefantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomefantasia.Location = new System.Drawing.Point(36, 283);
            this.lblNomefantasia.Name = "lblNomefantasia";
            this.lblNomefantasia.Size = new System.Drawing.Size(144, 20);
            this.lblNomefantasia.TabIndex = 16;
            this.lblNomefantasia.Text = "NOME FANTASIA";
            this.lblNomefantasia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbNome.Location = new System.Drawing.Point(220, 114);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(201, 26);
            this.tbNome.TabIndex = 4;
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbCidade.Location = new System.Drawing.Point(220, 151);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(201, 26);
            this.tbCidade.TabIndex = 5;
            // 
            // tbNomefantasia
            // 
            this.tbNomefantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbNomefantasia.Location = new System.Drawing.Point(220, 277);
            this.tbNomefantasia.Name = "tbNomefantasia";
            this.tbNomefantasia.Size = new System.Drawing.Size(201, 26);
            this.tbNomefantasia.TabIndex = 8;
            // 
            // tbSalario
            // 
            this.tbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbSalario.Location = new System.Drawing.Point(220, 239);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(201, 26);
            this.tbSalario.TabIndex = 7;
            // 
            // tbQtdfilhos
            // 
            this.tbQtdfilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbQtdfilhos.Location = new System.Drawing.Point(220, 191);
            this.tbQtdfilhos.Name = "tbQtdfilhos";
            this.tbQtdfilhos.Size = new System.Drawing.Size(201, 26);
            this.tbQtdfilhos.TabIndex = 6;
            this.tbQtdfilhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdfilhos_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 608);
            this.Controls.Add(this.tbQtdfilhos);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbNomefantasia);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNomefantasia);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lvPj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQtdfilhos);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.rbPj);
            this.Controls.Add(this.lvPf);
            this.Controls.Add(this.rbPf);
            this.Controls.Add(this.btcalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Sistema de Gestão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.RadioButton rbPf;
        private System.Windows.Forms.ListView lvPf;
        private System.Windows.Forms.RadioButton rbPj;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblQtdfilhos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvPj;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNomefantasia;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbNomefantasia;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbQtdfilhos;
    }
}

