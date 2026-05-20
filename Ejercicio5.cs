//Control de Inventario de Tienda Técnica
using System;

class Ejercicio5
{
    static void Main ()
    {
        string componente;
        int cantidad;
        double precio;
        double total;

        Console.WriteLine("Ingrese el nombre del componente:");
        componente = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad disponible:");
        cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el precio unitario:");
        precio = double.Parse(Console.ReadLine());

        total = cantidad * precio;

        Console.WriteLine("Componente: " + componente);
        Console.WriteLine("Valor total del inventario: $" + total);
    }
}