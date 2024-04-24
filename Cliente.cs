public class Cliente
{
    private string Nombre { get; set; }
    private string Dni { get; set; }
    private double CantidadPaga { get; set; }
    private double Senal { get; set; }

    public Cliente(string nombre, string dni, double cantidadPaga, double senal)
    {
        Nombre = nombre;
        Dni = dni;
        CantidadPaga = cantidadPaga;
        Senal = senal;
    }
    public void ConsultarDatosCliente()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("DNI: " + Dni);
        Console.WriteLine("Cantidad de paga: " + CantidadPaga);
        Console.WriteLine("Senal: " + Senal);
    }

    public void AgregarCliente(string nombre, string dni, double cantidadPaga, double senal, List<string> listaCliente)
    {
        Console.WriteLine("El cliente que quieres agregar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Cantidad de paga: " + cantidadPaga);
        Console.WriteLine("Senal: " + senal);
        listaCliente.Add(dni);
    }

    public void QuitarCliente(string nombre, string dni, double cantidadPaga, double senal, List<string> listaCliente)
    {
        Console.WriteLine("El cliente que quieres quitar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Cantidad de paga: " + cantidadPaga);
        Console.WriteLine("Senal: " + senal);
        listaCliente.Remove(dni);
    }
    public void ModificarDatosCliente(string nombreActual, string dniActual, double CantidadPagaActual, double SenalActual, string nuevoNombre, string nuevoDni, double nuevaCantidadPaga, double nuevaSenal, List<string> listaCliente) {
        Console.WriteLine("Los datos del cliente que quieres modificar son: ");
        Console.WriteLine("Nombre actual: " + nombreActual);
        Console.WriteLine("DNI actual: " + dniActual);
        Console.WriteLine("Cantidad de paga actual: " + CantidadPagaActual);
        Console.WriteLine("Senal actual: " + SenalActual);
        listaCliente.Remove(dniActual);
        Nombre = nuevoNombre;
        Dni = nuevoDni;
        CantidadPaga = nuevaCantidadPaga;
        Senal = nuevaSenal;
        Console.WriteLine("Los nuevos datos son:");
        Console.WriteLine("Nuevo nombre: " + nuevoNombre);
        Console.WriteLine("Nuevo DNI: " + nuevoDni);
        Console.WriteLine("Nueva cantidad de paga: " + nuevaCantidadPaga);
        Console.WriteLine("Nueva senal: " + nuevaSenal);
        listaCliente.Add(nuevoDni);
    }
}
