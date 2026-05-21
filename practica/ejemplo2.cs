//17. Acceso Preferencial: Un usuario accede si es "Socio" o si su compra es mayor a $500 usando ||.
using System;

class ejemplo2
{
    static void Main ()
    {
        string tipoUsuario;
        double compra;

        Console.WriteLine("ingrese el tipo de usuario");
        tipoUsuario = Console.ReadLine();

        Console.WriteLine("Ingrese el valor de compra: ");
        compra = Convert.ToDouble(Console.ReadLine());

        bool acceso = tipoUsuario == "socio" || compra > 500;

        Console.WriteLine(acceso);
    }
        }
        