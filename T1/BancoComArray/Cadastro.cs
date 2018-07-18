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
using M009.BancoComArray;


namespace BancoComArray
{
    public partial class Cadastro : Form
    {
        private Form1 aplicacaoprincipal;
        private Conta conta;
       
        
        public Cadastro(Form1 aplicacaoprincipal)
        {
            this.aplicacaoprincipal = aplicacaoprincipal;

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titular = textTitular.Text;

            int numero = Convert.ToInt32(textNumero.Text);

            
            conta.Titular.Nome = titular;
            conta.Numero = numero;

            this.aplicacaoprincipal.AdcicionaConta(conta);

           
        }

        

        private void Cadastro_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Corrente");
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoConta.SelectedIndex == 0)
            {

               conta = new ContaPoupanca();

            }
            else {

               conta = new ContaCorrente();


            }
        }
    }
}
