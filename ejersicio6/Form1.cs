namespace ejersicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar opciones al ComboBox
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.SelectedItem.ToString() == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.SelectedItem.ToString() == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}