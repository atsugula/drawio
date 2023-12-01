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
    public partial class FormAlquiler : Form
    {

        public Vehiculo vehiculoSeleccionado;

        public FormAlquiler(Vehiculo vehiculo)
        {
            InitializeComponent();
            vehiculoSeleccionado = vehiculo;
            txtPlaca.Text = vehiculoSeleccionado.Placa;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //fechaInicio.Value;
            MessageBox.Show($"¡Papi! {fechaInicio.Value}");

            this.Close();
        }
    }
}
