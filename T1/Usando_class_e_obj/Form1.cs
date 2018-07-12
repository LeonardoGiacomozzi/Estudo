using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usando_class_e_obj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 conta1 = new Class1();

            conta1.numero = 1;
            conta1.titular = "Jose";
            conta1.saldo = 100;
            conta1.agencia = 0101;
            conta1.cpf = "000.111.222 - 07";


            Class1 conta2 = new Class1();

            conta2.numero = 1;
            conta2.titular = "Joaquim";
            conta2.cpf = "222.111.000-03";
            conta2.agencia = 0101;
            conta2.saldo = 2000;

            MessageBox.Show("O nome do titular é "+conta1.titular);
            MessageBox.Show("O nome do titular da segunda conta  é "+conta2.titular+"\n" +
                "e o cpf dele é "+conta2.cpf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 conta3 = new Class1();

            conta3.numero = 3;
            conta3.titular = "Joao";
            conta3.saldo = 5000;
            conta3.agencia = 0101;
            conta3.cpf = "000.666.222 - 07";

            conta3.saca(500);

            MessageBox.Show("O saldo atual da conta é "+conta3.saldo);

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Class1 conta1 = new Class1();

            conta1.numero = 1;
            conta1.titular = "Jose";
            conta1.saldo = 100;
            conta1.agencia = 0101;
            conta1.cpf = "000.111.222 - 07";


            Class1 conta2 = new Class1();

            conta2.numero = 1;
            conta2.titular = "Joaquim";
            conta2.cpf = "222.111.000-03";
            conta2.agencia = 0101;
            conta2.saldo = 2000;

            conta1.deposito(500);

            MessageBox.Show("O saldo atual da conta é R$ "+conta1.saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Class1 conta1 = new Class1();

            conta1.numero = 1;
            conta1.titular = "Jose";
            conta1.saldo = 1000;
            conta1.agencia = 0101;
            conta1.cpf = "000.111.222 - 07";


            Class1 conta2 = new Class1();

            conta2.numero = 1;
            conta2.titular = "Joaquim";
            conta2.cpf = "222.111.000-03";
            conta2.agencia = 0101;
            conta2.saldo = 2000;

            conta1.tranfere(500,conta2);

            MessageBox.Show("O saldo de " + conta1.titular + " é " + conta1.saldo + "\n" +
                "O saldo de " + conta2.titular + " é " + conta2.saldo);
        }
    }
}
