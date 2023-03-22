using System;
//Crea una aplicación que nos pida un día de la semana y que nos diga si es un día laboral o no.

namespace tp3ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Ingresa el dia de la semana: ");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "martes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "miercoles":
                    Console.WriteLine("Dia laborable");
                    break;
                case "jueves":
                    Console.WriteLine("Dia laborable");
                    break;
                case "viernes":
                    Console.WriteLine("Dia laborable");
                    break;
                case "sabado":
                    Console.WriteLine("Dia  NO laborable");
                    break;
                case "domingo":
                    Console.WriteLine("Dia NO laborable");
                    break;
                

          
           }
            Console.ReadKey();
        } 
    }
}
