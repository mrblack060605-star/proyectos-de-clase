using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroPersonas f = new FormRegistroPersonas();
            f.MdiParent = this;
            f.Show();
        }

        private void conversorDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDivisas f = new FormDivisas();
            f.MdiParent = this;
            f.Show();

        }

        private void serieFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacci f = new FormFibonacci();
            f.MdiParent = this;
            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
