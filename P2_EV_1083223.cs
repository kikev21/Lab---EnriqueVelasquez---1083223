using System;
using System.Diagnostics;

class Parcela
{
    //Valores
    public string cultivo;
    public int crecimiento; 
    public int MesesCrecimiento;
    public int mesesPasados;
    public bool sembrar;
    public bool regar;

    //Constructor
    public Parcela()
    {
        this.cultivo = "Vacio";
        this.crecimiento = 0;
        this.sembrar = false;
        this.regar = false;
        this.MesesCrecimiento = 0;
        this.mesesPasados = 0;
    }

    //Muestra de informacion de la parcela
    public void MostrarInformacion()
    {
        Console.WriteLine("Tipo de cultivo: " + cultivo);
        Console.WriteLine("Estado de crecimiento: " + crecimiento + "%");
        Console.WriteLine("Meses: " + mesesPasados + "/" + MesesCrecimiento);
        if (regar)
        {
            Console.WriteLine("Cultivo regado");
        }
        else
        {
            Console.WriteLine("Cultivo no regado");
        }
    }
}


class P2_EV_1083223
{
    static void Main()
    {
        //Variables del main
        double dinero;
        int empleados;
        double sueldo;
        int meses;
        int opcion;
        int filas;
        int columnas;
        int mesesActuales = 0;

        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("---SISTEMA DE LA GRANJA---");

        
        //Validacion y entrada del dinero inicial
        Console.WriteLine("Ingrese el dinero inicial");
        while (!double.TryParse(Console.ReadLine(), out dinero) || dinero <= 0)
        {
            Console.WriteLine("Error, el dinero debe de ser un numero positivo mayor a 0");
        }

        //Validacion y entrada del numero de empleados
        Console.WriteLine("Ingrese el numero de empleados");
        while (!int.TryParse(Console.ReadLine(), out empleados) || empleados <= 0)
        {
            Console.WriteLine("Error, el numero de empleados debe de ser un numero positivo, entero y mayor a 0");
        }

        //Validacion y entrada del sueldo de los empleados
        Console.WriteLine("Ingrese el sueldo por empleado");
        while (!double.TryParse(Console.ReadLine(), out sueldo) || sueldo <= 0)
        {
            Console.WriteLine("Error, el sueldo debe de ser un numero mayor a 0");
        }

        //Entrada de meses maximos de la simulacion
        Console.WriteLine("Ingrese meses a simular");
        while (!int.TryParse(Console.ReadLine(), out meses) || meses <= 0)
        {
            Console.WriteLine("Error, los meses deben de ser un numero entero mayor a 0");
        }

        //Entrada de tamaño de la granja
        Console.WriteLine("Ingrese filas:");
        while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
            Console.WriteLine("Error, el numero debe de ser entero y positivo");

        Console.WriteLine("Ingrese columnas:");
        while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
            Console.WriteLine("Error, el numero debe de ser entero y positivo");

        //Creacion de la matriz
        Parcela[,] Granjita = new Parcela[filas, columnas];

        for(int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Granjita[i, j] = new Parcela();
            }
        }
        Console.ResetColor();

