namespace Ejersicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            label1.Text = "Has presionado el botón: " + contador + " veces";
        }

    }
    }

