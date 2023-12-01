public class Vehiculo
{

    private static int contador = 0;
    public int ID { get; }
    public string Tipo { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Ano { get; set; }
    public bool Disponible { get; set; }

    // Constructor
    public Vehiculo(string tipo, string modelo, string placa, string ano, bool disponible)
    {
        Tipo = tipo;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        Disponible = disponible;
        contador += 1;
        ID = contador;

        // Añadir a la lista utilizando el gestor de vehículos
        GestorVehiculos.AgregarVehiculo(this);
    }

}
