using System;
using System.Runtime.CompilerServices;
using System.Transactions;

class L12_1083223_EV
{
    static void Main()
    {
        //Ejercicio 1
        int[,] enteros = new int[4, 4];
        int fila;
        int columna;

        lleno(enteros); //Procedimiento

        Console.WriteLine("Ingrese la fila para sumar"); //primera entrada de datos
        fila = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma fila: " + FilaSuma(enteros, fila)); //Primera salida de datos

        Console.WriteLine("Ingrese columna a sumar"); //Segunda entrada de datos
        columna = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma columna: " + ColumnaSuma(enteros, columna)); //Segunda salida de datos


        //Ejercicio 2
        float[,] CargarMatriz = new float[3, 5];

        llenarSegundaMatriz(CargarMatriz); //Procedimiento de entrada de datos

        Console.WriteLine("numero mayor: " + MayorMatriz(CargarMatriz)); //Salida de datos


        //Ejercicio 3
        int[,] MatrizA = new int[3, 2];
        int[,] MatrizB = new int[3, 2];

        llenarMatrices(MatrizA, MatrizB); //Entrada de datos

        int[,] R = Multiplicar(MatrizA, MatrizB); //Procedimiento de multiplicacion

        Console.WriteLine("Multiplicacion resultante: ");

        //Salida de datos
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(R[i, j] + " ");
            }
            Console.WriteLine();
        }


        //Ejercicio 4
        int[,] matriz = new int[5, 5];
        llenar(matriz); //Entrada de datos

        //Procedimiento
        int dp = SumaDiagonalPrincipal(matriz);
        int ds = SumaDiagonalSecundaria(matriz);

        //Salida de datos
        Console.WriteLine("Suma diagonal principal: " + dp);
        Console.WriteLine("Suma diagonal secundaria: " + ds);
    }




    //Funciones y procedimiento
    //Funciones y procedimientos ejercicio 1
    static void lleno(int[,]datos)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Ingrese un dato " + i + ", " + j);
                datos[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int FilaSuma(int[,]datos, int fila)
    {
        int suma = 0;

        for (int i = 0; i < 4; i++)
        {
            suma = suma + datos[fila, i];
        }

        return suma;
    }

    static int ColumnaSuma(int[,]datos, int columna)
    {
        int suma = 0;

        for (int i = 0; i < 4; i++)
        {
            suma = suma + datos[i, columna];
        }

        return suma;
    }



    //Funciones y procedimientos ejercicio 2
    static void llenarSegundaMatriz(float[,] Matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0;j < 5; j++)
            {
                Console.WriteLine("\nIngrese dato en: [" + i + ", " + j + "]");
                Matriz[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float MayorMatriz(float[,] Matriz)
    {
        float mayor = Matriz[0, 0];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Matriz[i, j] > mayor)
                {
                    mayor = Matriz[i, j];
                }
            }
        }

        return mayor;
    }



    //Funciones y procedimientos ejercicio 3
    static void llenarMatrices(int[,] A, int[,] B)
    {
        //Matriz A
        Console.WriteLine("\nMatriz A: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("A [" + i + ", " + j +"]");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Matriz B
        Console.WriteLine("Matriz B: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("A [" + i + ", " + j + "]");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] Multiplicar(int[,] A, int[,] B)
    {
        int[,] R = new int[3, 2];

        for (int i = 0;i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                R[i, j] = A[i, j] * B[i, j];
            }
        }

        return R;
    }


    //Funciones y procedimientos ejercicio 4
    static void llenar(int[,] m)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0;j < 5; j++)
            {
                Console.WriteLine("\nIngrese el dato en: [" + i + ", " + j + "]");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            suma = suma + m[i, i];
        }

        return suma;
    }


    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            suma = suma + m[i, 4 - 1];
        }

        return suma;
    }
}