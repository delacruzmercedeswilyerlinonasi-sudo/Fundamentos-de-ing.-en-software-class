using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Estás solo en la oscuridad...");
        Console.Write("¿Escuchar sonido? (si/no): ");
        string r = Console.ReadLine();
        if (r == "si") Console.WriteLine("Escuchas pasos detrás de ti...");
        else Console.WriteLine("El silencio es peor...");
    }
}