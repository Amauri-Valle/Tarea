using System;

namespace Trabajo_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            string Palabra="Chinga a tu madre";

            Console.WriteLine("Escriba el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado es: " + resultado+ "" + Palabra);
            
        }
    }
}
