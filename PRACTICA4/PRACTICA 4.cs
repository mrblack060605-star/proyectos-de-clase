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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
        {
            try
            {
                int limite = int.Parse(txtLimite.Text);
                txtResultado.Clear();

                int a = 0;
                int b = 1;

                txtResultado.AppendText(a.ToString() + Environment.NewLine);
                if (limite >= 1)
                    txtResultado.AppendText(b.ToString() + Environment.NewLine);

                int siguiente = a + b;

                while (siguiente <= limite)
                {
                    txtResultado.AppendText(siguiente.ToString() + Environment.NewLine);
                    a = b;
                    b = siguiente;
                    siguiente = a + b;
                }
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }
    }
    }
}
