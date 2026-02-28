namespace practica_3._2
{
    public partial class Form1 : Form
    {
        // Arreglos para almacenar los datos
        string[] codigos = new string[100];
        string[] nombres = new string[100];
        double[] promedios = new double[100];

        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío, no hace nada
        }

        // BOTÓN REGISTRAR
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (contador >= 100)
            {
                MessageBox.Show("Límite alcanzado (100 alumnos)");
                return;
            }

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!double.TryParse(txtPromedio.Text, out double promedio))
            {
                MessageBox.Show("Ingrese un promedio válido");
                return;
            }

            codigos[contador] = txtCodigo.Text;
            nombres[contador] = txtNombre.Text;
            promedios[contador] = promedio;

            contador++;

            MostrarDatos();
            Limpiar();
        }

        // BOTÓN ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)


        {
            string codigoEliminar = txtCodigo.Text.Trim(); // elimina espacios
            if (codigoEliminar == "")
            {
                MessageBox.Show("Ingrese un código para eliminar");
                return;
            }

            int posicion = -1;

            // Buscar el índice del código a eliminar
            for (int i = 0; i < contador; i++)
            {
                if (codigos[i].Equals(codigoEliminar, StringComparison.OrdinalIgnoreCase))
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                MessageBox.Show("Alumno no encontrado");
                return;
            }

            // Mover todos los elementos hacia atrás para eliminar
            for (int i = posicion; i < contador - 1; i++)
            {
                codigos[i] = codigos[i + 1];
                nombres[i] = nombres[i + 1];
                promedios[i] = promedios[i + 1];
            }

            contador--;

            MostrarDatos(); // actualizar DataGridView
            Limpiar();

            MessageBox.Show("Alumno eliminado correctamente");
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (promedios[i] > promedios[j])
                    {
                        // Intercambiar promedio
                        double auxProm = promedios[i];
                        promedios[i] = promedios[j];
                        promedios[j] = auxProm;

                        // Intercambiar nombre
                        string auxNom = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNom;

                        // Intercambiar código
                        string auxCod = codigos[i];
                        codigos[i] = codigos[j];
                        codigos[j] = auxCod;
                    }
                }
            }

            MostrarDatos();
            MessageBox.Show("Ordenado por promedio");
        }

        // BOTÓN BUSCAR POR CÓDIGO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtBuscar.Text;
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    MessageBox.Show(
                        "Código: " + codigos[i] +
                        "\nNombre: " + nombres[i] +
                        "\nPromedio: " + promedios[i]);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                MessageBox.Show("Alumno no encontrado");
        }

        // Muestra los datos en el DataGridView
        private void MostrarDatos()
        {
            dgvAlumnos.Rows.Clear();

            for (int i = 0; i < contador; i++)
            {
                dgvAlumnos.Rows.Add(codigos[i], nombres[i], promedios[i]);
            }
        }

        // Limpia los TextBox
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPromedio.Clear();
            txtCodigo.Focus();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string codigoEliminar = txtCodigo.Text.Trim(); // elimina espacios
            if (codigoEliminar == "")
            {
                MessageBox.Show("Ingrese un código para eliminar");
                return;
            }

            int posicion = -1;

            // Buscar el índice del código a eliminar
            for (int i = 0; i < contador; i++)
            {
                if (codigos[i].Equals(codigoEliminar, StringComparison.OrdinalIgnoreCase))
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
            {
                MessageBox.Show("Alumno no encontrado");
                return;
            }

            // Mover todos los elementos hacia atrás para eliminar
            for (int i = posicion; i < contador - 1; i++)
            {
                codigos[i] = codigos[i + 1];
                nombres[i] = nombres[i + 1];
                promedios[i] = promedios[i + 1];
            }

            contador--;

            MostrarDatos(); // 🔹 MUY IMPORTANTE: actualizar DataGridView
            Limpiar();

            MessageBox.Show("Alumno eliminado correctamente");
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (promedios[i] < promedios[j]) // MAYOR A MENOR
                    {
                        double auxProm = promedios[i];
                        promedios[i] = promedios[j];
                        promedios[j] = auxProm;

                        string auxNom = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = auxNom;

                        string auxCod = codigos[i];
                        codigos[i] = codigos[j];
                        codigos[j] = auxCod;
                    }
                }
            }

            MostrarDatos();
            MessageBox.Show("Ordenado de mayor a menor por promedio");
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string codigoBuscar = txtBuscar.Text.Trim();
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (codigos[i].Equals(codigoBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Código: " + codigos[i] +
                        "\nNombre: " + nombres[i] +
                        "\nPromedio: " + promedios[i]);

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                MessageBox.Show("Alumno no encontrado");
        }
    }
    }

