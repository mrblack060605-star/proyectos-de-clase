using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4_Formularios
{
    public partial class FormRegistroPersonas : Form
    {
        public FormRegistroPersonas()
        {
            InitializeComponent();
        }

        private void FormRegistroPersonas_Load(object sender, EventArgs e)
        {
            
        {
            dataGridView1.ColumnCount = 12;

            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Edad";
            dataGridView1.Columns[3].Name = "Sexo";
            dataGridView1.Columns[4].Name = "Telefono";
            dataGridView1.Columns[5].Name = "Correo";
            dataGridView1.Columns[6].Name = "Direccion";
            dataGridView1.Columns[7].Name = "Ciudad";
            dataGridView1.Columns[8].Name = "Pais";
            dataGridView1.Columns[9].Name = "Estado Civil";
            dataGridView1.Columns[10].Name = "Profesion";
            dataGridView1.Columns[11].Name = "Cedula";
        }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        {
            dataGridView1.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtEdad.Text,
                txtSexo.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text,
                txtCiudad.Text,
                txtPais.Text,
                txtEstadoCivil.Text,
                txtProfesion.Text,
                txtCedula.Text
            );
        }
    }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
                txtNombre.Text = "";
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.Text = "Nombre";
        }
    }
    }

