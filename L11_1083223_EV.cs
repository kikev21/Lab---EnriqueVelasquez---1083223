using System;
using System.Runtime.CompilerServices;

class L11_1083223_EV
{
    static void Main()
    {
        //Ejercicio 1
        //Declaracion de variables
        string contraseña;
        bool mayus = false;
        bool numero = false;
        bool caracterEsp = false;

        Console.WriteLine("Escriba una contraseña");
        contraseña = Console.ReadLine(); //Entrada de datos

        //Procedimiento
        for (int i = 0; i < contraseña.Length; i++)
        {
            if (char.IsUpper(contraseña[i]))
            {
                mayus = true;
            }

            if (char.IsDigit(contraseña[i]))
            {
                numero = true;
            }

            if (!char.IsLetterOrDigit(contraseña[i]))
            {
                caracterEsp = true;
            }
        }
         //Salida de datos
        if (contraseña.Length >= 8 && mayus && numero && caracterEsp)
        {
            Console.WriteLine("Contraseña valida");
        }
        else
        {
            Console.Write("Invalida: ");

            if (contraseña.Length < 8)
            {
                Console.WriteLine("falta mayor longitud");
            }

            if (!mayus)
            {
                Console.WriteLine("Falta mayuscula");
            }

            if (!numero)
            {
                Console.WriteLine("Falta numero");
            }

            if (!caracterEsp)
            {
                Console.WriteLine("Falta caracter especial");
            }
        }



        //Ejercicio 2
        //Declaracion de variables
        string palabra;
        string palabraInvertida = "";

        Console.WriteLine("\nIngrese una palabra");
        palabra = Console.ReadLine(); //Entrada de datos

        //Procedimiento
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida = palabraInvertida + palabra[i];
        }

        Console.WriteLine("Palabra invertida: " + palabraInvertida); //Salida de datos



        //Ejercicio 3
        //Declaracion de variables y entrada de datos
        int num;

        Console.WriteLine("\nCantidad de numeros que desea ingresar");
        num = int.Parse(Console.ReadLine());

        int[] numeros = new int[num];
        int suma = 0;

        //Procedimiento
        Console.WriteLine("Ingrese los numeros deseados");

        for (int i = 0; i < num; i++)
        {
            //Segunda entrada de datos
            numeros[i] = int.Parse(Console.ReadLine());
            suma = suma + numeros[i];
        }

        //Segunda entrada de datos
        int mayor = numeros[0];
        int menor = numeros[0];

        for (int i = 0; i < num; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        double promedio = Convert.ToDouble(suma) / num;

        //Salida de datos
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);



        //Ejercicio 4
        //Declaracion de variables
        int NumBuscado;
        int[] arreglo = new int[8];
        bool NumEncontrado = false;

        Console.WriteLine("\nEscriba 8 numeros");

        //Entrada de datos
        for (int i = 0; i < 8; i++)
        {
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        //Segunda entrada de datos
        Console.WriteLine("Escriba el numero que desee buscar");
        NumBuscado = int.Parse(Console.ReadLine());

        //Procedimiento
        for (int i = 0; i < 8; i++)
        {
            if (NumBuscado == arreglo[i])
            {
                NumEncontrado = true;

                //Primera salida de datos
                Console.WriteLine("El numero si existe en la posicion: " + i);
                break;
            }
        }

        if (NumEncontrado == false)
        {
            //Segunda salida de datos
            Console.WriteLine("El numero no existe");
        }



        //Ejercicio 5
        //Declaracion de variables
        string[] nombres = new string[5];
        int nomMas5 = 0;
        string MasLargo = "";
        Console.WriteLine("\nEscriba 5 nombres");

        //Entrada de datos
        for (int i = 0; i < 5; i++)
        {
            //Entrada de datos
            nombres[i] = Console.ReadLine();
            string Largo = nombres[0];

            //Procedimiento
            if (nombres[i].Length > 5)
            {
                nomMas5++;
            }

            if (nombres[i].Length > Largo.Length)
            {
                Largo = nombres[i];
                MasLargo = Largo;
            }
        }

        //Salida de datos
        Console.WriteLine("Nombres ingresados: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(nombres[i] + " , ");
        }

        Console.WriteLine("Nombres con mas de 5 letras: " + nomMas5);
        Console.WriteLine("Nombre mas largo: " + MasLargo);


       
    }
}