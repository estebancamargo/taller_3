//Agencia de Viajes

using System; 

class ejemplo4
{
    static void Main()
    {

        string destino;
        int pasajeros;
        double costoPersona;

        Console.WriteLine("Ingrese su destino: ");
        destino = Console.ReadLine();
        Console.WriteLine("Ingrese el numero de pasajeros: ");
        pasajeros = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el costo por persona");
        costoPersona = Convert.ToDouble(Console.ReadLine());

        double totalBase = pasajeros * costoPersona;

        bool totalConDescu = pasajeros > 5 && destino == "cancun";

        int tieneDesc = Convert.ToInt32(totalConDescu);

        double descuento = totalBase * 0.10 * tieneDesc;
        double totalFinal = totalBase - descuento; 

        Console.WriteLine("Total base: $" + totalBase);
        Console.WriteLine("¿Aplica descuento?: " + totalConDescu);
        Console.WriteLine("Descuento: $" + descuento);
        Console.WriteLine("Total final: $" + totalFinal);
        

    }
}