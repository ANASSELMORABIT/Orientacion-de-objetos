internal class Program
{
    private static void Main(string[] args)
    {
        //EL clase Coche es:
        Console.WriteLine("EL COCHE ES: ");
        Coche coche = new Coche("Modelo", "Marca", 1000, 2020, 2021, "Fecha", 1000, true);
        Console.WriteLine("Precio de venta: ");
        Console.WriteLine(coche.calcularPrecioVenta(1000));
        coche.consultarDatosCoche();
        Console.WriteLine("---------------------------------");

        //EL PROVEEDOR ES:
        Console.WriteLine("EL PROVEEDOR ES: ");
        Proveedor proveedor = new Proveedor("ANASSProveedor", "1234567890");
        proveedor.ConsultarDatosProveedor();
        List<string> listaProveedor = new List<string>();
        proveedor.AgregarProveedor("ANASSProveedor", "1234567890", listaProveedor);
        proveedor.QuitarProveedor("ANASSProveedor", "1234567890", listaProveedor);
        Console.WriteLine("---------------------------------");



        //EL CLIENTE ES:
        Console.WriteLine("EL CLIENTE ES: ");
        Cliente cliente = new Cliente("ANASS", "1234567890", 1000, 1000);
        cliente.ConsultarDatosCliente();
        List<string> listaCliente = new List<string>();
        cliente.AgregarCliente("ANASS", "1234567890", 1000, 1000, listaCliente);
        cliente.QuitarCliente("ANASS", "1234567890", 1000, 1000, listaCliente);
        Console.WriteLine("---------------------------------");

    }
}