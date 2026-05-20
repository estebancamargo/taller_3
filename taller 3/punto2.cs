using System;

class punto2
{
    static void Main()
    {
        
        double time;

        Console.WriteLine("Cuanto tiempo de experiencia tiene como ing? ");
        time = Convert.ToDouble(Console.ReadLine());

        if (time >= 5)
        {
            Console.WriteLine("Es Senior");
        } else
        {
            Console.WriteLine("Es Junior");
        }
    } 
        }