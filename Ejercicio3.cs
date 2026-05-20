//Simulador de Salario Neto Semanal
using System;

class Ejercicio3
{
    static void Main ()
{
    string nombre;
    int horasT;
    double valorHr, salarioB, totalN, descu;
    
    Console.WriteLine("Ingrese su nombre: ");
    nombre = Console.ReadLine();

    Console.WriteLine("Ingrese las horas trabajadas: ");
    horasT = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Ingrese el valor de la hora: ");
    valorHr = Convert.ToDouble(Console.ReadLine());

    salarioB = horasT * valorHr;
    descu = salarioB * 0.08;
    totalN = salarioB - descu;

    Console.WriteLine(nombre);
    Console.WriteLine("Su salario bruto es: $" + salarioB);
    Console.WriteLine("El descuento fijo por salud y pension es: $" + descu);
    Console.WriteLine("Su salario neto es: $" + totalN);

}
}