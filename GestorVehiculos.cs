public static class GestorVehiculos
{
    public static List<Vehiculo> ListaDeVehiculos { get; private set; } = new List<Vehiculo>();

    public static void AgregarVehiculo(Vehiculo vehiculo)
    {
        ListaDeVehiculos.Add(vehiculo);
    }
}
