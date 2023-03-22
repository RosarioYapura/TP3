
using System;
using System.Security.AccessControl;

namespace tp3ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese una letra: ");
            letra = Convert.ToChar(Console.ReadLine());
                if (letra == 'a'||letra== 'e'||letra=='i'||letra=='o'||letra=='u')
            {

                Console.WriteLine("La letra ingresada " + letra + " es una consonante ");
            }
                else
            {
                Console.WriteLine("La letra ingresada " + letra + " es una vocal");
            }
            Console.ReadKey();
        }
    }
}
