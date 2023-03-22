using System;
//Diseñe un programa que lea un número de tres cifras y determine si es o no capicúa.
namespace tp3ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, unidades, centenas, decenas;
            Console.WriteLine("Escribe un numero de 3 digitos: ");
            num = int.Parse(Console.ReadLine());
            if(num>99 && num < 1000)
            {
                unidades = num % 10;
                centenas = num / 100;
                decenas = (num % 100) / 10;
                if (unidades == centenas)
                {
                    Console.WriteLine("El numero es capicua: " + num);
                }
                else
                {
                    Console.WriteLine("El numero no es capicua: " + num);
                }
            }
            Console.ReadKey();
        }
    }
}
