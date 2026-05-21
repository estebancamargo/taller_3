//Módulo de Presupuesto para Desarrollo (Conversión y Asignación)

using System;

class punto1
{
    static void Main()
    {
        const double valorHr = 120000;
        double costoAcumu;
        int hr;

        Console.WriteLine("Ingrese las horas trabajadas: ");
        hr = Convert.ToInt32(Console.ReadLine());

        costoAcumu = valorHr * hr;

        Console.WriteLine("El costo del sprint es: " + costoAcumu);


    }
}