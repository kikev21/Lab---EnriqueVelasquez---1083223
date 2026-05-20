using System;
//Enrique Velasquez

// Espacio de nombres:
// Se utiliza para organizar el código del programa.
namespace Laboratorio3
{
    // Clase principal del programa
    class Program
    {
        // Método principal:
        // Punto de inicio de la ejecución del programa.
        static void Main(string[] args)
        {
            //leer la variable nombre
            Console.WriteLine("Escriba por favor su nombre:");
            string nombre = Console.ReadLine();

            //Leer la varia de curso o clase
            Console.WriteLine("Escriba el nombre del curso:");
            string clase = Console.ReadLine();

            //Mostrar datos
            Console.WriteLine(clase);
            Console.WriteLine($"Hola {nombre}, ojalá lo estés pasando genial y que tengas un buen día.");
            Console.WriteLine("Presione una tecla para salir del programa...");
            Console.ReadKey();

        }
    }
}


