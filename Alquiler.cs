// Clase Alquiler
public class Alquiler
{

    private static int contador = 0;
    public int ID { get; }
    public string Cliente { get; set; }
    public Vehiculo Vehiculo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public double KilometrosRecorridos { get; set; }
    public double ValorPagar { get; set; }
    public string Placa { get; set; }

    // Constructor
    public Alquiler(string cliente, Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFin, double kilometrosRecorridos, double valorPagar)
    {
        Cliente = cliente;
        Vehiculo = vehiculo;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        KilometrosRecorridos = kilometrosRecorridos;
        ValorPagar = valorPagar;
        contador += 1;
        ID = contador;
        Placa = vehiculo.Placa;

        // Añadir a la lista utilizando el gestor de alquileres
        GestorAlquileres.AgregarAlquiler(this);
        ValorPagar = valorPagar;
    }

    /*public double CalcularImporte()
    {
        // Lógica para calcular el importe según las reglas especificadas
        // ...

        return 2.3;
    }*/
}