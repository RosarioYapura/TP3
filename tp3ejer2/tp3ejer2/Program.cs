using System;

namespace tp3ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, nummas;
            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 500)
            {
                nummas = ((num * 18) / 100)+num;
                Console.WriteLine("el numero mas el 18% es: " + nummas);
            }
            Console.ReadKey();
        }
    }
}
