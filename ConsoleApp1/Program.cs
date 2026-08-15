
// ETAPA 1 
string name = "KIOSCO EL RECREO";
Console.WriteLine(name);

Console.WriteLine("ingrese su nombre: ");
string user = Console.ReadLine();
Console.WriteLine ($"bienevenida {user}. la caja esta abierta");

// ETAPA 2 y 3

decimal total = 0;
int cantidadProductos = 0;
int opcion;

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese nombre del producto:");
            string producto = Console.ReadLine();

            Console.WriteLine("Ingrese precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Producto: {producto}");
            Console.WriteLine($"Precio: ${precio}");

            total += precio;
            cantidadProductos++;
            break;

        case 2:
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Total: ${total}");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}
while (opcion != 2);