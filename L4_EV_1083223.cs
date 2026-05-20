using System;
using System.Net.NetworkInformation;

//Enrique Velasquez 1083223
namespace Lab4_1083223_Enrique_Velasquez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 Registro de nave espacial
            String Modelo = "Vostok";
            float NivelCombustible = 3710;
            bool MotorSalto = true;
            int CapacidadCarga = 2460;

            Console.WriteLine("Capacidad de carga: " + CapacidadCarga + "  Modelo de la nave: " + Modelo + "  ¿Motor de salto preparado?: " + MotorSalto + "  Nivel de combustible: " + NivelCombustible);
            Console.WriteLine('\n');


            //Ejercicio 2 Expansion de memoria
            short SensoresActivos = 128;
            int RegistroProcesador = SensoresActivos;
            double PreisicionTotal = RegistroProcesador;

            Console.WriteLine("Presicion total: " + PreisicionTotal);
            Console.WriteLine('\n');


            //Ejercicio 3 Ajuste de enerigia
            double EnergiaGenerada = 987.65;
            int EnergiaLimitada;
            EnergiaLimitada = (int)EnergiaGenerada;

            Console.WriteLine("Enrgia generada: " + EnergiaGenerada);
            Console.WriteLine("Energia Limitada: " + EnergiaLimitada);
            Console.WriteLine('\n');


            //Ejercicio 4 Recepcion de coordenadas
            Console.WriteLine("Ingrese la distancia al planeta mas cercano");
            string EntradaRadar = Console.ReadLine();
            int Distancia = int.Parse(EntradaRadar);
            int ResultadoFinal = Distancia + 100;

            Console.WriteLine("Distancia al planeta mas cercano, junto a un margen de seguridad: " + ResultadoFinal);
            Console.WriteLine('\n');


            //Ejercicio 5 Panel de control
            string SeñalOxigeno = "true";
            bool Señal = Convert.ToBoolean(SeñalOxigeno);
            string TemperaturaCabina = "22.8";
            double Temperatura = Convert.ToDouble(TemperaturaCabina);

            Console.WriteLine("Señal del oxigeno: " + Señal);
            Console.WriteLine("Temperatura de la cabina: " + Temperatura);
            Console.WriteLine('\n');


            //Ejercicio 6 Reporte de mision
            double VelocidadLuz = 299792.458;
            string Velocidad = Convert.ToString(VelocidadLuz);
            string VelocidadTotal = VelocidadLuz.ToString("N3");
            Console.WriteLine("Velocidad para la base terrestre: " + VelocidadTotal);
            Console.WriteLine('\n');


            //Ejercicio 7 Calculadora de suministros
            Console.WriteLine("Escriba el precio por galon de litio: ");
            string PrecioGalon = Console.ReadLine();
            double PrecioG = Convert.ToDouble(PrecioGalon);
            double ImpuestoGalactico = PrecioG * 0.12;
            double CostoTotal = PrecioG + ImpuestoGalactico;
            int CostoFinal = Convert.ToInt32(CostoTotal);
            Console.WriteLine("El Costo final de suministro es: " + CostoFinal);
            Console.WriteLine('\n');


            //Ejercicio 8 
            Console.WriteLine("_________________________.s$$_____________s$");
            Console.WriteLine("________________________s$$$’____________s$$");
            Console.WriteLine("______________________.s$$$³´_______,___s$$³");
            Console.WriteLine("_____________________s$$$$³______.s$’___$$³");
            Console.WriteLine("________________,____$$$$$.______s$³____³$");
            Console.WriteLine("________________$___$$$$$$s_____s$³_____³,");
            Console.WriteLine("_______________s$___‘³$$$$$$s___$$$");
            Console.WriteLine("_______________$$____³$$$$$$s.__³$$s");
            Console.WriteLine("_______________³$.____³$$$$$$$s_.s$$$____s´");
            Console.WriteLine("_______________`$$.____³$$$$$$$_$$$$___s³");
            Console.WriteLine("________________³$$s____³$$$$$$s$$$³__s$’");
            Console.WriteLine("_________________³$$s____$$$$$s$$$$’__s$$");
            Console.WriteLine("_____________`s.__$$$$___s$$$$$$$$³_.s$$³__s");
            Console.WriteLine("______________$$_s$$$$..s$$$$$$$$$$$$$$³__s$");
            Console.WriteLine("______________s$.s$$$$s$$$$$$$$$$$$$$$$_s$$");
            Console.WriteLine("_____________s$$$$$$$$$$$$$$$$$$$$$$$$$$$³");
            Console.WriteLine("____________s$$$ssss$$$$$$$$$$$$$ssss$$$$$´");
            Console.WriteLine("___________$$s§§§§§§§§§s$$$$$$s§§§§§§§§s$,"); 
            Console.WriteLine("___________§§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
            Console.WriteLine("___________³§§§§§§§§§§§§§§§§§§§§§§§§§§§§§");
            Console.WriteLine("____________³§§§§§§§§§§§§§§§§§§§§§§§§§§§³");
            Console.WriteLine("_____________³§§§§§§§§§§§§§§§§§§§§§§§§§³");
            Console.WriteLine("______________³§§§§§§§§§§§§§§§§§§§§§§§³");
            Console.WriteLine("________________³§§§§§§§§§§§§§§§§§§§³");
            Console.WriteLine("__________________³§§§§§§§§§§§§§§§³");
            Console.WriteLine("_______________________³§§§§§³");
            Console.WriteLine("_________________________³§³");

            Console.WriteLine("\n Que haras el 14 de febrero? ");
            string respuestaFeb = Console.ReadLine();
            Console.WriteLine("\n Tu mision para el 14 de febrero es: " + respuestaFeb);



        }
        
    }
}
