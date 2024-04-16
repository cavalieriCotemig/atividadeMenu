using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variaveis
            int num;

            //Entrada de dados
            num = int.Parse(txtNumero.Text);

            //Processamento de dados
            if (num % 5 == 0)
            { 
            MessageBox.Show("È divisivel por 5.");
            }
            else
            {
                MessageBox.Show("Não é divisivel por 5 seu burro");
            }
           




        }
    }
}
