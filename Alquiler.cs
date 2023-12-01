using System;

class Vehiculo
{
    // Atributos
    public string Marca { get; set; }
    public string Placa { get; set; }
    public int Año { get; set; }
    public string Modelo { get; set; }
    public bool Disponible { get; set; }
    public bool Seleccionado { get; set; }

    // Constructor
    public Vehiculo(string marca, string placa, int año, string modelo, bool disponible, bool seleccionado)
    {
        Marca = marca;
        Placa = placa;
        Año = año;
        Modelo = modelo;
        Disponible = disponible;
        Seleccionado = seleccionado;
    }

}