        //Menu principal
        do
        {
            Console.WriteLine("\n---MENU---");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcelas");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Salir y reporte final");
            //Validacion de la opcion de menu
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0)
            {
                Console.WriteLine("Error, porfavor escriba un numero entero positivo");
            }

            switch (opcion)
            {
                //Case para sembrar en la parcela
                case 1:
                    int F;
                    int C;
                    string cultivo = "";
                    int opcionCultivo;

                    //Seleccion de coordenadas de la parcela
                    Console.WriteLine("Ingrese fila");
                    while (!int.TryParse(Console.ReadLine(), out F) || F <= 0 || F >= filas)
                    {
                        Console.WriteLine("Error, la fila debe de ser un numero entero positivo");
                    }

                    Console.WriteLine("Ingrese columna");
                    while (!int.TryParse(Console.ReadLine(), out C) || C <= 0 || C >= columnas)
                    {
                        Console.WriteLine("Error, la columna debe de ser un numero entero positivo");
                    }

                    if (F >= 0 && F <= filas && C >= 0 && C < columnas)
                    {
                        //Si es que la parcela esta vacia
                        if (!Granjita[F, C].sembrar)
                        {
                            Console.WriteLine("\nIngrese un cultivo");
                            Console.WriteLine("1. Maiz");
                            Console.WriteLine("2. Tomate");
                            Console.WriteLine("3. Papa");
                            Console.WriteLine("4. Zanahoria");
                            Console.WriteLine("5. Fresa");
                            while (!int.TryParse(Console.ReadLine(), out opcionCultivo) || opcionCultivo < 0)
                            {
                                Console.WriteLine("Error, la opcion del cultivo debe de ser un numero entrero positivo");
                            }

                            //Asignacion de cultivo y su tiempo de crecimiento
                            switch (opcionCultivo)
                            {
                                case 1:
                                    cultivo = "Maiz";
                                    Granjita[F, C].MesesCrecimiento = 3;
                                    break;

                                case 2:
                                    cultivo = "Tomate";
                                    Granjita[F, C].MesesCrecimiento = 2;
                                    break;

                                case 3:
                                    cultivo = "Papa";
                                    Granjita[F, C].MesesCrecimiento = 1;
                                    break;

                                case 4:
                                    cultivo = "Zanahoria";
                                    Granjita[F, C].MesesCrecimiento = 5;
                                    break;

                                case 5:
                                    cultivo = "Fresa";
                                    Granjita[F, C].MesesCrecimiento = 4;
                                    break;

                                default:
                                    Console.WriteLine("Cultivo invalido");
                                    break;
                            }

                            //Guardar informacion del cultivo de la parcela
                            Granjita[F, C].cultivo = cultivo;
                            Granjita[F, C].sembrar = true;
                            Granjita[F, C].crecimiento = 0;
                            Granjita[F, C].mesesPasados = 0;
                            Console.WriteLine("Cultivo sembrado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Parcela ocupada");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posicion invalida");
                    }
                    break;


                //Case para regar en la parcela y subir el crecimiento
                case 2:
                    Console.WriteLine("Ingrese fila");
                    while (!int.TryParse(Console.ReadLine(), out F) || F <= 0 || F >= filas)
                    {
                        Console.WriteLine("Error, la fila debe de ser un numero entero positivo");
                    }

                    Console.WriteLine("Ingrese columna");
                    while (!int.TryParse(Console.ReadLine(), out C) || C <= 0 || C >= columnas)
                    {
                        Console.WriteLine("Error, la columna debe de ser un numero entero positivo, menor a 2");
                    }

                    if (F >= 0 && F < filas && C >= 0 && C < columnas)
                    {
                        //Verifica si hay un cultivo
                        if (Granjita[F, C].sembrar)
                        {
                            //Evita regar el cultivo mas veces
                            if (Granjita[F, C].regar)
                            {
                                Console.WriteLine("Esta parcela ya esta regada");
                            }
                            else
                            {
                                Granjita[F, C].regar = true;

                                //Creciemineto segun cada cultivo
                                switch (Granjita[F, C].cultivo)
                                {
                                    case "Maiz":
                                        Granjita[F, C].crecimiento = Granjita[F, C].crecimiento + 25;
                                        break;

                                    case "Tomate":
                                        Granjita[F, C].crecimiento = Granjita[F, C].crecimiento + 20;
                                        break;

                                    case "Papa":
                                        Granjita[F, C].crecimiento = Granjita[F, C].crecimiento + 15;
                                        break;

                                    case "Zanahoria":
                                        Granjita[F, C].crecimiento = Granjita[F, C].crecimiento + 30;
                                        break;

                                    case "Fresa":
                                        Granjita[F, C].crecimiento = Granjita[F, C].crecimiento + 10;
                                        break;

                                    default:
                                        Console.WriteLine("Cultivo no reconocido");
                                        break;

                                }

                                Console.WriteLine("Cultivo regado correctamente");
                            }

                            //Limita el crecimiento maximo
                            if (Granjita[F, C].crecimiento > 100)
                            {
                                Granjita[F, C].crecimiento = 100;
                            }

                            //Costo del riego
                            dinero = dinero - 40;
                        }
                        else
                        {
                            Console.WriteLine("La parcela esta vacia");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posicion invalida");
                    }
                    break;


                //Case para mostrar la informacion de la parcela
                case 3:
                    Console.WriteLine("Ingrese fila de la parcela:");
                    while (!int.TryParse(Console.ReadLine(), out F) || F < 0 || F >= filas)
                    {
                        Console.WriteLine("Error, fila debe ser un numero positivo entero");
                    }

                    Console.WriteLine("Ingrese columna de la parcela:");
                    while (!int.TryParse(Console.ReadLine(), out C) || C < 0 || C >= columnas)
                    {
                        Console.WriteLine("Error, columna debe ser un numero positivo entero");
                    }

                    //Muestra el estado completo de la parcela seleccionada
                    Console.WriteLine("\nParcela: [" + F + ", " + C + "]");
                    Granjita[F, C].MostrarInformacion();
                    break;


                //Case para poder avanzar meses, crecimiento natural y obtener el ingreso
                case 4:

                    //Avanza el tiempo
                    Console.WriteLine("Avanzando mes...");
                    mesesActuales++;
                    Console.WriteLine("Mes actual: " + mesesActuales + "/" + meses);

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Granjita[i, j].sembrar)
                            {
                                Granjita[i, j].mesesPasados++;

                                //Crecimiento si los meses minimos se cumplen
                                if (Granjita[i, j].mesesPasados >= Granjita[i, j].MesesCrecimiento)
                                {
                                    switch (Granjita[i, j].cultivo)
                                    {
                                        case "Maiz":
                                            Granjita[i, j].crecimiento = Granjita[i, j].crecimiento + 5;
                                            break;

                                        case "Tomate":
                                            Granjita[i, j].crecimiento = Granjita[i, j].crecimiento + 3;
                                            break;

                                        case "Papa":
                                            Granjita[i, j].crecimiento = Granjita[i, j].crecimiento + 6;
                                            break;

                                        case "Zanahoria":
                                            Granjita[i, j].crecimiento = Granjita[i, j].crecimiento + 7;
                                            break;

                                        case "Fresa":
                                            Granjita[i, j].crecimiento = Granjita[i, j].crecimiento + 4;
                                            break;
                                    }

                                    //Cosecha e ingreso de cada cultivo
                                    if (Granjita[i, j].crecimiento >= 100)
                                    {
                                        Console.WriteLine("Cosecha lista en la parcela: [" + i + ", " + j + "]");

                                        int ingreso = 0;

                                        switch (Granjita[i, j].cultivo)
                                        {
                                            case "Maiz":
                                                ingreso = 150;
                                                break;

                                            case "Tomate":
                                                ingreso = 120;
                                                break;

                                            case "Papa":
                                                ingreso = 70;
                                                break;

                                            case "Zanahoria":
                                                ingreso = 200;
                                                break;

                                            case "Fresa":
                                                ingreso = 65;
                                                break;
                                        }

                                        //Suma de ingresos a el dinero total
                                        dinero = dinero + ingreso;
                                    }
                                }
                            }
                        }
                    }

                    dinero = dinero - (empleados * sueldo);

                    Console.WriteLine("Mes avanzado");
                    Console.WriteLine("Pago de salarios realizado");
                    Console.WriteLine("Dinero disponible: Q" + dinero);

                    //Decisiones para terminar el programa si se termina el dinero o se llega al maximo de meses
                    if (mesesActuales >= meses)
                    {
                        Console.WriteLine("\nSe alcanzaron los meses maximos de simulacion");
                        opcion = 5;
                    }

                    if (dinero <= 0)
                    {
                        Console.WriteLine("\nTe has quedado sin dinero");
                        opcion = 5;
                    }
                    break;


                //Reporte final y fin del programa
                case 5:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n---REPORTE FINAL---");
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            Console.WriteLine("\nParcela [" + i + ", " + j + "]");

                            Granjita[i, j].MostrarInformacion();
                        }
                    }

                    Console.WriteLine("\nDinero final: Q" + dinero);
                    break;


                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            
        } while (opcion != 5);
    }
}