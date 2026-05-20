//Cálculo de Consumo de Combustible
using System;
class Ejercicio1 {
    static void Main() {
        const double precio_galon = 30000;

        double distancia,galones,promedio,costo_total;


        Console.WriteLine("Ingrese la distancia recorrida en Km: ");
        distancia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el numero de galones: ");
        galones = Convert.ToDouble(Console.ReadLine());

        promedio = distancia / galones;

        costo_total = precio_galon * galones;

        Console.WriteLine("El consumo promedio es: " + promedio + " Km por galon");
        Console.WriteLine("El costo total del viaje es: $ " + costo_total);


    }
}