public class Coche{
    private string Modelo {get; set;}
    private string Marca {get; set;}
    private int Kilometros {get; set;}
    private int AnoFabricacion {get; set;}
    private int AnoMatriculacion {get; set;}
    private string FechaCompra {get; set;}
    private double PrecioCompra {get; set;}
    private bool Probado {get; set;}
    public Coche(string modelo, string marca, int kilometros, int anoFabricacion, int anoMatriculacion, string fechaCompra, double precioCompra, bool probado){
        Modelo = modelo;
        Marca = marca;
        Kilometros = kilometros;
        AnoFabricacion = anoFabricacion;
        AnoMatriculacion = anoMatriculacion;
        FechaCompra = fechaCompra;
        PrecioCompra = precioCompra;
        Probado = probado;
    }
    public double CalcularPrecioVenta(double precioCompra){
        return precioCompra * 0.3;
    }
    public double ConsultarPrecioCompra(){
        return PrecioCompra;
    }
    public void ConsultarDatosCoche(){
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Kilómetros: " + Kilometros);
        Console.WriteLine("Año de fabricación: " + AnoFabricacion);
        Console.WriteLine("Año de matriculación: " + AnoMatriculacion);
        Console.WriteLine("Fecha de compra: " + FechaCompra);
        Console.WriteLine("Probado: " + Probado);
        Console.WriteLine("Precio de compra: " + PrecioCompra);
        Console.WriteLine("Precio de venta: " + CalcularPrecioVenta(PrecioCompra));
        Console.WriteLine("---------------------------------");
    }
}
