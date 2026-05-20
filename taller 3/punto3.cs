using System;

class punto3
{
    static void Main()
    {
        int pruebasUnit;
        bool revision;

        Console.WriteLine("Ingrese el numero de pruebas unitarias superadas: ");
        pruebasUnit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Paso la revision de seguridad (si/no)?");
        revision = Convert.ToBoolean(Console.ReadLine());


        if (pruebasUnit >= 10 && revision)
        {
            Console.WriteLine("Paso autorizacion");
        } else
        {
            Console.WriteLine("No paso la autorizacion");
        }
    }
}