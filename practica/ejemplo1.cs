//Validación de Rango: Verifica si un número ingresado es mayor a 0 y menor a 100 usando &&.

using System;

class ejemplo1
{
    static void Main ()
    {
        int numero;
        Console.WriteLine("Ingrese un numero:");
        numero = Convert.ToInt32(Console.ReadLine());
        bool rango = numero > 0 && numero < 100;
    }
        }