using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_EV_1083223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enrique Daniel Velasquez Solis 1083223

            //Ejercicio 1
            //Entrada de datos e identificacion de las variables
            Console.WriteLine("Escriba la cantidad de numeros que desea sumar: ");
            int cantidad = int.Parse(Console.ReadLine());

            int numeroR = 0;
            int contador = 0; //contador
            while (contador < cantidad)
            {
                Console.WriteLine("Escriba un numero: ");
                int numing = int.Parse(Console.ReadLine());

                //Proceso
                if (numing > 0)
                {
                    //Suma de las variables y suma al contador
                    numeroR = numing + numeroR;
                    contador++; 
                }

                //Proceso para numero no permitido
                else
                {
                    Console.WriteLine("Numero no permitido, porfavor ingrese otro: ");
                }
            }
            //Salida de datos
            Console.WriteLine("Su resultado: " + numeroR );
            int promedio = numeroR / cantidad;
            Console.WriteLine("Su promedio es: " + promedio);


            //Ejercicio 2
            int opcion;
            Console.WriteLine("\n Elija una opcion");

            do
            {
                //Entrada de datos y menu
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Celsius");
                Console.WriteLine("3. Kilometros a Millas");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());

                //Proceso + Salida de datos
                switch (opcion)
                {
                    //Entrada de datos para Celcius a Fahrenheit
                    case 1:
                        Console.WriteLine("Coloque grados Celsius");
                        double celcius = double.Parse(Console.ReadLine());
                        double fahr = (celcius * 9 / 5) + 32; //Proceso
                        Console.WriteLine("\nResultado: " + fahr.ToString("F2")); //Salida de datos
                        break;

                    //Entrada de datos para Fahrenheit a Celcius
                    case 2:
                        Console.WriteLine("Coloque grados Fahrenheit");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        double cel = (fahrenheit - 32) * 5 / 9; //Proceso
                        Console.WriteLine("\n Resultado: " + cel.ToString("F2")); //Salida de datos
                        break;

                    //Entrada de datos para Kilometros a millas
                    case 3:
                        Console.WriteLine("Coloque kilometros");
                        double km = double.Parse(Console.ReadLine());
                        double millas = km * 0.621371; //Proceso
                        Console.WriteLine("\n Resultado: " + millas.ToString("F2")); //Salida de datos
                        break;

                    // Salida de datos de Opcion final y opcion invalida
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 4);


            //Ejercicio 3
            Console.WriteLine("\n Adivine el numero del 1 al 100");

            //Generador de numero aleatorio y identificacion de las variables
            Random rng = new Random();
            int numero = rng.Next(1, 101);
            int num;
            int intentos = 0; //contador
            do
            {
                //Entrada de datos
                Console.WriteLine("Escriba un numero");
                num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 100)
                {
                    //Proceso de Suma de datos y al contador
                    intentos++;

                    if (num > numero)
                    {
                        //Si el numero aleatorio es mayor
                        Console.WriteLine("Mas bajo...");
                    }
                    else if (num < numero)
                    {
                        //Si el numero aleatorio es menor
                        Console.WriteLine("Mas alto...");
                    }
                }
                //Proceso para opcion invalida
                else
                {
                    Console.WriteLine("Numero no valido, vuelva a intentarlo");
                }

            } while(num != numero);

            //Salida de datos
            Console.WriteLine("\n ¡Correcto!");
            Console.WriteLine("La cantidad de intentos fueron: " + intentos);


            //Ejercicio 4
            Console.WriteLine("\n Escriba su PIN");
            //Identificacion de las variables y del contador
            string PINcorrecto = "1234";
            string PIN;
            int intentosMAX = 3;
            int CantInt = 0;
            do
            {
                //Entrada de datos
                PIN = Console.ReadLine();
                //Proceso y comparacion de datos
                CantInt++;

                //Primera salida de datos
                if (PIN != PINcorrecto)
                {
                    Console.WriteLine("PIN incorrecto");
                }
            } while (PIN != PINcorrecto && CantInt < intentosMAX);

            //Segunda salida de datos
            if (CantInt < intentosMAX && PIN == PINcorrecto)
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada");
            }
        }
    }
}
