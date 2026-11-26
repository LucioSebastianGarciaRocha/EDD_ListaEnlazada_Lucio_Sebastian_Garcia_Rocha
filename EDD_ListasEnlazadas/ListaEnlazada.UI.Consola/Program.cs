using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        do
        {
            MostrarMenu();
            if (!LeerEntero("Elige una opcion: ", out opcion))
            {
                opcion = -1;
            }
            Console.WriteLine();
            switch (opcion)
            {
                case 15:
                    Console.WriteLine("Hasta luego. ");
                    break;
                default:
                    Console.WriteLine("Opcion invalida. Elige un numero del 1 al 15");
                    break;
            }
            if (opcion != 15)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey(true);
            }
        } while (opcion != 15);
    }
    private static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("---Lista Enlazada---");
        Console.WriteLine("Menu de opciones");
        Console.WriteLine("15. Salir\n");
    }

    private static bool LeerEntero(string mensaje, out int valor)
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out valor))
        {
            return true;
        }
        Console.WriteLine("Debes escribir un numero entero");
        return false;
    }
    }

