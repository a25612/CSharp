using Models;

class MenuApp
{
    private Pedido pedido;

    public MenuApp()
    {
        pedido = new Pedido();
    }

    public void MostrarMenu()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n--- Menú del Restaurante ---");
            Console.WriteLine("1. Añadir Plato Principal");
            Console.WriteLine("2. Añadir Segundo Plato");
            Console.WriteLine("3. Añadir Bebida");
            Console.WriteLine("4. Añadir Postre");
            Console.WriteLine("5. Mostrar Pedido");
            Console.WriteLine("6. Calcular Total y Salir");
            Console.WriteLine("Selecciona una opción:");

            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Error: Por favor selecciona una opción válida (1-6).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AñadirPlatoPrincipal();
                    break;
                case 2:
                    AñadirSegundoPlato();
                    break;
                case 3:
                    AñadirBebida();
                    break;
                case 4:
                    AñadirPostre();
                    break;
                case 5:
                    pedido.MostrarPedido();
                    break;
                case 6:
                    double total = pedido.CalcularTotal();
                    Console.WriteLine($"\nTotal a pagar: {total:C}");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 6);
    }

    private void AñadirPlatoPrincipal()
    {
        Console.WriteLine("Nombre del plato:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Precio del plato:");
        if (!double.TryParse(Console.ReadLine(), out double precio) || precio <= 0)
        {
            Console.WriteLine("Error: El precio debe ser un número positivo.");
            return;
        }
        Console.WriteLine("Ingredientes:");
        string ingredientes = Console.ReadLine();

        PlatoPrincipal plato = new PlatoPrincipal(nombre, precio, ingredientes);
        pedido.AnadirProductos(plato);
    }

    private void AñadirSegundoPlato()
    {
        Console.WriteLine("Nombre del plato:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Precio del plato:");
        if (!double.TryParse(Console.ReadLine(), out double precio) || precio <= 0)
        {
            Console.WriteLine("Error: El precio debe ser un número positivo.");
            return;
        }
        Console.WriteLine("Ingredientes:");
        string ingredientes = Console.ReadLine();

        SegundoPlato plato = new SegundoPlato(nombre, precio, ingredientes);
        pedido.AnadirProductos(plato);
    }

    private void AñadirBebida()
    {
        Console.WriteLine("Nombre de la bebida:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Precio de la bebida:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("¿Es alcohólica? (sí/no):");
        bool esAlcoholica = Console.ReadLine().ToLower() == "sí"; //SÍ Sí sí sÍ

        Bebida bebida = new Bebida(nombre, precio, esAlcoholica);
        pedido.AnadirProductos(bebida);
    }

    private void AñadirPostre()
    {
        Console.WriteLine("Nombre del postre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Precio del postre:");
        double precio = double.Parse(Console.ReadLine());
        Console.WriteLine("Calorías:");
        int calorias = int.Parse(Console.ReadLine());

        Postre postre = new Postre(nombre, precio, calorias);
        pedido.AnadirProductos(postre);
    }
}

