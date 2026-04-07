using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese número 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese número 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {n1 + n2}");
        Console.WriteLine($"Resta: {n1 - n2}");
        Console.WriteLine($"Multiplicación: {n1 * n2}");
        Console.WriteLine($"División: {n1 / n2}");
    }
}