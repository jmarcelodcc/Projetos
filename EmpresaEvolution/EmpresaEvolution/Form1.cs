using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaEvolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Salario s = new Salario();

            s.salario = double.Parse(textBoxSalario.Text);

            s.Retorno();

            if (s.salario <= 1256)
            {
                listBox1.Items.Add("O seu novo salario é de : " + (s.salario + s.porce30));
            }
            else if (s.salario >= 1257)
            {
                listBox1.Items.Add("O seu novo salario é de :" + (s.salario + s.porce8));
            }
        }

        private void textBoxSalario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
