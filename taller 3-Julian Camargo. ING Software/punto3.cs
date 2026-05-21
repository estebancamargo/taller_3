using System;

class punto3
{
    static void Main()
    {
        int pruebasUnit;
        bool revision;

        Console.WriteLine("Ingrese el numero de pruebas unitarias superadas: ");
        pruebasUnit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Paso la revision de seguridad (true/false)?");
        revision = Convert.ToBoolean(Console.ReadLine());

        bool pasoAutorizacion = pruebasUnit >= 10 && revision;
        bool noPasoAutorizacion = !pasoAutorizacion;

        Console.WriteLine("Paso autorizacion: " + pasoAutorizacion);
        Console.WriteLine("No paso la autorizacion: " + noPasoAutorizacion);
    }
}