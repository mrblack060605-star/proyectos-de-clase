namespace Ejersicio2._5
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

            if (numero <= 1)
            {
                MessageBox.Show("❌ No es primo");
                return;
            }

            bool esPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
                MessageBox.Show("✅ El número ES primo");
            else
                MessageBox.Show("❌ El número NO es primo");
        }
    }
}
