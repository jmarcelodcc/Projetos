using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Media m = new Media();
            m.comb = double.Parse(textBoxCombustivel.Text);
            m.dista = double.Parse(textBoxDistancia.Text);

            listBoxMedia.Items.Add("O consumo medio da viagem foi de :" + m.Calculo());
        }
    }
}
