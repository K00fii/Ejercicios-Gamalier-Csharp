using System;

class Program
{

    static void Main(string[] args)
    {
     

        Console.WriteLine("Introduzca su Edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca su Genero");
        char sexo = Convert.ToChar(Console.ReadLine());

        if (edad >= 18)
        {
        
            if (sexo == 'f')
            {
                Console.WriteLine("Entra Gratis");
            }

            else if (sexo == 'm')
            {
                Console.WriteLine("Puede Entrar, pero debe Pagar");
            }

            else
            {
                Console.WriteLine("Debe especificar su Género");
            }
        }


        else
        {
            Console.WriteLine("Debe ser mayor de edad para entrar");
        }

        
    }

}   