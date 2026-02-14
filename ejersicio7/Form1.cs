namespace ejersicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear(); // limpia la caja de texto
                textBox1.Focus(); // vuelve a escribir
            }
            else
            {
                MessageBox.Show("Ingrese un elemento");
            }
        }
    }
    }

