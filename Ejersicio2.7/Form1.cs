namespace Ejersicio2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int inicio, fin;
            listBox1.Items.Clear();

            if (!int.TryParse(txtInicio.Text, out inicio) ||
                !int.TryParse(txtFin.Text, out fin))
            {
                MessageBox.Show("Ingrese valores numéricos válidos");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El valor de Inicio debe ser menor o igual que Fin");
                return;
            }

            for (int num = inicio; num <= fin; num++)
            {
                if (EsPrimo(num))
                {
                    listBox1.Items.Add(num);
                }
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No hay números primos en ese rango");
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
