using System;

class InventarioFactura
{
    static void Main()
    {
        string producto;
        int cantidad;

        int stockArroz = 100;
        int stockLeche = 100;
        int stockPan = 100;
        int stockHuevos = 100;

        double precioArroz = 5000;
        double precioLeche = 4000;
        double precioPan = 2000;
        double precioHuevos = 12000;

        Console.WriteLine("Productos disponibles: arroz, leche, pan, huevos");

        Console.Write("Ingrese el nombre del producto: ");
        producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        bool esArroz = producto == "arroz";
        bool esLeche = producto == "leche";
        bool esPan = producto == "pan";
        bool esHuevos = producto == "huevos";

        int productoExiste =
            Convert.ToInt32(esArroz) +
            Convert.ToInt32(esLeche) +
            Convert.ToInt32(esPan) +
            Convert.ToInt32(esHuevos);

        double precioUnitario =
            precioArroz * Convert.ToInt32(esArroz) +
            precioLeche * Convert.ToInt32(esLeche) +
            precioPan * Convert.ToInt32(esPan) +
            precioHuevos * Convert.ToInt32(esHuevos);

        int stockDisponible =
            stockArroz * Convert.ToInt32(esArroz) +
            stockLeche * Convert.ToInt32(esLeche) +
            stockPan * Convert.ToInt32(esPan) +
            stockHuevos * Convert.ToInt32(esHuevos);

        bool ventaValida = productoExiste == 1 && cantidad <= stockDisponible;

        int cantidadFacturada = cantidad * Convert.ToInt32(ventaValida);

        double subtotal = cantidadFacturada * precioUnitario;

        stockArroz -= cantidadFacturada * Convert.ToInt32(esArroz);
        stockLeche -= cantidadFacturada * Convert.ToInt32(esLeche);
        stockPan -= cantidadFacturada * Convert.ToInt32(esPan);
        stockHuevos -= cantidadFacturada * Convert.ToInt32(esHuevos);

        Console.WriteLine("----- FACTURA -----");
        Console.WriteLine("Producto ingresado: " + producto);
        Console.WriteLine("Producto existe: " + Convert.ToBoolean(productoExiste));
        Console.WriteLine("Venta valida: " + ventaValida);
        Console.WriteLine("Cantidad solicitada: " + cantidad);
        Console.WriteLine("Cantidad facturada: " + cantidadFacturada);
        Console.WriteLine("Precio unitario: $" + precioUnitario);
        Console.WriteLine("Subtotal: $" + subtotal);

        Console.WriteLine("----- STOCK FINAL -----");
        Console.WriteLine("Arroz: " + stockArroz);
        Console.WriteLine("Leche: " + stockLeche);
        Console.WriteLine("Pan: " + stockPan);
        Console.WriteLine("Huevos: " + stockHuevos);
    }
}