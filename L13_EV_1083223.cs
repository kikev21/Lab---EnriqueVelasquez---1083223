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

class Vehiculo
{
    //Ejercicio 2
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

class Producto
{
    //Ejercicio 3
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

class Mascota
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}

class L13_EV_1083223
{
    static void Main()
    {
        //Ejercicio 1 - clase Persona
        Persona p = new Persona();

        p.nombre = "Enrique";
        p.edad = 21;
        p.altura = 1.86;
        p.estudiante = true;

        Console.WriteLine("---Clase Persona---");
        Console.WriteLine("Nombre: " + p.nombre);
        Console.WriteLine("Edad: " + p.edad);
        Console.WriteLine("Altura: " + p.altura);
        Console.WriteLine("Estudiante: " + p.estudiante);



        //Ejercicio 2 - clase Vehiculo
        Vehiculo v = new Vehiculo();

        v.marca = "Toyota";
        v.modelo = "Corolla";
        v.anio = 2018;
        v.color = "Negro";
        v.placa = "P123ABC";

        Console.WriteLine("\n---Clase Vehiculo---");
        Console.WriteLine("Marca: " + v.marca);
        Console.WriteLine("Modelo: " + v.modelo);
        Console.WriteLine("Año: " + v.anio);
        Console.WriteLine("Color: " + v.color);
        Console.WriteLine("Placa: " + v.placa);



        //Ejercicio 3 - clase Producto
        Producto pro = new Producto();

        pro.codigo = "P001";
        pro.nombre = "Teclado";
        pro.precio = 75.50;
        pro.stock = 23;
        pro.disponible = true;

        Console.WriteLine("\n---Clase Producto---");
        Console.WriteLine("Codigo: " + pro.codigo);
        Console.WriteLine("Nombre: " + pro.nombre);
        Console.WriteLine("Precio: " + pro.precio);
        Console.WriteLine("Stock: " + pro.stock);
        Console.WriteLine("Disponible: " + pro.disponible);



        //Ejercicio 4 - clase Mascota
        Mascota m = new Mascota();

        m.nombre = "Luna";
        m.especie = "gato";
        m.edad = 8;
        m.peso = 12.2;
        m.vacunado = true;

        Console.WriteLine("\n---Clase Mascota---");
        Console.WriteLine("Nombre: " + m.nombre);
        Console.WriteLine("Especie: " + m.especie);
        Console.WriteLine("Edad: " + m.edad);
        Console.WriteLine("Peso: " + m.peso);
        Console.WriteLine("Vacunado: " + m.vacunado);
    }
}
