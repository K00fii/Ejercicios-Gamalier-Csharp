using System;

class Program
{
    static void Main()
    {
       
        decimal[] numeros = new decimal[5];
        decimal suma = 0;

       
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = Convert.ToDecimal(Console.ReadLine());
            suma += numeros[i]; 
        }

       
        decimal promedio = suma / 5;

        
        Console.WriteLine($"\nEl promedio de los números ingresados es: {promedio:F2}");
    }
}
