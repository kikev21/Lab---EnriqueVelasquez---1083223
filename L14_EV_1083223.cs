using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;

class Libro
{
    //Atributos
    public string titulo;
    public string autor;
    public int anioPublicacion;
    public bool disponible;

    public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
    {
        //Constructor
        this.titulo = titulo;
        this.autor = autor;
        this.anioPublicacion = anioPublicacion;
        this.disponible = disponible;
    }

    //Metodo para mostrar informacion
    public void MostrarInfo()
    {
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicacion: " + anioPublicacion);
        Console.WriteLine("Disponibilidad: " + disponible);
    }

    //Metodo prestar libro
    public void PrestarLibro()
    {
        if (disponible == true)
        {
            disponible = false;
        }
        else
        {
            Console.WriteLine("El libro no esta disponible");
        }
    }

    //Metodo devolver libro
    public void DevolverLibro()
    {
        disponible = true;
        Console.WriteLine("libro devuelto");
    }
}

class Program1
{
    static void Main()
    {
        //Crear libros
        Libro libro1 = new Libro("Stoner", "John Williams", 1965, true);

        Libro libro2 = new Libro("El palacio de los sueños", "Ismail Kadare", 1981, true);

        //Mostrar informacion de libros
        Console.WriteLine("===== LIBROS DISPONIBLES =====\n");

        Console.WriteLine("Libro 1");
        libro1.MostrarInfo();

        Console.WriteLine();

        Console.WriteLine("Libro 2");
        libro2.MostrarInfo();

        Console.WriteLine();

        //Elegir libro
        Console.WriteLine("Seleccione un libro:");
        Console.WriteLine("1. " + libro1.titulo);
        Console.WriteLine("2. " + libro2.titulo);

        int opcion = int.Parse(Console.ReadLine());

        //Elegir accion
        Console.WriteLine("\nQue desea hacer?");
        Console.WriteLine("1. Prestar libro");
        Console.WriteLine("2. Devolver libro");

        int accion = int.Parse(Console.ReadLine());

        //Libro 1
        if (opcion == 1)
        {
            if (accion == 1)
            {
                libro1.PrestarLibro();
            }
            else if (accion == 2)
            {
                libro1.DevolverLibro();
            }

            Console.WriteLine("\nEstado actual:");
            libro1.MostrarInfo();
        }

        //Libro 2
        else if (opcion == 2)
        {
            if (accion == 1)
            {
                libro2.PrestarLibro();
            }
            else if (accion == 2)
            {
                libro2.DevolverLibro();
            }

            Console.WriteLine("\nEstado actual:");
            libro2.MostrarInfo();
        }

        else
        {
            Console.WriteLine("Opcion invalida.");
        }
    }
}




class Mascota
{
    //Atributos
    public string nombre;
    public string especie;
    public int edad;
    public bool vacunado;

    //Constructor
    public Mascota(string nombre, string especie, int edad, bool vacunado)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.edad = edad;
        this.vacunado = vacunado;
    }

    //Metodo mostrar informacion
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Especie: " + especie);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Vacunado: " + vacunado);
    }

    //Metodo vacunar
    public void Vacunar()
    {
        vacunado = true;
        Console.WriteLine(nombre + " ha sido vacunado.");
    }

    //Metodo cumplir años
    public void CumplirAnios()
    {
        edad++;
        Console.WriteLine(nombre + " ahora tiene " + edad + " años.");
    }
}

