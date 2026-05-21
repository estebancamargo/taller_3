using System;

class punto5
{
    static void Main()
    {
        int advertencia, errores;

        Console.WriteLine("Ingrese el numero de advertencias: ");
        advertencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el numero de errores: ");
        errores = Convert.ToInt32(Console.ReadLine());

        bool estaRechazado = advertencia > 15 || errores > 5;
        bool estaAutorizado = !estaRechazado;

        Console.WriteLine("Esta rechazado: " + estaRechazado);
        Console.WriteLine("Esta autorizado: " + estaAutorizado);
    }
}