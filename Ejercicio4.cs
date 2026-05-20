//Calculadora de Promedio de Calificaciones
using System;

class Ejercicio4
{
    static void Main ()
    {
        double nota1, nota2, nota3, promedio;
        bool mayor;



        Console.WriteLine("Ingrese la primer nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3;

        mayor = promedio >= 3.0;

        Console.WriteLine("El promedio es: " + promedio);
        Console.WriteLine("Abrobo la materia?: " + mayor);


    }
}