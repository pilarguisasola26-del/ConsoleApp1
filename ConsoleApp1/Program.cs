
// ETAPA 1 
string name = "KIOSCO EL RECREO";
Console.WriteLine(name);

Console.WriteLine("ingrese su nombre: ");
string user = Console.ReadLine();
Console.WriteLine ($"bienevenida {user}. la caja esta abierta");
Console.ReadLine();

//ETAPA 2 

Console.WriteLine("ingrese nombre del producto: ");
string Product = Console.ReadLine();

Console.WriteLine("ingrese precio: ");
decimal Precio = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Producto: {Product}");
Console.WriteLine($"Precio: ${Precio}");