using System;

class Program
{
    static void Main(string[] args)
    {
        // Contraseña correcta definida
        string contraseñaCorrecta = "12345";
        string contraseñaIngresada;
        int intentosRestantes = 3;

        // Ciclo para permitir hasta 3 intentos
        while (intentosRestantes > 0)
        {
            Console.WriteLine("Ingresa su contraseña:");
            contraseñaIngresada = Console.ReadLine();

            // Verificar si la contraseña es correcta
            if (contraseñaIngresada == contraseñaCorrecta)
            {   
                Console.WriteLine("Bienvenido otra vez");
                break; // Salir del ciclo si la contraseña es correcta
            }
            else
            {
                intentosRestantes--; // Reducir el número de intentos restantes
                if (intentosRestantes > 0)
                {
                    Console.WriteLine($"Contraseña incorrecta. {intentosRestantes} intentos restantes.");
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Fuera kbron!!");
                }
            }
        }


    }
}
