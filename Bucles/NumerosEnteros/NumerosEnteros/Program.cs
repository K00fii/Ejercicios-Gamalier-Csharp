using System;


internal class Program
{

    static void Main(string[] args)
    {



        int cantidadNumero, numero;
        int positivos = 0, negativos = 0, pares = 0, inpares = 0;

        Console.WriteLine("Introduzca la cantidad");
        cantidadNumero = Convert.ToInt32(Console.ReadLine());



        for (int i = 1; i <= cantidadNumero; i++)
        {

            Console.WriteLine("Introzca un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El conteo se detuvo");
                break;

            }

            if (numero > 0)
            {

                positivos++;

            }

            else if (numero < 0)

            { 

            negativos++;

            }



            if (numero % 2 == 0)
            {

                pares++;

            }

            else
            {
                inpares++;
            }
        
        
        
        
        
        }



        Console.WriteLine($"Cantidad de numeros positivos {positivos}");
        Console.WriteLine($"Cantidad de numeros negativos {negativos}");
        Console.WriteLine($"Cantidad de numeros pares {pares}");
        Console.WriteLine($"Cantidad de numeros inpares {inpares}");

    }



}