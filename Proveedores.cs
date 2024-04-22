
public class Proveedor
{
    private string nombre {get; set;}
    private string dni {get; set;}
    public Proveedor(string nombre, string dni){
        this.nombre = nombre;
        this.dni = dni;
    }
    public void ConsultarDatosProveedor(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
    }
    public void AgregarProveedor(string nombre, string dni,List<string> listaProveedor){
        Console.WriteLine("EL proveedor que quieres agregar es: "); 
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        listaProveedor.Add(dni);

        
    }
    public void QuitarProveedor(string nombre, string dni,List<string> listaProveedor){
        Console.WriteLine("EL proveedor que quieres quitar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        listaProveedor.Remove(dni);
    }
}