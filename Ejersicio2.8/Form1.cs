namespace Ejersicio2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text.Trim();

            if (oracion == "")
            {
                lblResultado.Text = "La oración no contiene palabras.";
                return;
            }

            // Separar por espacios
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int cantidad = palabras.Length;

            lblResultado.Text = "Cantidad de palabras: " + cantidad;
        }
    }
}
