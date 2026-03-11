using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L8_EV_1083223
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //identificacion de variables
            int notasaprovados = 0;
            int notasreprovados = 0;
            int nota;
            int notas = 1;
            int aprovado = 0;
            int reprobado = 0;
            while (notas <= 10)
            {
                //Entrada de datos
                Console.WriteLine("Escriba la nota de un estudiante");
                nota = int.Parse(Console.ReadLine());
                notas++;
                //Proceso
                switch (nota)
                {
                    case > 61:
                        Console.WriteLine("Estudiante aprovado");
                        aprovado++;
                        notasaprovados = notasaprovados + nota;
                        break;

                    case < 61:
                        Console.WriteLine("Estudiante reprobado"); 
                        reprobado++; 
                        notasreprovados = notasreprovados + nota;
                        break;

                }
            }
            int promedio = (notasaprovados + notasreprovados) / 10;
            
            //Salida de datos
            Console.WriteLine("\n Promedio de la clase: " + promedio);
            Console.WriteLine("Cantidad de aprovados: " + aprovado);
            Console.WriteLine("Cantidad de reprovados: " + reprobado);
        }
    }
}
