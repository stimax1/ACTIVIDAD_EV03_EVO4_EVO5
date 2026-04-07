using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. Mostrar números del 1 al 10 (for)");
            Console.WriteLine("2. Sumar números hasta ingresar 0 (while)");
            Console.WriteLine("3. Tabla de multiplicar (for)");
            Console.WriteLine("4. Validar contraseña (do...while)");
            Console.WriteLine("5. Contar números pares del 1 al 100");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nNúmeros del 1 al 10:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 2:
                    int suma = 0;
                    int numero;

                    Console.WriteLine("\nIngrese números (0 para terminar):");
                    numero = int.Parse(Console.ReadLine()!);

                    while (numero != 0)
                    {
                        suma += numero;
                        numero = int.Parse(Console.ReadLine()!);
                    }

                    Console.WriteLine("La suma total es: " + suma);
                    break;

                case 3:
                    Console.Write("\nIngrese un número: ");
                    int num = int.Parse(Console.ReadLine()!);

                    Console.WriteLine($"Tabla de multiplicar del {num}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} x {i} = {num * i}");
                    }
                    break;

                case 4:
                    string clave;

                    do
                    {
                        Console.Write("\nIngrese la contraseña: ");
                        clave = Console.ReadLine()!;
                    }
                    while (clave != "1234");

                    Console.WriteLine("Acceso permitido");
                    break;

                case 5:
                    int contador = 0;

                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 2 == 0)
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine("\nCantidad de números pares del 1 al 100: " + contador);
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 0);
    }
}