//Diferencia de Valores: Compara si dos nombres de usuario ingresados son diferentes usando !=.
using System;

class ejemplo5
{
    static void Main ()
    {
        string nom1, nom2;
        Console.WriteLine("Ingrese el primer numero: ");
        nom1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero: ");
        nom2 = Console.ReadLine();

        bool diferente = nom1 != nom2;

        Console.WriteLine(diferente);
    }
        }
        