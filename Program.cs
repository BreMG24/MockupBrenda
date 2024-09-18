using System;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int suma = numero1 + numero2;

            Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}");
        }
    }
}