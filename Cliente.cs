public class Cliente
{
    // Atributos
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Country { get; set; }

    // Constructor
    public Cliente(int id, string nombre, string direccion, string telefono, string country)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Country = country;
    }
}
