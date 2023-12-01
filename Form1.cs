using System.Reflection.Emit;
using System.Windows.Forms;

namespace drawio
{
    public partial class Form1 : Form
    {

        public int indexTablaVehiculoSeleccionada;
        public int indexTablaAlquilerSeleccionada;

        public Form1()
        {
            InitializeComponent();
            // Iniciar con vehiculos
            Vehiculo vehiculo1 = new Vehiculo("SUV", "Toyota Highlander", "ABC123", "2022", true);
            Vehiculo vehiculo2 = new Vehiculo("Camioneta", "Ford Explorer", "XYZ789", "2021", false);
            Vehiculo vehiculo3 = new Vehiculo("Compacto", "Honda Civic", "123DEF", "2023", true);
            Vehiculo vehiculo4 = new Vehiculo("Pickup", "Chevrolet Colorado", "456GHI", "2022", false);
            Vehiculo vehiculo5 = new Vehiculo("Sedan", "Nissan Altima", "789JKL", "2021", true);
            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;
            // Iniciar con alquileres
            new Alquiler(vehiculo2, now, now.AddDays(1), 200.5);
            new Alquiler(vehiculo4, now, now.AddDays(2), 150.0);
            // Llenamos datos
            cargarTablaVehiculos();
            cargarTablaVehiculosAlquilados();
        }

        private void cargarTablaVehiculosAlquilados()
        {
            // Configurar columnas antes de asignar el origen de datos
            tablaAlquilados.Columns.Clear(); // Limpiar columnas existentes si las hay

            DataGridViewTextBoxColumn columnaNumero = new DataGridViewTextBoxColumn();
            columnaNumero.DataPropertyName = "ID";
            columnaNumero.HeaderText = "#";
            tablaAlquilados.Columns.Add(columnaNumero);

            DataGridViewTextBoxColumn columnaPlaca = new DataGridViewTextBoxColumn();
            columnaPlaca.DataPropertyName = "Placa";
            columnaPlaca.HeaderText = "Placa";
            tablaAlquilados.Columns.Add(columnaPlaca);

            DataGridViewTextBoxColumn columnaFechaInicio = new DataGridViewTextBoxColumn();
            columnaFechaInicio.DataPropertyName = "FechaInicio";
            columnaFechaInicio.HeaderText = "Fecha Inicio";
            tablaAlquilados.Columns.Add(columnaFechaInicio);

            DataGridViewTextBoxColumn columnaFechaFin = new DataGridViewTextBoxColumn();
            columnaFechaFin.DataPropertyName = "FechaFin";
            columnaFechaFin.HeaderText = "Fecha Fin";
            tablaAlquilados.Columns.Add(columnaFechaFin);

            // Propiedades de la tabla
            tablaAlquilados.AutoGenerateColumns = false;
            tablaAlquilados.AllowUserToAddRows = false;
            tablaAlquilados.ReadOnly = true;

            // Consultar lista de alquileres
            List<Alquiler> listaAlquileres = GestorAlquileres.ListaDeAlquileres;

            // Le pasamos los datos a la tabla
            tablaAlquilados.DataSource = listaAlquileres;
        }


