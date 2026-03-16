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
    public partial class FormDivisas : Form
    {
        public FormDivisas()
        {
            InitializeComponent();
        }

        private void Monto_Click(object sender, EventArgs e)
        {

        }

        private void FormDivisas_Load(object sender, EventArgs e)
        {
           
        {
            string[] monedas = {
        "Dólar (USD)",
        "Euro (EUR)",
        "Peso Dominicano (DOP)",
        "Peso Mexicano (MXN)",
        "Libra Esterlina (GBP)",
        "Yen Japonés (JPY)",
        "Franco Suizo (CHF)",
        "Peso Colombiano (COP)",
        "Dólar Canadiense (CAD)",
        "Dólar Australiano (AUD)",
        "Yuan Chino (CNY)",
        "Corona Sueca (SEK)",
        "Corona Noruega (NOK)",
        "Rupia India (INR)",
        "Real Brasileño (BRL)"
    };

            foreach (string m in monedas)
            {
                comboOrigen.Items.Add(m);
                comboDestino.Items.Add(m);
            }
        }

     
    }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
      
        {
            try
            {
                // Convertir el monto usando CultureInfo.InvariantCulture para aceptar punto o coma
                double monto = double.Parse(txtMonto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                // Definir tasas respecto a 1 USD
                Dictionary<string, double> tasas = new Dictionary<string, double>()
        {
            {"Dólar (USD)", 1},
            {"Euro (EUR)", 0.92},
            {"Peso Dominicano (DOP)", 59},
            {"Peso Mexicano (MXN)", 17},
            {"Libra Esterlina (GBP)", 0.78},
            {"Yen Japonés (JPY)", 138},
            {"Franco Suizo (CHF)", 0.91},
            {"Peso Colombiano (COP)", 4600},
            {"Dólar Canadiense (CAD)", 1.36},
            {"Dólar Australiano (AUD)", 1.51},
            {"Yuan Chino (CNY)", 6.9},
            {"Corona Sueca (SEK)", 11.0},
            {"Corona Noruega (NOK)", 11.1},
            {"Rupia India (INR)", 83.0},
            {"Real Brasileño (BRL)", 5.2}
        };

                string origen = comboOrigen.Text;
                string destino = comboDestino.Text;

                // Convertir primero a USD
                double montoEnUSD = monto / tasas[origen];

                // Luego a la moneda destino
                double resultado = montoEnUSD * tasas[destino];

                lblResultado.Text = "Resultado: " + resultado.ToString("N2", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un monto válido y seleccione monedas.");
            }
        }

    }
    }
    }

