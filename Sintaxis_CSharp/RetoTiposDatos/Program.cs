using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura: {altura}");
    }
}