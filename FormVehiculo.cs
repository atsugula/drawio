using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace drawio
{
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            // Capturar campos
            string tipo = txtTipo.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string ano = txtAno.Text;
            // validar que no hayan campos vacios
            if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(modelo)
                || string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(ano))
            {
                MessageBox.Show("¡Papi! no sea estúpido, llene todos los campos socio");
                return;
            }
            // si no hay nada vacio, registramos
            new Vehiculo(tipo, modelo, placa, ano, true);
            // mensaje
            MessageBox.Show("¡Papi! registro correctamente su vehiculo, el vehiculo esta actuamente disponible");

            // Hacer una pausa de dos segundos de forma asíncrona
            await Task.Delay(1000);

            // Cerrar el formulario modal actual
            this.Close();
        }
    }
}
