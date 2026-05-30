using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Encuesta
{
    internal class Program
    {
        static int indecisos = 0;
        static int negativos = 0;
        static int positivos = 0;
        static double porcentajeIndecisos;
        static double porcentajeNegativos;
        static double porcentajePositivos;
        
        static void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 1:
                    positivos++;
                    break;
                case 2:
                    negativos++;
                    break;
                case 3:
                    indecisos++;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese 1, 2 o 3.");
                    break;
            }
        }
        static void ProcesarEncuesta()
        {
            int totalEncuestados = positivos + negativos + indecisos;
            if (totalEncuestados > 0)
            {
                porcentajePositivos = (double)positivos / totalEncuestados * 100;
                porcentajeNegativos = (double)negativos / totalEncuestados * 100;
                porcentajeIndecisos = (double)indecisos / totalEncuestados * 100;
            }
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {

            Console.WriteLine("Ingrese una opción:");
            Console.WriteLine("1. Registrar encuestas");
            Console.WriteLine("2. Procesar y mostrar resultados de la encuesta");
            Console.WriteLine("3. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();    
            ProcesarEncuesta();
            Console.WriteLine("Resultados de la encuesta:");
            Console.WriteLine($"Positivos: {positivos} ({porcentajePositivos:F2}%)");
            Console.WriteLine($"Negativos: {negativos} ({porcentajeNegativos:F2}%)");
            Console.WriteLine($"Indecisos: {indecisos} ({porcentajeIndecisos:F2}%)");
        }
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su opinión sobre el producto:");
            Console.WriteLine("1. Positivo");
            Console.WriteLine("2. Negativo");
            Console.WriteLine("3. Indeciso");
            int opinion = Convert.ToInt32(Console.ReadLine());
            RegistrarOpinion(opinion);
        }

            static void Main(string[] args)
        {
            int opcion;

            do { 
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                    MostrarPantallaRegistrarEncuesta();
                        break;
                        case 2:
                            MostrarPantallaProcesarMostrarResultadosEncuesta();
                        break;
                        case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break; 
                        default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese 1, 2 o 3");
                        break;
                }
            } while (opcion != 3);
            Console.WriteLine("Gracias por participar en la encuesta. ¡Hasta luego!");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