        private void cargarTablaVehiculos()
        {

            // Configurar columnas manualmente
            tablaVehiculos.Columns.Clear(); // Limpiar columnas existentes si las hay

            DataGridViewTextBoxColumn columnaNumero = new DataGridViewTextBoxColumn();
            columnaNumero.DataPropertyName = "ID";
            columnaNumero.HeaderText = "#";
            tablaVehiculos.Columns.Add(columnaNumero);

            DataGridViewTextBoxColumn columnaAno = new DataGridViewTextBoxColumn();
            columnaAno.DataPropertyName = "Ano";
            columnaAno.HeaderText = "Año";
            tablaVehiculos.Columns.Add(columnaAno);

            DataGridViewTextBoxColumn columnaPlaca = new DataGridViewTextBoxColumn();
            columnaPlaca.DataPropertyName = "Placa";
            columnaPlaca.HeaderText = "Placa";
            tablaVehiculos.Columns.Add(columnaPlaca);

            DataGridViewTextBoxColumn columnaTipo = new DataGridViewTextBoxColumn();
            columnaTipo.DataPropertyName = "Tipo";
            columnaTipo.HeaderText = "Tipo";
            tablaVehiculos.Columns.Add(columnaTipo);

            DataGridViewTextBoxColumn columnaModelo = new DataGridViewTextBoxColumn();
            columnaModelo.DataPropertyName = "Modelo";
            columnaModelo.HeaderText = "Modelo";
            tablaVehiculos.Columns.Add(columnaModelo);

            DataGridViewCheckBoxColumn columnaDisponible = new DataGridViewCheckBoxColumn();
            // DataGridViewTextBoxColumn columnaDisponible = new DataGridViewTextBoxColumn();
            columnaDisponible.DataPropertyName = "Disponible";
            columnaDisponible.HeaderText = "Disponible";
            tablaVehiculos.Columns.Add(columnaDisponible);

            // Propiedades de la tabla
            tablaVehiculos.AutoGenerateColumns = false;
            tablaVehiculos.AllowUserToAddRows = false;
            tablaVehiculos.ReadOnly = true;

            // Consultamos la lista de vehiculos
            List<Vehiculo> listaVehiculos = GestorVehiculos.ListaDeVehiculos;
            // Le pasamos los datos a la tabla
            tablaVehiculos.DataSource = listaVehiculos;
        }

        private void OnClickTablaVehiculo(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la posición de la celda seleccionada
            indexTablaVehiculoSeleccionada = e.RowIndex;
            // Habilitar boton para eliminar
            btnEliminarVehiculo.Enabled = true;
            btnAgregarAlquiler.Enabled = true;
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            // Verificar si la fila seleccionada es válida
            if (indexTablaVehiculoSeleccionada >= 0 && indexTablaVehiculoSeleccionada < GestorVehiculos.ListaDeVehiculos.Count)
            {
                // Eliminar el vehículo en la posición seleccionada
                GestorVehiculos.ListaDeVehiculos.RemoveAt(indexTablaVehiculoSeleccionada);

                // Luego actualizar la tabla
                cargarTablaVehiculos();
                btnEliminarVehiculo.Enabled = false;
            }
        }

        private void OnClickTablaAlquiler(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la posición de la celda seleccionada
            indexTablaAlquilerSeleccionada = e.RowIndex;
            // Habilitar boton para eliminar
            btnEliminarAlquiler.Enabled = true;
        }

        private void btnEliminarAlquiler_Click(object sender, EventArgs e)
        {
            // Verificar si la fila seleccionada es válida
            if (indexTablaAlquilerSeleccionada >= 0 && indexTablaAlquilerSeleccionada < GestorAlquileres.ListaDeAlquileres.Count)
            {
                // Eliminar el alquiler en la posición seleccionada
                GestorAlquileres.ListaDeAlquileres.RemoveAt(indexTablaAlquilerSeleccionada);

                // Luego actualizar la tabla
                cargarTablaVehiculosAlquilados();
                btnEliminarAlquiler.Enabled = false;
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            // Nueva instancia del formulario emergente
            FormVehiculo ventana = new FormVehiculo();

            // Mostrar el formulario emergente de manera modal
            ventana.ShowDialog();

            // Recargar otra vez la tabla Vehiculos
            cargarTablaVehiculos();
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {

            btnEliminarVehiculo.Enabled = false;

            // Consultamos la lista de vehiculos
            List<Vehiculo> listaVehiculos = GestorVehiculos.ListaDeVehiculos;

            // Selecciono el que puse en el tabla
            Vehiculo vehiculoSeleccionado = listaVehiculos[indexTablaVehiculoSeleccionada];

            // Nueva instancia del formulario emergente
            FormAlquiler ventana = new FormAlquiler(vehiculoSeleccionado);

            // Mostrar el formulario emergente de manera modal
            ventana.ShowDialog();

            // Recargar otra vez la tabla Alquileres
            cargarTablaVehiculosAlquilados();

            btnAgregarAlquiler.Enabled = false;
        }
    }

}