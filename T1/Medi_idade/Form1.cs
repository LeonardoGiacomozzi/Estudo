using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medi_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i_ana = 19, i_matheus = 21, i_iuri = 20;

            MessageBox.Show("A media de idade entre os tres é " + ((i_ana + i_iuri + i_matheus) / 3));

        }
    }
}
