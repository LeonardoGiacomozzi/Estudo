using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldo = 100, saque = 110;
            bool podesacar = (saldo >= saque) && (saldo > 0);

            if (podesacar)
            {
                saldo = saldo - saque;
                MessageBox.Show("Saque realizado com sucesso");

            }
            else
            {

                MessageBox.Show("!!SALDO INSUFICIENTE!!!");

            }
        }
    }
}
