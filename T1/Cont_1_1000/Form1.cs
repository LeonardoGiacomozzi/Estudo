using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cont_1_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, c = 0;

            for (i = 0; i <= 1000; i++)
            {

                c += i;

            }

            MessageBox.Show("A soma de 1 ate 1000 é " + c);

        }
    }
}
