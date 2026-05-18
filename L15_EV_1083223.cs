using System;
using System.ComponentModel.DataAnnotations; //Punto y coma al final

class L15_EV_1083223
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ejercicio 1");
        string nombre; //Punto y coma al final de la variable nombre
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine()); //Punto y coma al final del if

        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        } //Cerrar el if
        else
        {
            Console.WriteLine("Eres menor de edad");
        }



        //Ejercicio 2
        double nota1, nota2, nota3, promedio;

        Console.WriteLine("\nEjercicio 2");
        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());

        promedio = (nota1 + nota2 + nota3) / 3; //Parentesis para que se haga primero la suma

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 61) //Cambio de simbolo de mayor a mayor o igual
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }



        //Ejercicio 3
        Console.WriteLine("\nEjercicio 3");
        int[] numeros = new int[5]; //Un arreglo no llega a la posicion 5 debido a que inicia de desde el numero 0, donde este es la posicion 1
        int suma = 0;
        bool valido = false;


        while (!valido) //Ciclo while para que no salga del for si escribe un valor erroneo
        {
            for (int i = 0; i < 5; i++) //Quitar el igual para que solo llegue hasta el limite del arreglo
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out numeros[i])) //Cambio en el console.readline para confirmar si es numero o no
                {
                    valido = true; //valor si es valido lo escrito
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Intente de nuevo");
                }
            }

        }

        for (int i = 0; i < 5; i++) //Quitar el igual tambien
        {
            suma = suma + numeros[i];
        }

        Console.WriteLine("La suma total es: " + suma);



        //Ejercicio 4
        Console.WriteLine("\nEjercicio 4");
        double baseRectangulo, alturaRectangulo;

        Console.WriteLine("Ingrese la base del rectángulo:");

        while (!double.TryParse(Console.ReadLine(), out baseRectangulo) || baseRectangulo <= 0) //Validacion para que la base sea un numero positivo y solamente un numero
        {
            Console.WriteLine("Error, ingrese un numero mayor a cero");
        }

        Console.WriteLine("\nbase aceptada");
        Console.WriteLine("Ingrese la altura del rectángulo:");

        while (!double.TryParse(Console.ReadLine(), out alturaRectangulo) || alturaRectangulo <= 0) //Validacion para que la altura sea un numero positivo y solamente un numero
        {
            Console.WriteLine("Error, ingrese un numero mayor a cero");
        }
        Console.WriteLine("Altura aceptada");
        double area = CalcularArea(baseRectangulo, alturaRectangulo);

        Console.WriteLine("\nEl área es: " + area);

        if (area >= 100) //mayor a mayor o igual a 100
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }



        //Ejercicio 5
        Console.WriteLine("\nEjercicio 5");
        int[] edades = new int[5];
        int sum = 0; //cambiar nombre de una variable ya usada
        int mayores = 0;
        double prome; 

        for (int i = 0; i < 5; i++) //Quitar el igual y cambiar a i = 0 para que solo reccorra desde la posicion 0 a la 4
        {
            Console.WriteLine("Ingrese la edad de la persona " + i + ":");

            while (!int.TryParse(Console.ReadLine(), out edades[i]) || edades[i] < 0) //Validacion para que la edad sea un numero positivo entero
            {
                Console.WriteLine("Error, la edad debe de ser un numero positivo entero");
            }

            sum = sum + edades[i];

            if (edades[i] >= 18) //Mayor o igual para que cuente el 18 como mayor de edad
            {
                mayores++;
            }
        }

        prome = (double)sum / 5; //Poner double para que haga la division con decimales

        Console.WriteLine("El promedio de edades es: " + prome); 
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);

        // Análisis de la solución generada por IA: La IA tiene una buena base en cuanto la idea del codigo, sin embargo hay aveces que haga decisiones no coherentes debido a su falta de informacion
        // Error 1: Poner i = 0 y i < 5, cuando queremos las posiciones del arreglo edades
        // Error 2: Poner edades[i] < 18, cuando 18 ya es considerado mayor de edad
        // Error 3: El no poner que suma sea double cuando es necesario para una division exacta
        // Limitación encontrada: La IA no sabe el contexto especifico en el que el usuario necesita el codigo, o la falta de entrenamiento en el ambito
        // Importancia de la validación humana: La validacion humana es importante debido a que la IA puede cometer errores basicos por la falta de informacion o contexto del tema

    }



    //Procedimiento ejercicio 4
    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        double resultado = baseRectangulo * alturaRectangulo; //cambiar suma por multiplicacion
        return resultado;
    }
}



// ¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y validada por una persona antes de considerarse correcta?

// La inteligencia artificial es una herramienta la cual nos ayuda el dia a dia, la cual necesita contexto o informacion previa acerca de los temas relacionados
//para que esta misma de una solucion coherente y buena. Pero si no se da correctamente el contexto o no tiene sufienciente informacion o practica previa para
//este tipo de situaciones, la IA pueda dar fallos tanto basicos y simples como problemas mucho mayores, por eso mismo se necesita ser revisada por una persona
//ya que con los conocimientos previos, el individuo podra tener una idea como resolver los errores en el codigo de los programas hechos por la IA. Haciendo que
//el codigo pueda funcionar correctamente si se le da una revision correcta o si el programa tiene un defecto el mismo individuo podra arreglar o rehacer el
//programa para que haga lo que se pide.


