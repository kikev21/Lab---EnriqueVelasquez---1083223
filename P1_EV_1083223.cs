using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    internal class P1_EV_1083223
    {
        static void Main(string[] args)
        {
            //Entradas del programa (nombre, codigo y capacidad de parqueo)
            Console.WriteLine("¡Saludos! Porfavor escriba su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\n¡Saludos " + nombre + "! Porfavor escriba su codigo de turno: ");
            int CodigoTurno = int.Parse(Console.ReadLine());
            //Ciclo por si el usuario ingresa un codigo de turno incorrecto
            while (CodigoTurno <= 1000 || CodigoTurno >= 9999)
            {
                Console.ForegroundColor = ConsoleColor.Red; //cambio de color de texto
                Console.WriteLine("Error, codigo no valido. Intente de nuevo:");
                Console.ResetColor();

                CodigoTurno = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen; //Cambio de color de fondo
            Console.WriteLine("Codigo identificado");
            Console.ResetColor();

            Console.WriteLine("Escriba la capacidad de parqueo");
            int CapacidadParqueo = int.Parse(Console.ReadLine());
            //Ciclo por si el usuario ingresa un numero de parqueo invalido
            while (CapacidadParqueo < 10)
            {
                Console.WriteLine("Parque no valido, debe de ser minimo 10");
                CapacidadParqueo = int.Parse(Console.ReadLine());
            }
            //Variables durante el programa entero
            int TicketsCreados = 0;
            int TicketsCerrados = 0;
            double DineroRecaudado = 0.00;
            int TiempoSimulado = 0;

            bool ticketactivo = false;
            int vehiculo = 0;
            int MinEntrada = 0;
            int ocupados = 0;

            int opcion;

            do
            {
                //Menu del parqueo y entrada de la opcion
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n ---MENU DEL PARQUEO SMARTPARK---");
                Console.WriteLine("1. Crear ticket");
                Console.WriteLine("2. Salida y cobro");
                Console.WriteLine("3. Revisar estado del parqueo");
                Console.WriteLine("4. Simulacion del tiempo");
                Console.WriteLine("5. Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (opcion)
                {
                    case 1: //Creacion de ticket
                        Console.ResetColor();
                        if (ticketactivo == true)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow; //Desicion si ya hay un ticket
                            Console.WriteLine("¡Ya existe un ticket activo!");
                            Console.ResetColor();
                            break;
                        }

                        if (ocupados >= CapacidadParqueo) //Desicion si el parque esta lleno
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Parqueo lleno!");
                            Console.ResetColor();
                            break;
                        }
                        //Entrada de datos acerca del tipo de vehiculo
                        Console.WriteLine("Escriba su tipo de vehiculo (1. moto, 2. auto, 3. pickup)");
                        vehiculo = int.Parse(Console.ReadLine());

                        while (vehiculo < 1 || vehiculo > 3) //Ciclo si el usuario escribe una opcion invalida
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tipo de vehiculo invalido, vuelva a intentalo");
                            vehiculo = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                        }
                        //Proceso de el tiempo exacto donde el vehiculo entra
                        MinEntrada = TiempoSimulado;
                        ticketactivo = true; //Activacion de ticket
                        //suma de la cantidad de espacios y tickets cerrados
                        ocupados++;
                        TicketsCreados++;

                        //Salida
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Se ha creado un ticket");
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.ResetColor();
                        if (ticketactivo == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No hay un ticket activo, porfavor crearlo en la opcion 1 del menu");
                            Console.ResetColor();
                            break;
                        }
                        //Proceso para calcular cuanto tiempo estuvo el vehiculo
                        int min = TiempoSimulado - MinEntrada;
                        int horas = min / 60;

                        if (min % 60 != 0)
                        {
                            horas++;
                        }

                        //Determina la tarifa de cada tipo de vehiculo
                        double tarifa = 0.00;

                        switch (vehiculo)
                        {
                            case 1: 
                                tarifa = 5; 
                                break;

                            case 2: 
                                tarifa = 10; 
                                break;

                            case 3: 
                                tarifa = 15; 
                                break;
                        }
                        //Calcular el total a pagar
                        double total = horas * tarifa;
                        if (min <= 15)
                        {
                            total = 0;
                        }
                        else if (horas > 6)
                        {
                            total += 25;
                        }
                        //Salida del total a pagar
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Su total a pagar es de:  Q" + total);
                        DineroRecaudado = DineroRecaudado + total;
                        TicketsCerrados++;
                        ticketactivo = false;
                        ocupados--;

                        Console.ResetColor();
                        break;

                    case 3:
                        //salida de las diferentes variables actuales
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nCapacidad: " + CapacidadParqueo);
                        Console.WriteLine("Ocupados: " + ocupados);
                        Console.WriteLine("Disponibles: " + (CapacidadParqueo - ocupados));
                        Console.WriteLine("Tiempo: " + TiempoSimulado);
                        Console.WriteLine("Recaudado: Q" + DineroRecaudado);
                        Console.WriteLine("Tickets creados: " + TicketsCreados);
                        Console.WriteLine("Tickets cerrados: " + TicketsCerrados);
                        Console.ResetColor();
                        break;

                    case 4:
                        //Entrada de cuanto tiempo pasa
                        Console.ResetColor();
                        Console.WriteLine("\nIngrese la cantidad de minutos");
                        int tiempo = int.Parse(Console.ReadLine());

                        while (tiempo < 1 || tiempo > 1440) //Ciclo por si el usuario ingresa un numero invalido o fuera del rango de 1 a 1440
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Tiempo invalido, vuelva a intentarlo");
                            tiempo = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                        }
                        //Proceso para que el reloj vaya avazando
                        TiempoSimulado = TiempoSimulado + tiempo;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        //Salida del tiempo total que ha pasado
                        Console.WriteLine("Tiempo actualizado: " + TiempoSimulado);
                        Console.ResetColor();
                        break;

                    case 5:
                        //Salida del resumen final del turno
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Resumen final:");
                        Console.WriteLine("Dinero total recaudado: Q" + DineroRecaudado);
                        Console.WriteLine("Cantidad de tickets creados: " + TicketsCreados);
                        break;

                    default:
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opcion invalida, vuelva a escoger"); //Salida por si el usuario elije una opcion invalida
                        Console.ResetColor();
                        break;
                }

            } while (opcion != 5); //Fin del ciclo del menu del parqueo
        }
    }
}