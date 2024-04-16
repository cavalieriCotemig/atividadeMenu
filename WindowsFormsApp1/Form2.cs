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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Variaveis
            int numero = int.Parse(txtNum.Text);
            int resto;

            //Entrada de dados
            resto = numero % 3;

            //Processamento de dados
            if (resto == 0)
            {
                MessageBox.Show(numero + " É multiplo de 3");
            }
            else
            {
                MessageBox.Show(numero + " Não é multiplo de 3.");
            }
        }
    }
}
