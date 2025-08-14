using System;
using AppCoffee.src.Modules.User.UI;

namespace AppCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenuPrincipal();
        }

        static void MostrarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("       BIENVENIDO A APPCOFFEE       ");
                Console.WriteLine("====================================");
                Console.WriteLine("\nMenú Principal:\n");
                Console.WriteLine("1. Iniciar sesión");
                Console.WriteLine("2. Registrarse");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\n====================================");
                Console.Write("Seleccione una opción: ");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //ShowLogin();
                        break;
                    case "2":
                        //MostrarRegistro();
                        break;
                    case "3":
                        Console.WriteLine("\n¡Gracias por usar AppCoffee!");
                        return;
                    default:
                        Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
} 