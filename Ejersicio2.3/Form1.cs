namespace Ejersicio2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar unidades a los ComboBox
            cmbEntrada.Items.Add("Metros");
            cmbEntrada.Items.Add("Centímetros");
            cmbEntrada.Items.Add("Pulgadas");

            cmbSalida.Items.Add("Metros");
            cmbSalida.Items.Add("Centímetros");
            cmbSalida.Items.Add("Pulgadas");

            cmbEntrada.SelectedIndex = 0;
            cmbSalida.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;

            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }

            string unidadEntrada = cmbEntrada.SelectedItem.ToString();
            string unidadSalida = cmbSalida.SelectedItem.ToString();

            // Convertir todo primero a metros
            double valorEnMetros = 0;

            if (unidadEntrada == "Metros")
                valorEnMetros = valor;
            else if (unidadEntrada == "Centímetros")
                valorEnMetros = valor / 100;
            else if (unidadEntrada == "Pulgadas")
                valorEnMetros = valor * 0.0254;

            // Convertir de metros a unidad de salida
            double resultado = 0;

            if (unidadSalida == "Metros")
                resultado = valorEnMetros;
            else if (unidadSalida == "Centímetros")
                resultado = valorEnMetros * 100;
            else if (unidadSalida == "Pulgadas")
                resultado = valorEnMetros / 0.0254;

            lblResultado.Text = "Resultado: " + resultado.ToString("0.00");
        }
    }
}
