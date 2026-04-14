using System;
using System.Runtime.CompilerServices;

class L10_EV_1083223
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Escriba un numero entero");
        int numero = int.Parse(Console.ReadLine()); //Entrada

        while (numero < 0)
        {
            Console.WriteLine("numero no permitido, intentelo de nuevo");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Suma de digitos: " + sumarnumeros(numero)); //Salida


        //Ejercicio 2
        Console.WriteLine("\nEscriba un numero para elevarlo al cuadrado");
        int num = int.Parse(Console.ReadLine()); //Entrada

        Console.WriteLine(ElevarCuadrado(ref num));

        Console.WriteLine("Numero al cuadrado: " + num); //Salida


        //Ejercicio 3
        Console.WriteLine("\nEscriba el precio");
        double precio = double.Parse(Console.ReadLine()); //Entrada de precio
        Console.WriteLine("\nEscriba el descuento");
        double descuento = double.Parse(Console.ReadLine()); //Entrada de descuento

        while (descuento > 0.99 || descuento < 0)
        {
            Console.WriteLine("Descuento no permitido, intente de nuevo");
            descuento = double.Parse(Console.ReadLine());
        }

        double monto = AplicarDescuento(descuento, ref precio);

        Console.WriteLine("Precio total: " + precio); //Salida de precio total
        Console.WriteLine("Descuento: " + monto); //Salida de descuento


        //Ejercicio 4
        Console.WriteLine("\nEscriba la energia");
        int energiaJugador = int.Parse(Console.ReadLine()); //Entrada

        while (energiaJugador <= 0)
        {
            Console.WriteLine("La energia no puede ser cero, intente de nuevo");
            energiaJugador = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nEnergia actual: " + energiaJugador); //Salida de la energia actual

        consumirEnergia(ref energiaJugador);
        Console.WriteLine("Despues de consumir: " + energiaJugador); //salida de la consumicion de energia

        recargarEnergia(ref energiaJugador);
        Console.WriteLine("Despues de recargar: " + energiaJugador); //Salida de recarga de energia

        Console.WriteLine("Estado: " + obtenerEstado(energiaJugador)); //Salida de obtener el estado
        Console.WriteLine("Rendimiento: " + calcularRendimiento(energiaJugador)); //Salida de calculo de rendimiento
    }



    //FUNCIONES

    //funcion ejercicio 1
    static int sumarnumeros(int num)
    {
        //Procedimiento
        int suma = 0;

        while (num > 0)
        {
            suma = suma + num%10;
            num = num / 10;
        }

        return suma;
    }


    //Funcion ejercicio 2
    static string ElevarCuadrado(ref int num)
    {
        //Procedimiento
        num = num * num;
        return "El numero se elevo al cuadrado correctamente"; //salida de texto
    }


    //Funcion ejercicio 3
    static double AplicarDescuento(double descuento, ref double precio)
    {
        //Procedimiento
        double montoDescuento = precio * descuento;
        precio = precio - montoDescuento;
        return montoDescuento;
    }


    //Funcion ejercicio 4.1
    static int consumirEnergia(ref int energiaJugador)
    {
        //Procedimiento
        energiaJugador = energiaJugador - 4;
        if (energiaJugador < 0)
        {
            energiaJugador = 0;
        }
        return energiaJugador;
    }


    //Funcion ejercicio 4.2
    static int recargarEnergia(ref int energiaJugador)
    {
        //Procedimiento
        energiaJugador = energiaJugador + 6;

        if (energiaJugador > 20)
        {
            energiaJugador = 20;
        }
        return energiaJugador;
    }


    //Funcion ejercicio 4.3
    static string obtenerEstado(int energiaJugador)
    {
        //Procedimiento
        if (energiaJugador >= 15)
        {
            return "Alta";
        }
        else if (energiaJugador >= 8 && energiaJugador < 15)
        {
            return "media";
        }
        else
        {
            return "baja";
        }
    }


    //Funcion ejercicio 4.4
    static string calcularRendimiento(int energiaJugador)
    {
        //Procedimiento
        if (energiaJugador == 20)
        {
            return "S";
        }
        else if (energiaJugador >= 15 && energiaJugador <= 19)
        {
            return "A";
        }
        else if (energiaJugador >= 8 && energiaJugador <= 14)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }
}
