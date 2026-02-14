using System.Reflection.Emit;

namespace ejersicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                label1.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("Error: Debe ingresar un número", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