class Program2
{
    static void Main()
    {
        //Crear mascotas
        Mascota mascota1 = new Mascota("Max", "Perro", 3, false);

        Mascota mascota2 = new Mascota("Luna", "Gato", 2, true);

        //Mostrar informacion inicial
        Console.WriteLine("\n\n===== MASCOTA 1 =====");
        mascota1.MostrarInformacion();

        Console.WriteLine();

        Console.WriteLine("===== MASCOTA 2 =====");
        mascota2.MostrarInformacion();

        Console.WriteLine();

        //Elegir mascota
        Console.WriteLine("Seleccione una mascota:");
        Console.WriteLine("1. " + mascota1.nombre);
        Console.WriteLine("2. " + mascota2.nombre);

        int opcion = int.Parse(Console.ReadLine());

        //Elegir accion
        Console.WriteLine("\nQue desea hacer?");
        Console.WriteLine("1. Vacunar");
        Console.WriteLine("2. Cumplir años");

        int accion = int.Parse(Console.ReadLine());

        //Mascota 1
        if (opcion == 1)
        {
            if (accion == 1)
            {
                mascota1.Vacunar();
            }
            else if (accion == 2)
            {
                mascota1.CumplirAnios();
            }

            Console.WriteLine("\nEstado actual:");
            mascota1.MostrarInformacion();
        }

        //Mascota 2
        else if (opcion == 2)
        {
            if (accion == 1)
            {
                mascota2.Vacunar();
            }
            else if (accion == 2)
            {
                mascota2.CumplirAnios();
            }

            Console.WriteLine("\nEstado actual:");
            mascota2.MostrarInformacion();
        }

        else
        {
            Console.WriteLine("Opcion invalida.");
        }
    }
}


class Estudiante
{
    //Atributos
    public string nombre;
    public int edad;
    public string grado;
    public double[] notas;

    public Estudiante(string nombre, int edad, string grado, double[] notas)
    {
        //Constructor
        this.nombre = nombre;
        this.edad = edad;
        this.grado = grado;
        this.notas = notas;
    }

    //Metodo calcular promedio
    public double calcularPromedio()
    {
        double suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma = suma + notas[i];
        }

        double promedio = suma / notas.Length;
        return promedio;
    }

    //Metodo mostrar informacion
    public void MInformacion()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Grado: " + grado);
        Console.WriteLine("Notas: " );
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }
        Console.WriteLine("Promedio: " + calcularPromedio());
    }

    //Metodo de aprobado o reprobado
    public void aprobar()
    {
        double promedio = calcularPromedio();

        if (promedio >= 61)
        {
            Console.WriteLine("Estudiante aprobado");
        }
        else
        {
            Console.WriteLine("Estudiante reprobado");
        }
    }

    //Metodo agrear nota
    public void AgregarNota(int Nnota)
    {
        double[] nuevasnotas = new double[notas.Length + 1];

        for (int i = 0;i < notas.Length; i++)
        {
            nuevasnotas[i] = notas[i];
        }

        nuevasnotas[nuevasnotas.Length - 1] = Nnota;
    }
}

class program3
{
    static void Main()
    {
        //Objetos estudiante con sus arreglos nota
        double[] notas1 = { 88, 54, 78 };
        Estudiante estudiante1 = new Estudiante("Ana Lopez", 15, "9° grado", notas1);

        double[] notas2 = { 77, 25, 63 };
        Estudiante estudiante2 = new Estudiante("Carlos Mendez", 16, "10° grado", notas2);

        double[] notas3 = { 99, 16, 45 };
        Estudiante estudiante3 = new Estudiante("Sofia Ramirez", 14, "8° grado", notas3);

        //Mostrar informacion
        Console.WriteLine("===== ESTUDIANTE 1 =====");
        estudiante1.MInformacion();
        estudiante1.aprobar();

        Console.WriteLine("===== ESTUDIANTE 2 =====");
        estudiante2.MInformacion();
        estudiante2.aprobar();

        Console.WriteLine("===== ESTUDIANTE 3 =====");
        estudiante3.MInformacion();
        estudiante3.aprobar();

        //Agregar nueva nota
        Console.WriteLine("\nAgregando nueva nota a Ana Lopez...");

        estudiante1.AgregarNota(100);

        //Mostrar informacion actualizada
        Console.WriteLine("\n===== INFORMACION ACTUALIZADA =====");

        estudiante1.MInformacion();
        estudiante1.aprobar();
    }
}