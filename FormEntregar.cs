using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawio
{
    public partial class FormEntregar : Form
    {
        public Alquiler AlquilerSeleccionado;

        public FormEntregar(Alquiler alquiler)
        {
            InitializeComponent();
            AlquilerSeleccionado = alquiler;
            txtPlaca.Text = AlquilerSeleccionado.Vehiculo.Placa;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

            double valorPagar = 1000;
            double adicional = 0;
            // Los montos adicionales se cobran sobre la cantidad de kilómetros excedidos
            // y se cobra además un iva del 12% sobre el total a pagar.
            double iva = 0.12;

            if (int.TryParse(txtKilometros.Text, out int kilometros))
            {
                // se cobra un monto adicional del 2% si la cantidad de
                // kilómetros recorridos es mayor que 100 km  y menor que 301 km
                if (kilometros > 100 && kilometros < 301)
                {
                    adicional = 0.02;
                }

                // se cobra un monto adicional del 3.5% si la cantidad de kilómetros está entre 301 y 999 km
                else if (kilometros >= 301 && kilometros <= 999)
                {
                    adicional = 0.035;
                }

                // calculamos el iva a pagar total
                double totalIva = valorPagar * iva;
                // Calculamos el adicional total
                double totalAdicional = valorPagar * adicional;
                // sumamos totales
                valorPagar += totalIva + totalAdicional;

            }
            else
            {
                // La conversión falló, muestra un mensaje de error
                MessageBox.Show("¡Papi, ingresame los kilometros!, que sean enteros ome.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AlquilerSeleccionado.Vehiculo.Disponible = true;
            AlquilerSeleccionado.ValorPagar = valorPagar;

            MessageBox.Show($"¡Papi, su cliente paga {valorPagar}!", "Todo correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
