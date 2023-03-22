using System;
//La política de cobro de la empresa telefónica CELphone es: Cuando se realiza una llamada, el cobro es
//por el tiempo que esta dura, de tal forma el costo por minuto es uniforme y es de 30 pesos; además, se
//carga un impuesto del 3% cuando es domingo, y si es otro día, en turno de mañana 15% y en turno de tarde
//10%. Realiza un programa para determinar cuánto debe pagar una persona que realiza una llamada, el
//usuario debe ingresar los minutos que duró la llamada, el día, y el turno.
namespace tp3ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            string dia, horario;
            double precio, impuestodom, impuestot, impuestom;
            Console.WriteLine("Ingresar los minutos que duro la llamada:");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el dia que se realizo la llamada:");
            dia =Console.ReadLine().ToLower();
            Console.WriteLine("Ingresar el horario que se realizo la llamada:");
            horario =Console.ReadLine().ToLower();
            precio =minutos*30;
            impuestodom = (precio * 3) / 100;
            impuestot = (precio * 10) / 100;
            impuestom = (precio * 15) / 100;
            switch (dia)
            {
                case "lunes":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "martes":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                    else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "miercoles":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                    else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "jueves":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                    else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "viernes":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                    else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "sabado":
                    if (horario == "tarde")
                    {
                        precio = precio + impuestot;
                    }
                    else
                    {
                        precio = precio + impuestom;
                    }
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;
                case "domingo":
                    precio = precio + impuestodom;
                    Console.WriteLine("El precio de su llamada es: $" + precio);
                    break;

                    default: Console.WriteLine("Ingrese BIENNN");

                    break;
            }
            Console.ReadKey();


        } 
    }
}
