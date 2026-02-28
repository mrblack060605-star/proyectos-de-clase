namespace Ejerisicio2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", "");

            if (palabra == "")
            {
                MessageBox.Show("Ingrese una palabra");
                return;
            }

            char[] arreglo = palabra.ToCharArray();
            Array.Reverse(arreglo);
            string palabraInvertida = new string(arreglo);

            if (palabra == palabraInvertida)
            {
                MessageBox.Show("✅ La palabra ES palíndroma");
            }
            else
            {
                MessageBox.Show("❌ La palabra NO es palíndroma");
            }
        }
    }
}