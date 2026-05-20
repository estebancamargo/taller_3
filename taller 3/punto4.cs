using System;

class Punto4
{
    static void Main()
    {
        int minutos;
        double horasExac;
        int horasEnte;

        Console.WriteLine("Ingrese la cantidad de minutos:");
        minutos = Convert.ToInt32(Console.ReadLine());

        horasExac = minutos / 60.0;

        horasEnte = (int)horasExac;

        Console.WriteLine("Horas exactas: " + horasExac);
        Console.WriteLine("Horas enteras: " + horasEnte);
    }
}