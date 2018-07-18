namespace M009.BancoComArray
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
            this.comboConta = new System.Windows.Forms.ComboBox();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.botSaque = new System.Windows.Forms.Button();
            this.botDeposito = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textValorTransferencia = new System.Windows.Forms.TextBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.botTransferir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botCadastra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboConta
            // 
            this.comboConta.FormattingEnabled = true;
            this.comboConta.Location = new System.Drawing.Point(103, 12);
            this.comboConta.Name = "comboConta";
            this.comboConta.Size = new System.Drawing.Size(121, 21);
            this.comboConta.TabIndex = 0;
            this.comboConta.SelectedIndexChanged += new System.EventHandler(this.comboConta_SelectedIndexChanged);
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(56, 59);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 1;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(56, 85);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 2;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(56, 111);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 3;
            // 
            // botSaque
            // 
            this.botSaque.Location = new System.Drawing.Point(47, 194);
            this.botSaque.Name = "botSaque";
            this.botSaque.Size = new System.Drawing.Size(82, 23);
            this.botSaque.TabIndex = 4;
            this.botSaque.Text = "Sacar";
            this.botSaque.UseVisualStyleBackColor = true;
            this.botSaque.Click += new System.EventHandler(this.botSaque_Click);
            // 
            // botDeposito
            // 
            this.botDeposito.Location = new System.Drawing.Point(161, 194);
            this.botDeposito.Name = "botDeposito";
            this.botDeposito.Size = new System.Drawing.Size(74, 23);
            this.botDeposito.TabIndex = 5;
            this.botDeposito.Text = "Deposito";
            this.botDeposito.UseVisualStyleBackColor = true;
            this.botDeposito.Click += new System.EventHandler(this.botDeposito_Click);
            // 
            // textValor
            // 
            this.textValor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textValor.Location = new System.Drawing.Point(47, 168);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(188, 20);
            this.textValor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleciona Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo";
            // 
            // textValorTransferencia
            // 
            this.textValorTransferencia.Location = new System.Drawing.Point(390, 73);
            this.textValorTransferencia.Name = "textValorTransferencia";
            this.textValorTransferencia.Size = new System.Drawing.Size(100, 20);
            this.textValorTransferencia.TabIndex = 11;
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(390, 37);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(121, 21);
            this.comboDestino.TabIndex = 12;
            // 
            // botTransferir
            // 
            this.botTransferir.Location = new System.Drawing.Point(390, 99);
            this.botTransferir.Name = "botTransferir";
            this.botTransferir.Size = new System.Drawing.Size(75, 23);
            this.botTransferir.TabIndex = 13;
            this.botTransferir.Text = "Transferir";
            this.botTransferir.UseVisualStyleBackColor = true;
            this.botTransferir.Click += new System.EventHandler(this.botTransferir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Conta Destino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor";
            // 
            // botCadastra
            // 
            this.botCadastra.Location = new System.Drawing.Point(292, 194);
            this.botCadastra.Name = "botCadastra";
            this.botCadastra.Size = new System.Drawing.Size(92, 23);
            this.botCadastra.TabIndex = 17;
            this.botCadastra.Text = "Cadastrar Conta";
            this.botCadastra.UseVisualStyleBackColor = true;
            this.botCadastra.Click += new System.EventHandler(this.botCadastra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 259);
            this.Controls.Add(this.botCadastra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botTransferir);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.textValorTransferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.botDeposito);
            this.Controls.Add(this.botSaque);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.comboConta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboConta;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Button botSaque;
        private System.Windows.Forms.Button botDeposito;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValorTransferencia;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Button botTransferir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botCadastra;
    }
}

