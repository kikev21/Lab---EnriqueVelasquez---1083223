using System;
using System.Runtime.CompilerServices;

class L9_EV_1083223
{
    //lab 9 Enrique Velasquez
    static void Main()
    {
        //Ejercicio 1
        //Entrada de datos
        string CYL = "";
        Console.WriteLine("Escriba su nombre");
        string nombre = Console.ReadLine();
        //Salida de datos
        saludo(nombre);
        CursoYLab(CYL);


        //Ejercicio 2
        Console.WriteLine("\n¿Que figura desea calcular el area?");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Rectangulo");
        Console.WriteLine("3. Triangulo");
        //Entrada de datos
        int Figura = int.Parse(Console.ReadLine());

        //Salida de datos y de metodos
        switch (Figura)
        {
            case 1:
                areaCuadrado();
                break;

            case 2:
                areaRectangulo();
                break;

            case 3:
                areaTriangulo();
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }


        //Ejercicio 3
        int opcion;
        do
        { 
            //Menu
            Console.WriteLine("\nElija una de las opciones");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Linea");
            Console.WriteLine("4. Salir");
            opcion = int.Parse(Console.ReadLine());

            //Procedimiento y leida de opciones
            switch (opcion)
            {
                case 1:
                    cuadro();
                    break;

                case 2:
                    triangulo();
                    break;

                case 3:
                    linea();
                    break;

                case 4: //Salir del programa
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (opcion != 4);


        //Ejercicio 4
        int nota;
        double suma = 0;
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 1; i <= 5; i++)
        {
            //Entrada de datos
            Console.WriteLine("\nEscriba la nota de un estudiante");
            nota = int.Parse(Console.ReadLine());
            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota no permitida, vuelva a intentarlo");
                i--;
            }
            //Procedimiento de notas aprobadas y reprobadas
            suma += nota;
            evaluarNota(nota, ref aprobados, ref reprobados);

        }
        //Salida de datos y resumen
        double promedio = suma / 5;
        resumen(promedio, aprobados, reprobados);



        //Ejercicio 5
        int num1;
        int num2;

        //Entrada de datos
        Console.WriteLine("\nEscriba el primero numero");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEscriba el segundo numero");
        num2 = int.Parse(Console.ReadLine());
        
        //Salida de datos antes del intercambio
        Console.WriteLine("Antes del intercambio" + num1 + ", " + num2);

        //Procedimiento para el intercambio de numeros
        intercambio(ref num1, ref num2);

        //Salida despues de intercambio
        Console.WriteLine("Despues del intercambio" + num1 + ", " + num2);




        //METODOS
        //Metodo para ejercicio 1 nombre
        static void saludo(string nombre)
        {
            Console.Write("Un gusto " + nombre);
        }
        //Metodo para ejercicio 1 Curso y numero de laboratorio
        static void CursoYLab(string CYL)
        {
            Console.WriteLine("\nCurso: Pensamiento Computacional");
            Console.WriteLine("Numero de laboratorio: 9");
        }


        //Ejercicio 2, Metodo de area de cuadrado
        static void areaCuadrado()
        {
            Console.WriteLine("Escriba la medida del lado de la figura");
            int L = int.Parse(Console.ReadLine());
            int Cuadrado = L * L;
            Console.WriteLine("El area de la figura es: " + Cuadrado);
        }
        //Ejercicio 2, Metodo de area de rectangulo
        static void areaRectangulo()
        {
            Console.WriteLine("Escriba la base de la figura");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura de la figura");
            int H = int.Parse(Console.ReadLine());

            int Rectangulo = B * H;
            Console.WriteLine("El area de la figura es: " + Rectangulo);
        }
        //Ejercicio 2, Metodo de area de triangulo
        static void areaTriangulo()
        {
            Console.WriteLine("Escriba la base de la figura");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura de la figura");
            int H = int.Parse(Console.ReadLine());

            int Triangulo = (B * H);
            int RTriangulo = Triangulo / 2;
            Console.WriteLine("El area de la figura es: " + RTriangulo);
        }


        //Ejercicio 3 funcion cuadrado
        static void cuadro()
        {
            //Ejercicio 3 funcion linea
            Console.WriteLine("Ingrese el tamaño de la figura: ");
            int N = int.Parse(Console.ReadLine());

            //Proceso
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //Salida
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Ejercicio 3 funcion triangulo
        static void triangulo()
        {
            //Ejercicio 3 funcion linea
            Console.WriteLine("Ingrese el tamaño de la figura: ");
            int N = int.Parse(Console.ReadLine());

            //Proceso
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //Salida
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Ejercicio 3 funcion linea
        static void linea()
        {
            //Entrada del tamaño de la figura
            Console.WriteLine("Ingrese el tamaño de la figura: ");
            int N = int.Parse(Console.ReadLine());

            //Proceso
            for (int i = 0; i < N; i++)
            {
                //Salida
                Console.Write("*");
            }
        }
        


        //Ejercicio 4 Evaluacion de nota aprovado
        static void evaluarNota(int nota, ref int aprobados, ref int reprobados)
        {
            if (nota >= 61)
            {
                Console.WriteLine("Aprobado");
                aprobados++;
            }
            else
            {
                Console.WriteLine("Reprobado");
                reprobados++;
            }
        }

        //Ejercicio 4 Resumen de las notas (promedio, cantidad de aprobados y cantidad de reprobados)
        static void resumen(double promedio, int aprobados, int reprobados)
        {
            Console.WriteLine("\nResumen: ");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Canridad de reprobados: " + reprobados);
        }


        //Ejercicio 5 Intercambio de ambos numeros
        static void intercambio(ref int num1, ref int num2)
        {
            int auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;
        }
    }
}