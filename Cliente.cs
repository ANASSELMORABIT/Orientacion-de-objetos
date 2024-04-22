
public class Cliente
{
    private string nombre {get; set;}
    private string dni {get; set;}
    private double cantidadPaga {get; set;}
    private double senal {get; set;}
    public Cliente(string nombre, string dni, double cantidadPaga, double senal){
        this.nombre = nombre;
        this.dni = dni;
        this.cantidadPaga = cantidadPaga;
        this.senal = senal;
    }
    public void ConsultarDatosCliente(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Cantidad de paga: " + cantidadPaga);
        Console.WriteLine("Senal: " + senal);
    }
    public void AgregarCliente(string nombre, string dni, double cantidadPaga, double senal,List<string> listaCliente){
        Console.WriteLine("El cliente que quieres agregar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Cantidad de paga: " + cantidadPaga);
        Console.WriteLine("Senal: " + senal);
        listaCliente.Add(dni);
    }
    public void QuitarCliente(string nombre, string dni, double cantidadPaga, double senal,List<string> listaCliente){
        Console.WriteLine("El cliente que quieres quitar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        Console.WriteLine("Cantidad de paga: " + cantidadPaga);
        Console.WriteLine("Senal: " + senal);
        listaCliente.Remove(dni);
    }
}