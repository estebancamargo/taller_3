//Convertidor de Divisas Académico
using System;

class Ejercicio2
{
    static void Main ()
    {
        double pesos, resultado1, resultado2;
        const double dolar = 3800;
        const double euro = 4400;

        Console.WriteLine("Ingrese el valor que desea convertir: ");
        pesos = Convert.ToDouble(Console.ReadLine());

        resultado1 = pesos / dolar;
        resultado2 = pesos / euro;

        Console.WriteLine("Su conversion en dolares es: " + resultado1);
        Console.WriteLine("Su conversion en euros es: " + resultado2);


    }
}

