public static class GestorAlquileres
{
    public static List<Alquiler> ListaDeAlquileres { get; private set; } = new List<Alquiler>();

    public static void AgregarAlquiler(Alquiler alquiler)
    {
        ListaDeAlquileres.Add(alquiler);
    }
}
