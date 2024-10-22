using Models;

public class SegundoPlato : Producto{
    public string Ingredientes { get; set; }

    public SegundoPlato(string nombre, double precio ,string ingredientes): base(nombre, precio) {
        Ingredientes = ingredientes;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Plato secundario: {Nombre}, Precio {Precio:C}, Ingredientes {Ingredientes}");
    }
}