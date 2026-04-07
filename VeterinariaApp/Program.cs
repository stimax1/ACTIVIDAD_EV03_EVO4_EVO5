using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CLÍNICA VETERINARIA ===");

        Console.Write("Nombre de la mascota: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Tipo de animal (perro/gato/otro): ");
        string tipo = Console.ReadLine()!.ToLower();

        Console.Write("Edad de la mascota: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("¿Tiene cita? (si/no): ");
        string cita = Console.ReadLine()!.ToLower();

        Console.WriteLine("\n--- RESULTADO ---");

        // Validar tipo de animal
        if (tipo == "perro")
        {
            Console.WriteLine("Atención en área canina ");
        }
        else if (tipo == "gato")
        {
            Console.WriteLine("Atención en área felina ");
        }
        else
        {
            Console.WriteLine("Atención en área general ");
        }

        //  Validar edad
        if (edad < 1)
        {
            Console.WriteLine("Es un cachorro, requiere cuidado especial");
        }
        else if (edad >= 1 && edad <= 7)
        {
            Console.WriteLine("Mascota en etapa adulta");
        }
        else
        {
            Console.WriteLine("Mascota en etapa senior");
        }

        //  Validar cita
        if (cita == "si")
        {
            Console.WriteLine("Puede ser atendido inmediatamente");
        }
        else
        {
            Console.WriteLine("Debe esperar turno");
        }

        //  Ejemplo con SWITCH
        Console.WriteLine("\nSeleccione servicio:");
        Console.WriteLine("1. Consulta");
        Console.WriteLine("2. Vacunación");
        Console.WriteLine("3. Urgencias");

        int opcion = int.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Consulta general asignada");
                break;
            case 2:
                Console.WriteLine("Servicio de vacunación asignado");
                break;
            case 3:
                Console.WriteLine("Atención por urgencias");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}