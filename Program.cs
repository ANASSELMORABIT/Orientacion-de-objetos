internal class Program
{
    private static void Main(string[] args)
    {
        //EL clase Coche es:
        Console.WriteLine("EL COCHE ES: ");
        Coche coche = new Coche("BMW", "M5", 1000, 2020, 2021, "12/12/2021", 1000, true);
        Console.WriteLine("Precio de venta: ");
        Console.WriteLine(coche.CalcularPrecioVenta(1000));
        coche.ConsultarDatosCoche();
        coche.ModificarDatosCoche("Mercedes", "Class", 2000, 2022, 2023, "13/12/2021", 2000, false);
        coche.ConsultarDatosCoche();
        Console.WriteLine("---------------------------------");

        //EL PROVEEDOR ES:
        Console.WriteLine("EL PROVEEDOR ES: ");
        Proveedor proveedor = new Proveedor("ANASSProveedor", "1234567890");
        proveedor.ConsultarDatosProveedor();
        List<string> listaProveedor = new List<string>();
        proveedor.AgregarProveedor("ANASSProveedor", "1234567890", listaProveedor);
        proveedor.ModificarDatosProveedor("ANASSProveedor", "1234567890", "ANASS", "1234", listaProveedor);
        proveedor.ConsultarDatosProveedor();
        Console.WriteLine("---------------------------------");
        proveedor.QuitarProveedor("ANASS", "1234", listaProveedor);
        Console.WriteLine("---------------------------------");



        //EL CLIENTE ES:
        Console.WriteLine("EL CLIENTE ES: ");
        Cliente cliente = new Cliente("ANASS", "1234567890", 1000, 1000);
        cliente.ConsultarDatosCliente();
        List<string> listaCliente = new List<string>();
        cliente.AgregarCliente("ANASS", "1234567890", 1000, 1000, listaCliente);
        cliente.ModificarDatosCliente("ANASS", "1234567890", 1000, 1000, "ANASSNUEVO", "1234567890", 2000, 2000, listaCliente); 
        cliente.ConsultarDatosCliente();
        cliente.QuitarCliente("ANASSNUEVO", "1234567890", 2000, 2000, listaCliente);
        Console.WriteLine("---------------------------------");

    }
}


