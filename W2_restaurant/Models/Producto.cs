namespace Models;

public abstract class Producto {
    public string Nombre {get;set;}
    public double Precio {get;set;}

    public Producto(string nombre, double precio) {
        Nombre = nombre;
        Precio = precio;
        if (string.IsNullOrEmpty(nombre)){
            throw new ArgumentException("Error el nombre no puede esatr vacio");
        }
        if (precio < 0){
            throw new ArgumentException("Error el precio no puede ser negativo");
        }
    }

    public abstract void MostrarDetalles();

}
