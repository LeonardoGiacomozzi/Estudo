using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int antigo = 0, atual = 1,proximo=0;
            string Fibonacci = "";
            while (atual < 100) {

                proximo = atual + antigo;

                Fibonacci += atual + " ";

                antigo = atual;

                atual = proximo;


            }

            MessageBox.Show("O numero Fibonacci é " + Fibonacci);
        }
    }
}
