// Clase Alquiler
public class Alquiler
{

    private static int contador = 0;
    public int ID { get; }
    public Vehiculo Vehiculo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public double KilometrosRecorridos { get; set; }
    public string Placa { get; set; }

    // Constructor
    public Alquiler(Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin, double kilometrosRecorridos)
    {
        Vehiculo = vehiculo;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        KilometrosRecorridos = kilometrosRecorridos;
        contador += 1;
        ID = contador;
        Placa = vehiculo.Placa;

        // Añadir a la lista utilizando el gestor de alquileres
        GestorAlquileres.AgregarAlquiler(this);
    }

    /*public double CalcularImporte()
    {
        // Lógica para calcular el importe según las reglas especificadas
        // ...

        return 2.3;
    }*/
}