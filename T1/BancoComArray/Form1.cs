using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M009.BancoComArray.Contas;
using M009.BancoComArray.Extra;
using M009.BancoComArray.Usuario;
using BancoComArray;

namespace M009.BancoComArray
{
    public partial class Form1 : Form
    {
        private int quantconta;
        private Conta[] conta = new Conta[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            quantconta = 0;

            this.conta[quantconta] = new ContaCorrente();
            this.conta[0].Titular.Nome = "José";
            this.conta[0].Numero = 1;
            this.conta[0].Deposita(500);
            quantconta++;

            this.conta[quantconta] = new ContaPoupanca();
            this.conta[1].Titular.Nome = "Joao";
            this.conta[1].Numero = 2;
            this.conta[1].Deposita(800);
            quantconta++;

            this.conta[quantconta] = new ContaPoupanca();
            this.conta[2].Titular.Nome = "Pedro";
            this.conta[2].Numero = 3;
            this.conta[2].Deposita(1000);
            quantconta++;

            
            for (int i = 0; i <= 2; i++)
            {

                comboConta.Items.Add(this.conta[i].Titular.Nome);
                comboDestino.Items.Add(this.conta[i].Titular.Nome);
            }
        }

        private void comboConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboConta.SelectedIndex;

            Conta contaSelecionada = this.conta[index];
           
            AtualizaTela();


        }

        private void botSaque_Click(object sender, EventArgs e)
        {
            int index = comboConta.SelectedIndex;
            Conta contaSelecionada = this.conta[index];

            string valorinformado = textValor.Text;
            double valorsaque = Convert.ToDouble(valorinformado);

            contaSelecionada.Saque(valorsaque);
            AtualizaTela();


        }

        private void botDeposito_Click(object sender, EventArgs e)
        {
            int index = comboConta.SelectedIndex;
            string valorinformado = textValor.Text;
            double valordeposito = Convert.ToDouble(valorinformado);

            Conta contaSelecionada = this.conta[index];

            contaSelecionada.Deposita(valordeposito);
            AtualizaTela();
            

        }

        private void AtualizaTela()
        {

            int index = comboConta.SelectedIndex;

            Conta contaSelecionada = this.conta[index];


            textNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textTitular.Text = Convert.ToString(contaSelecionada.Titular.Nome);


        }

        private void botTransferir_Click(object sender, EventArgs e)
        {
            int index = comboConta.SelectedIndex;
            int indexD = comboDestino.SelectedIndex;
            string valorinformado = textValorTransferencia.Text;
            double valordeposito = Convert.ToDouble(valorinformado);

            Conta contaSelecionada = this.conta[index];
            Conta contaDestino = this.conta[indexD];

            contaSelecionada.Transfere(valordeposito,contaDestino);
            AtualizaTela();


        }

        private void botCadastra_Click(object sender, EventArgs e)
        {
            if (quantconta < 5)
            {

                Cadastro cadastro = new Cadastro(this);
                cadastro.ShowDialog();

            }
            else {

                MessageBox.Show("Numero maximo de contas atingido");

            }
        }

        public void AdcicionaConta(Conta conta) {

            this.conta[this.quantconta] = conta;
            this.quantconta++;

            comboConta.Items.Add(conta.Titular.Nome);
            comboDestino.Items.Add(conta.Titular.Nome);
        }

    }
}
