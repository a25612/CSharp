using Models;

public class InvalidIngredientException: Exception{
    public InvalidIngredientException(string message): base(message){

    }
}
public class PlatoPrincipal : Producto {

    public string Ingredientes {get;set;}

public PlatoPrincipal(string nombre, double precio, string ingredientes): base(nombre, precio) {
   Ingredientes = ingredientes;
   if (string.IsNullOrEmpty(ingredientes)){
        
   }
}

    public override void MostrarDetalles() {
        Console.WriteLine($"Plato principal: {Nombre}, Precio {Precio:C}, Ingredientes {Ingredientes} ");
    }
}