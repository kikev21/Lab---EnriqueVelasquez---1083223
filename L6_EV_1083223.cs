using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_EV_1083223
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1
            //Entrada de datos
            Console.WriteLine("\n Escriba su tipo de vehiculo \n");
            Console.WriteLine("1: Bicicleta");
            Console.WriteLine("2: Motocicleta");
            Console.WriteLine("3: Auto");
            Console.WriteLine("4: Camion");
            Console.WriteLine("5: Autobus \n");
            int Vehiculo = int.Parse(Console.ReadLine());
            switch (Vehiculo)
            {
                //Salida de datos
                case 1: Console.WriteLine("Vehiculo no motorizado"); break;
                case 2: Console.WriteLine("Vehiculo ligero"); break;
                case 3: Console.WriteLine("Vehiculo mediano"); break;
                case 4: Console.WriteLine("Vehiculo pesado"); break;
                case 5: Console.WriteLine("Transporte publico"); break;
                default: Console.WriteLine("¡ERROR!"); break;
            }


            //Ejercicio 2
            //Entrada de datos
            Console.WriteLine("\n Escriba su tipo de tarjeta \n");
            Console.WriteLine("tipo: 1");
            Console.WriteLine("tipo: 2");
            Console.WriteLine("tipo: 3");
            Console.WriteLine("otro tipo: 4+");
            int targeta = int.Parse(Console.ReadLine());
            switch (targeta)
            {
                //Salida de datos
                case 1: Console.WriteLine("Su tarjeta tendra un aumento del 25%"); break;
                case 2: Console.WriteLine("Su tarjeta tendra un aumento del 35%"); break;
                case 3: Console.WriteLine("Su tarjeta tendra un aumento del 40%"); break;
                default: 
                    if (targeta >= 4)
                    {
                        Console.WriteLine("Su tarjeta tendra un aumento del 50%");
                    }
                    else
                    {
                        Console.WriteLine("Tipo de tarjeta no valida");
                    }
                    break;
            }


            //Ejercicio 3
            //Entrada de datos
            Console.WriteLine("\n Escriba la puntuacion del empleado \n");
            Console.WriteLine("puntuacion 0.0");
            Console.WriteLine("puntuacion 0.4");
            Console.WriteLine("puntuacion 0.6 o mas");
            double puntuacion = double.Parse(Console.ReadLine());
            double dinero = puntuacion * 2400;
            switch (puntuacion)
            {
                //Salida de datos
                case 0.0:
                    Console.WriteLine("\n La cantidad de dinero obtenida es: " + dinero + " Euros");
                    Console.WriteLine("\n Su nivel es inaceptable"); break;
                case 0.4:
                    Console.WriteLine("\n La cantidad de dinero obtenida es: " + dinero + " Euros");
                    Console.WriteLine("\n Su nivel es aceptable"); break;
                default:
                    if (puntuacion >= 0.6)
                    {
                        Console.WriteLine("\n La cantidad de dinero obtenida es: " + dinero + " Euros");
                        Console.WriteLine("\n Su puntuacion es meritorio");
                    }
                    else
                    {
                        Console.WriteLine("Puntuacion no valida");
                    }
                    break;
            }


            //Ejercicio 4
            //entrada de datos
            Console.WriteLine("\n Escriba el tipo de pizza que desea \n");
            Console.WriteLine("1. Vegetariana");
            Console.WriteLine("2. No vegetariana");
            int tipopizza = int.Parse(Console.ReadLine());

            switch (tipopizza)
            {
                //Entrada de datos para pizza vegetariana
                case 1:
                    Console.WriteLine("\n Elija un ingrediente:");
                    Console.WriteLine("1. Pimiento");
                    Console.WriteLine("2. Tofu");
                    int ingredienteV = int.Parse(Console.ReadLine());

                    switch (ingredienteV)
                    {
                        //salida de datos
                        case 1:
                            Console.WriteLine("Pizza vegetariana con tomate, mozzarella y pimiento."); break;
                        case 2:
                            Console.WriteLine("Pizza vegetariana con tomate, mozzarella y tofu."); break;
                        default:
                            Console.WriteLine("Ingrediente no válido."); break;
                    }
                    Console.WriteLine("¡Gracias por elegirnos, buen provecho!"); break;

                //entrada de datos para pizza no vegetariana
                case 2:
                    Console.WriteLine("\n Elija un ingrediente:");
                    Console.WriteLine("1. Peperoni");
                    Console.WriteLine("2. Jamon");
                    Console.WriteLine("3. Salmon");
                    int ingredienteN = int.Parse(Console.ReadLine());

                    switch (ingredienteN)
                    {
                        //salida de datos
                        case 1:
                            Console.WriteLine("Tu pizza no vegetariana contiene tomate, mozzarella y peperoni."); break;
                        case 2:
                            Console.WriteLine("Tu pizza no vegetariana contiene tomate, mozzarella y jamon."); break;
                        case 3:
                            Console.WriteLine("Tu pizza no vegetariana contiene tomate, mozzarella y salmon."); break;
                        default:
                            Console.WriteLine("Ingrediente no valido."); break;
                    }
                    Console.WriteLine("¡Gracias por elegirnos, buen provecho!"); break;

                default:
                    Console.WriteLine("Tipo de pizza no valido."); break;
            }
        }
    }
}
