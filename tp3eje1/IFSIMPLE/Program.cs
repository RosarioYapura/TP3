using System;

namespace tp3ejer1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            decimal minimo;
            minimo = 80000;
            Console.WriteLine("Ingrese su sueldo actual: ");
            salario = Convert.ToDecimal(Console.ReadLine());
            if (salario > minimo)
            {
                Console.WriteLine("Usted gana mas que la minima");
                Console.WriteLine("Su salario es: " + salario);
            }
            else 
                {
                Console.WriteLine("Usted gana menos que la minima");
                Console.WriteLine("Su salario es: " + salario);
            }
            
            Console.ReadKey();
        }
    }
}
