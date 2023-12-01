using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawio
{
    public partial class FormAlquiler : Form
    {

        public Vehiculo vehiculoSeleccionado;

        public FormAlquiler(Vehiculo vehiculo)
        {
            InitializeComponent();
            vehiculoSeleccionado = vehiculo;
            txtPlaca.Text = vehiculoSeleccionado.Placa;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            // Capturar campos
            string cliente = txtCliente.Text;
            // validar que no hayan campos vacios
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("¡Papi! no sea estúpido, llene todos los campos socio");
                return;
            }
            DateTime fechaIni = fechaInicio.Value;
            DateTime fechaFinal = fechaFin.Value;
            // si no hay nada vacio, registramos
            new Alquiler(cliente, vehiculoSeleccionado, fechaIni, fechaFinal, 0, 0);
            // mensaje
            MessageBox.Show("¡Papi! alquilo correctamente su vehiculo, el vehiculo esta actuamente lleva 0 kilometros recorridos");

            // Hacer una pausa de dos segundos de forma asíncrona
            await Task.Delay(1000);

            // Cerrar el formulario modal actual
            this.Close();
        }
    }
}
