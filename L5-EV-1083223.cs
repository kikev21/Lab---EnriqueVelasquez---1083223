using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L5_EV_1083223
{
    internal class Program
    {
        //Enrique Velasquez 1083223
        static void Main(string[] args)
        {
            //Ejercicio 1 Panel de acceso numerico
            //ejercicio a
            Console.WriteLine("Escriba su ID: ");
            string ID = Console.ReadLine();
            int Identficacion = Convert.ToInt32(ID);

            if (Identficacion == 2026)
            {
                Console.WriteLine("Usuario reconocido");

            }
            else
            {
                Console.WriteLine("Usuario no reconocido");
            }

            //Ejercicio b
            Console.WriteLine("\n Escriba su PIN: ");
            string contraseña = Console.ReadLine();
            int PIN = Convert.ToInt32(contraseña);

            if (PIN == 1234)
            {
                Console.WriteLine("PIN correcto");

            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            //ejercicio c
            Console.WriteLine("\n Escriba su Token");
            string Indicador = Console.ReadLine();
            int Token = Convert.ToInt32(Indicador);

            if (Token == 777)
            {
                Console.WriteLine("Token valido");

            }
            else
            {
                Console.WriteLine("Token invalido");
            }

            //ejercicio d
            Console.WriteLine("\n ¿Activar modo seguro? si = 1");
            string modo = Console.ReadLine();
            int Modoseguro = Convert.ToInt32(modo);

            if (Modoseguro == 1 && Token >= 700)
            {
                Console.WriteLine("Modo seguro activado, se aplicaran reglas extra");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado");
            }

            if (Identficacion == 2026 && PIN == 1234 && Token == 777)
            {
                Console.WriteLine("\n Acceso total concedido");
            }
            else
            {
                Console.WriteLine("\n Acceso denegado");
            }


            if (Modoseguro == 1 && Token >= 700)
            {
                Console.WriteLine("Regla extra aprobada");
            }
            else
            {
                Console.WriteLine("Regla extra fallida");
            }


            //Ejercicio numero 2 Validador de PIN inteligente
            Console.WriteLine("\n Escriba un PIN de 4 digitos: ");
            string Contra = Console.ReadLine();
            int PIN2 = Convert.ToInt32(Contra);

            //ejercicio a
            if (PIN2 >= 1000 && PIN2 <= 9999)
            {
                Console.WriteLine("\n PIN de 4 digitos: OK");
            }
            else
            {
                Console.WriteLine("PIN invalido: debe tener 4 digitos");
            }

            //ejercicio b
            if (PIN2 %2 == 0)
            {
                Console.WriteLine("PIN par");
            }
            else
            {
                Console.WriteLine("PIN impar");
            }

            //ejercicio c
            if (PIN2 %5 == 0)
            {
                Console.WriteLine("multiplo de 5");
            }
            else
            {
                Console.WriteLine("No es multiplo de 5");
            }

            //ejercicio d
            if ((PIN2 >= 1000 && PIN2 <= 9999) && (PIN2 % 2 == 0) && (PIN2 % 5 == 0))
            {
                Console.WriteLine("PIN aceptado por politica");
            }
            else
            {
                Console.WriteLine("PIN reachazado por politica");
            }


            //Ejercicio numero 3 Activacion de cuenta
            Console.WriteLine("\n Escriba un codigo de activacion");
            string codig = Console.ReadLine();
            int codigo = Convert.ToInt32(codig);

            //Ejercicio a
            if (codigo == 2026)
            {
                Console.WriteLine("Codigo correcto");
            }
            else
            {
                Console.WriteLine("Codigo incorrecto");
            }

            //Ejercicio b
            Console.WriteLine("\n Escriba su edad");
            string ed = Console.ReadLine();
            int edad = Convert.ToInt32(ed);

            if (edad >= 18)
            {
                Console.WriteLine("Edad valida");
            }
            else
            {
                Console.WriteLine("Edad no valida");
            }

            //ejercicio c
            Console.WriteLine("\n ¿Acepto los terminos y condiciones? 1 = si");
            string term = Console.ReadLine();
            int Terminos = Convert.ToInt32(term);
            if (Terminos == 1)
            {
                Console.WriteLine("Terminos aceptados");
            }
            else
            {
                Console.WriteLine("Debe aceptar los terminos");
            }

            //Ejercicio d
            Console.WriteLine("\n ¿Activo la verificacion de dos pasos?");
            int Verificaciondos = int.Parse(Console.ReadLine());
            bool V2FA = (Verificaciondos == 1);
            if (V2FA)
            {
                Console.WriteLine("2FA activado");
            }
            else
            {
                Console.WriteLine("2FA no activado");
            }

            //ejercicio e
            Console.WriteLine("\n Puntaje de verificacion (0 a 100)");
            int Puntaje = int.Parse(Console.ReadLine());
            if (Puntaje >= 70)
            {
                Console.WriteLine("Puntaje suficiente");
            }
            else
            {
                Console.WriteLine("Puntaje insufiente");
            }

            //ejercicio f
            if ((codigo == 2026) && (edad >= 18) && (Terminos == 1) && (V2FA) && (Puntaje >= 70))
            {
                Console.WriteLine("Cuenta activada exitosamente");  
            }
            else
            {
                Console.WriteLine("Cuenta NO activada");
            }


            //RETO FINAL Acceso sala de examen
            //ejercicio a
            Console.WriteLine("\n Nota previa (0 a 100)");
            int Nota = int.Parse(Console.ReadLine());
            if (Nota >= 61)
            {
                Console.WriteLine("Requisito academico aprobado");
            }
            else
            {
                Console.WriteLine("Requisito NO academico aprobado");
            }

            //ejercicio b
            Console.WriteLine("\n Minutos de llegar tarde (Puede ser 0)");
            int LlegarTardeMin = int.Parse(Console.ReadLine());
            if (LlegarTardeMin <= 10)
            {
                Console.WriteLine("Hora valida");
            }
            else
            {
                Console.WriteLine("Llegada tarde: Fuera de tiempo");
            }

            //ejercicio c
            Console.WriteLine("\n ¿Tiene solvencia de pagos? 1 = si");
            int Solvencia = int.Parse(Console.ReadLine());
            bool SolvenciaPagos = (Solvencia == 1);
            if (SolvenciaPagos)
            {
                Console.WriteLine("Solvencia valiadad");
            }
            else
            {
                Console.WriteLine("Sin solvencia");
            }

            //ejercicio d
            Console.WriteLine("\n ¿Trae identificacion fisica? 1 = si");
            int iden = int.Parse(Console.ReadLine());
            bool IdentificacionFisica = (iden == 1);
            if (IdentificacionFisica)
            {
                Console.WriteLine("Identificacion valida");
            }
            else
            {
                Console.WriteLine("Sin identificacion");
            }

            //ejercicio e
            Console.WriteLine("\n ¿Trae calculadora permitida? 1 = si");
            int Calculadora = int.Parse(Console.ReadLine());
            bool CalculadoraPermitida = (Calculadora == 1);
            if (CalculadoraPermitida)
            {
                Console.WriteLine("Calculadora permitida: OK");
            }
            else
            {
                Console.WriteLine("Sin calculadora permitida");
            }

            //ejercicio f
            if ((Nota >= 61) && (LlegarTardeMin <= 10) && (SolvenciaPagos) && (IdentificacionFisica) && (CalculadoraPermitida))
            {
                Console.WriteLine("\n Acceso a la sala de examen concedido");
            }
            else
            {
                Console.WriteLine("\n Acceso denegado");
            }

            //ejercicio g
            if (LlegarTardeMin > 0 || LlegarTardeMin <= 10)
            {
                Console.WriteLine("Adevertencia: Llego tarde, pero aun puede ingresar \n");
            }
        }
    }
}
