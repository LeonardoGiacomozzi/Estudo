using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto_Div
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int a=1; a<=30; a++) {

                if (a % 3 == 0) {

                    MessageBox.Show(a+" é divisivel por 3");

                }

                if (a % 4 == 0) {

                    MessageBox.Show(a+" é divisivel por 4");

                }

            }
        }

    }
}
