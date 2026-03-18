using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace La8_EV_1083223
{
    internal class L8_EV_1083223
    {
        static void Main(string[] args)
        {
            //Enrique Velasquez 1083223
            //Ejercicio 1
            int nota;
            int notas = 0;
            int aprovado = 0;
            int reprobado = 0;
            int notasaprovado = 0;
            int notasreprovado = 0;
            while (notas < 10)
            {
                //Entrada de variables
                Console.WriteLine("Escriba la nota de un estudiante");
                nota = int.Parse(Console.ReadLine());
                //Proceso si la nota es permitida
                if (nota > 0 && nota <= 100)
                {
                    notas++;
                    switch (nota)
                    {
                        //Proceso si es aprovado
                        case > 61:
                            Console.WriteLine("Estudiante aprovado");
                            notasaprovado = notasaprovado + nota;
                            aprovado++; break;

                        //Proceso si es reprovado
                        case < 61:
                            Console.WriteLine("Estudiante reprobrado");
                            notasreprovado = notasreprovado + nota;
                            reprobado++; break;
                    }
                }

                //Proceso si la nota no es permitida
                else
                {
                    Console.WriteLine("Nota no permitida");
                }
            }
            double promedio = (notasaprovado + notasreprovado) / 10;

            //Salida de datos
            Console.WriteLine("Cantidad de aprovados: " + aprovado);
            Console.WriteLine("Cantidad de reprovados: " + reprobado);
            Console.WriteLine("Promedio: " + promedio);


            //Ejercicio 2
            int numero;
            int pares = 0;
            int impares = 0;
            int suma = 0;
            int x = 1;

            //Entrada de datos
            Console.WriteLine("\n Escriba un numero entero");
            numero = int.Parse(Console.ReadLine());

            //Procedimiento de comparacion de pares e impares, mas suma de los numeros
            while (x <= numero)
            {
                suma += x;

                if (x %2  == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                x++;
            }
            //Salida de datos
            Console.WriteLine("Suma de todos los numeros: " + suma);
            Console.WriteLine("Numeros pares: " + pares);
            Console.WriteLine("Numeros impares: " + impares);


            //Ejercicio 3
            int opcion;
            double compra;
            double TotalVentas = 0;
            int CantClientes = 0;
            int ventas = 0;

            do
            {
                //Menu y entrada de datos
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Registrar compra");
                Console.WriteLine("2. Mostrar total de ventas");
                Console.WriteLine("3. Cantidad de clientes atendidos");
                Console.WriteLine("4. Salir");

                Console.WriteLine("Elija una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    //Procedimiento
                    case 1:
                        Console.WriteLine("Escriba el monto de la compra");
                        compra = double.Parse(Console.ReadLine());

                        //Procedimiento para guardar la compra y sumar a las ventas
                        CantClientes++;
                        ventas++;
                        TotalVentas += compra;

                        Console.WriteLine("Compra adquirida, elija una nueva opcion");
                        break;

                    case 2:
                        //Salida de datos opcion 2
                        Console.WriteLine("El total de ventas es de: " + TotalVentas);
                        break;

                    case 3:
                        //Salida de datos opcion 3
                        Console.WriteLine("Cantidad de clientes atendidos: " + CantClientes);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, vuelva a elegir");
                        break;
                }
            } while (opcion != 4);


            //Ejercicio 4
            int num;
            int NumTotal = 0;
            int Contador = 0;
            int positivos = 0;
            int negativos = 0;

            //Entrada de datos
            Console.WriteLine("\nEscriba un numero entero: ");
            num = int.Parse(Console.ReadLine());

            //Procedimiento
            while (num != 0) 
            {
                //Procedimiento si es mayor o menor a cero
                Contador++;
                if (num < 0)
                {
                    negativos++;
                }
                else if (num > 0)
                {
                    positivos++;
                }

                NumTotal = NumTotal + num;

                Console.WriteLine("Escriba otro numero entero: ");
                num = int.Parse(Console.ReadLine());

            }
            //Salida de datos
            Console.WriteLine("Cantidad de numeros ingresados: " + Contador);
            Console.WriteLine("Cantidad de numeros positivos: " + positivos);
            Console.WriteLine("Canridad de numeros negatios: " + negativos);
            Console.WriteLine("Suma total de los numeros: " + NumTotal);


            //Ejercicio 5
            int N;
            int X;
            int Y;

            //entrada de datos
            Console.WriteLine("\nIngrese un numero");
            N = int.Parse(Console.ReadLine());

            //Procedimiento de las filas
            for (X = 1; X <= N; X++)
            {
                for (Y = 1; Y <= X; Y++)
                {
                    //Salida de datos
                    Console.Write(Y);
                }
                //Salto de linea
                Console.WriteLine();
            }
        }
    }
}