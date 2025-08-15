using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoffee.src.Modules.User.Infrastructure.Repositories;
using AppCoffee.src.Modules.User.Application.Services;
using AppCoffee.src.Modules.User.Domain.Entities;
using CoffeeApp.src.Shared.Context;

namespace AppCoffee.src.Modules.User.UI;

public class LoginMenu
{
    public static void ShowLogin()
    {
        Console.Clear();
        Console.WriteLine("====================================");
        Console.WriteLine("          INICIAR SESIÓN           ");
        Console.WriteLine("====================================");
            
        Console.Write("\nEmail: ");
        var email = Console.ReadLine();
            
        Console.Write("Contraseña: ");
        //var password = OcultarContrasena();
    }
}

public class SignupMenu
{
    public static void ShowSignup()
    {
         Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("           REGISTRARSE             ");
            Console.WriteLine("====================================");
            
            Console.Write("\nNombre completo: ");
            var nombre = Console.ReadLine();
            
            Console.Write("Email: ");
            var email = Console.ReadLine();
            
            Console.Write("Contraseña: ");
            //var password = OcultarContrasena();
            
            Console.Write("\nConfirmar contraseña: ");
           // var confirmPassword = OcultarContrasena();

            // Validaciones básicas
            /*if (password != confirmPassword)
            {
                Console.WriteLine("\nLas contraseñas no coinciden.");
                Console.ReadKey();
                return;
            }*/
    } 
}
