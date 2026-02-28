namespace Ejersicio2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(maskedTextBox1.Text, out numero))
            {
                MessageBox.Show("Ingrese un número válido");
                return;
            }

            if (numero <= 0)
            {
                MessageBox.Show("Ingrese un número mayor que 0");
                return;
            }

            int suma = 0;

            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == numero)
            {
                MessageBox.Show("✅ El número ES perfecto");
            }
            else
            {
                MessageBox.Show("❌ El número NO es perfecto");
            }
        }
    }
}