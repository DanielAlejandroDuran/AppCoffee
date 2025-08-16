using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoffee.src.Modules.User.Infrastructure.Repositories;
using AppCoffee.src.Modules.User.Application.Services;
using AppCoffee.src.Modules.User.Domain.Entities;
using AppCoffee.src.Shared.Context;

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
        Console.WriteLine("          REGISTRARSE              ");
        Console.WriteLine("====================================");

        Console.Write("\nNombre: ");
        var nombre = Console.ReadLine();

        Console.Write("Email: ");
        var email = Console.ReadLine();

        Console.Write("Contraseña: ");
        var password = OcultarContrasena();

        Console.Write("\nConfirmar contraseña: ");
        var confirmPassword = OcultarContrasena();

        ValidarContrasenas(password, confirmPassword);

        // Aquí puedes llamar al servicio de registro de usuario
    }

      private readonly UserService _userService;

    // Inyectamos el servicio en el constructor
    public SignupMenu(UserService userService)
    {
        _userService = userService;
    }

    public void Mostrar()
    {
        Console.Clear();
        MostrarEncabezado();

        var (nombre, email, password) = ObtenerDatosRegistro();

        try
        {
            // Usamos el servicio para registrar el usuario
            _userService.RegistrarUsuarioConTareaAsync(nombre, email, password).Wait();

            Console.WriteLine("\n¡Registro exitoso! Presione cualquier tecla para continuar...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
            Console.WriteLine("Presione cualquier tecla para volver a intentar...");
        }

        Console.ReadKey();
    }

    private void MostrarEncabezado()
    {
        Console.WriteLine("===============================");
        Console.WriteLine("      REGISTRO DE USUARIO      ");
        Console.WriteLine("===============================");
        Console.WriteLine();
    }

    private (string nombre, string email, string password) ObtenerDatosRegistro()
    {
        Console.Write("Nombre completo: ");
        var nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Exception("El nombre no puede estar vacío");

        Console.Write("Email: ");
        var email = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(email))
            throw new Exception("El email no puede estar vacío");

        Console.Write("Contraseña: ");
        var password = OcultarContrasena();

        Console.Write("\nConfirmar contraseña: ");
        var confirmPassword = OcultarContrasena();

        ValidarContrasenas(password, confirmPassword);

        return (nombre, email, password);
    }

    private static void ValidarContrasenas(string password, string confirmPassword)
    {
        if (password != confirmPassword)
        {
            throw new Exception("Las contraseñas no coinciden");
        }

        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            throw new Exception("La contraseña debe tener al menos 6 caracteres");
        }
    }

    private static string OcultarContrasena()
    {
        var password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Remove(password.Length - 1);
                Console.Write("\b \b");
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }
    

}
