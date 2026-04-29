using System;
using System.Runtime.CompilerServices;

class Persona
{
    //Ejercicio 1
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

class L13_EV_1083223
{
    static void Main()
    {
        Persona p = new Persona();

        p.nombre = "Enrique";
        p.edad = 21;
        p.altura = 1.86;
        p.estudiante = true;

        Console.WriteLine("Nombre: " + p.nombre);
        Console.WriteLine("Edad: " + p.edad);
        Console.WriteLine("Altura: " + p.altura);
        Console.WriteLine("Estudiante: " + p.estudiante);
    }
}
