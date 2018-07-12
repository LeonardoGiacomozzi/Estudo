using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_imposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salario = 1000;

            if (salario < 1000)
            {

                MessageBox.Show("O valor do imposto é R$" + (salario * 0.02));

            }
            else if (salario >= 1000 && salario < 3000)
            {

                MessageBox.Show("O valor do imposto é R$" + (salario * 0.025));

            }
            else if (salario >= 3000 && salario < 7000)
            {

                MessageBox.Show("O valor do imposto é R$" + (salario * 0.028));

            }
            else
            {

                MessageBox.Show("O valor do imposto é R$" + (salario * 0.03));

            }
        }
    }
}
