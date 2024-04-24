public class Proveedor
{
    private string Nombre {get; set;}
    private string Dni {get; set;}
    public Proveedor(string nombre, string dni){
        Nombre = nombre;
        Dni = dni;
    }
    public void ConsultarDatosProveedor(){
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("DNI: " + Dni);
    }
    public void AgregarProveedor(string nombre, string dni,List<string> listaProveedor){
        Console.WriteLine("EL proveedor que quieres agregar es: "); 
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        listaProveedor.Add(dni);

        
    }
    public void ModificarDatosProveedor(string nombre, string dni, string nuevoNombre, string nuevoDni, List<string> listaProveedores){
        Console.WriteLine("Los datos del proveedor que quieres modificar son: ");
        Console.WriteLine("Nombre actual: " + nombre);
        Console.WriteLine("DNI actual: " + dni);
        listaProveedores.Remove(dni);
        Console.WriteLine("los datos nuevos son:");
        Nombre = nuevoNombre;
        Dni = nuevoDni;
        listaProveedores.Add(dni);
        Console.WriteLine("Nombre: " + nuevoNombre);
        Console.WriteLine("DNI: " + nuevoDni);
        
    }
    public void QuitarProveedor(string nombre, string dni,List<string> listaProveedor){
        Console.WriteLine("EL proveedor que quieres quitar es: ");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("DNI: " + dni);
        listaProveedor.Remove(dni);
    }
}
