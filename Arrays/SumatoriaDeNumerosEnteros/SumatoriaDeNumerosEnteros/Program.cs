using System;

class Program
{
    static void Main(string[] args)
    {
        
        int numero, sumatoria = 0;
        string respuesta;

        do
        {
           
            Console.WriteLine("Introduce un número entero:");
            numero = Convert.ToInt32(Console.ReadLine());

        
            sumatoria += numero;

           
            if (sumatoria >= 100)

            {
                Console.WriteLine("La sumatoria es mayor o igual a 100.");
                break;
            }

            // Preguntar si desea continuar introduciendo números
            Console.WriteLine("¿Deseas introducir otro número? (Si/No):");
            respuesta = Console.ReadLine().ToLower();

        } while (respuesta == "si");

       
        Console.WriteLine($"La sumatoria total es: {sumatoria}");

       
    }
}
