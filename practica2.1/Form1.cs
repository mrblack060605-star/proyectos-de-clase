namespace practica2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular(object sender, EventArgs e)
        {
            int numero;

            // Limpiar la lista
            listBox1.Items.Clear();

            // Validar que sea número
            if (int.TryParse(textBox1.Text, out numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    listBox1.Items.Add(numero + " x " + i + " = " + (numero * i));
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido");
            }
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
