
// ETAPA 1 
const string name = "KIOSCO EL RECREO";
const decimal descuento10 = 0.10m;
const decimal descuento5 = 0.05m;
const decimal descuentoEfectivo = 0.10m;
const decimal recargoCredito = 0.15m;
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
            decimal descuento = 0;

            if (total > 50000)
            {
                descuento = total * descuento10;
            }
            else if (total > 20000)
            {
                descuento = total * descuento5;
            }

            decimal totalFinal = total - descuento;
            int medioPago;
            decimal recargo = 0;

            do
            {
                Console.WriteLine("Medio de pago:");
                Console.WriteLine("1 - Efectivo");
                Console.WriteLine("2 - Débito");
                Console.WriteLine("3 - Crédito");

                medioPago = int.Parse(Console.ReadLine());

                switch (medioPago)
                {
                    case 1:
                        decimal descuentoAdicional = totalFinal * descuentoEfectivo;
                        descuento += descuentoAdicional;
                        totalFinal -= descuentoAdicional;
                        break;

                    case 2:
                        break;

                    case 3:
                        recargo = totalFinal * recargoCredito;
                        totalFinal += recargo;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            while (medioPago != 1 && medioPago != 2 && medioPago != 3);

            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: ${total}");
            Console.WriteLine($"Descuento: ${descuento}");
            Console.WriteLine($"Recargo: ${recargo}");
            Console.WriteLine($"Total: ${totalFinal}");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}
while (opcion != 2);

