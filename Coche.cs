
public class Coche{
    private string modelo {get; set;}
    private string marca {get; set;}
    private int kilometros {get; set;}
    private int anoFabricacion {get; set;}
    private int anoMatriculacion {get; set;}
    private string fechaCompra {get; set;}
    private double precioCompra {get; set;}
    private bool probado {get; set;}
    public Coche(string modelo, string marca, int kilometros, int anoFabricacion, int anoMatriculacion, string fechaCompra, double precioCompra, bool probado){
        this.modelo = modelo;
        this.marca = marca;
        this.kilometros = kilometros;
        this.anoFabricacion = anoFabricacion;
        this.anoMatriculacion = anoMatriculacion;
        this.fechaCompra = fechaCompra;
        this.precioCompra = precioCompra;
        this.probado = probado;
    }
    public double calcularPrecioVenta(double precioCompra){
        return precioCompra * 0.3;
    }
    public double consultarPrecioCompra(){
        return precioCompra;
    }
    public void consultarDatosCoche(){
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Kilómetros: " + kilometros);
        Console.WriteLine("Ano de fabricación: " + anoFabricacion);
        Console.WriteLine("Ano de matriculación: " + anoMatriculacion);
        Console.WriteLine("Fecha de compra: " + fechaCompra);
        Console.WriteLine("Probado: " + probado);
        Console.WriteLine("Precio de compra: " + precioCompra);
        Console.WriteLine("Precio de venta: " + calcularPrecioVenta(precioCompra));
        Console.WriteLine("---------------------------------");
    }
}