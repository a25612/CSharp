using Models;

try{
    var postrecito = new Postre("Flan", -2.5, 800);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error creando postre: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

var plato = new PlatoPrincipal("Plato combinado", 12.50, "Pollo, patatas, tomate");
plato.MostrarDetalles();

var segundoPlato = new SegundoPlato("Plato combinado 2", 12.50, "Pechugas, lechuga, jamon");
segundoPlato.MostrarDetalles();

var bebida = new Bebida("Limonada", 1.50, false);
bebida.MostrarDetalles();

var postre = new Postre("Tiramisú", 7.00, 800);
postre.MostrarDetalles();

var pedido = new Pedido();
pedido.AnadirProductos(plato);
pedido.AnadirProductos(bebida);
pedido.AnadirProductos(postre);

pedido.MostrarPedido();
pedido.CalcularTotal();

//var menuApp = new MenuApp();
//menuApp.MostrarMenu();

//var total = pedido.CalcularTotal();
//Console.WriteLine($"Total: {total}");
var rutaFicherotxt = "pedidos.txt";
pedido.GuardarPedido(rutaFicherotxt);

var pedidoCargado = new Pedido();
pedidoCargado.CargarPedido(rutaFicherotxt);
pedidoCargado.MostrarPedido();

var combo = new Combo(plato,segundoPlato,bebida,postre,0.10);
combo.MostrarDetalles();


pedido.AnadirProductos(combo,3);
pedido.MostrarPedido();
var totalConCantidad = pedido.CalcularTotal();
Console.WriteLine($"Total pedido: {totalConCantidad}");