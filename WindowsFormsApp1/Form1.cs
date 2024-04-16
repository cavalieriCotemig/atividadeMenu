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

        private void ex05pag38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objTela = new Form2();
            objTela.ShowDialog();



        }

        private void ex06PagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 objTela = new Form3();
            objTela.ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 objTela = new Form4();
            objTela.ShowDialog();
        }

        private void ex15pag16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 objTela = new Form5();
            objTela.ShowDialog();
        }

        private void ex13pag39ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 objTela = new Form6();
            objTela.ShowDialog();
        }
    }
}
