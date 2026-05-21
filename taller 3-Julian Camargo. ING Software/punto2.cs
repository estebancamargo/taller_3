using System;

class punto2
{
    static void Main()
    {
        double time;

        Console.WriteLine("Cuanto tiempo de experiencia tiene como ing? ");
        time = Convert.ToDouble(Console.ReadLine());

        bool esSenior = time >= 5;
        bool esJunior = !esSenior;

        Console.WriteLine("Es Senior: " + esSenior);
        Console.WriteLine("Es Junior: " + esJunior);
    }
}