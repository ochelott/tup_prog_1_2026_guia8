using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Año_bisiesto__y__Día_del_mes
{
    internal class Program
    {
        static int DeterminarLosDiasDelMes(int mes, int año)
        {
            int dias = 0;
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                case 2:
                    dias = 29; 
                    break;
                default:
                    Console.WriteLine("Mes inválido");
                    break;
            }
            return dias;
        }
        static bool DetermiarSiEsBisiesto(int año)
        {
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {

            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar año y mes para determinar los días del mes");
            Console.WriteLine("2. Ingresar año para determinar si es bisiesto");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año:");
            int año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes (1-12):");
            int mes = Convert.ToInt32(Console.ReadLine());
            int dias = DeterminarLosDiasDelMes(mes, año);
            Console.WriteLine("El mes tiene " + dias + " días");
            
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año:");
            int año = Convert.ToInt32(Console.ReadLine());
            if (DetermiarSiEsBisiesto(año))
            {
                Console.WriteLine("El año " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto");
            }
            
        }

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                } 
            } while (opcion != 3);
        }
    }
}
