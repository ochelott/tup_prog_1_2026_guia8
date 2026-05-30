using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Program
    {
        static string jugador1;
        static string jugador2;
        static int setGanados1 = 0;
        static int setGanados2 = 0;

        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        static void RegistrarResultadosSet(int resultado1, int resultado2)
        {
            Console.WriteLine("Ingrese el resultado del set del jugador 1:");
            resultado1 = Convert.ToInt32(Console.ReadLine());
            setGanados1 += resultado1;
            
            Console.WriteLine("Ingrese el resultado del set del jugador 2:");
            resultado2 = Convert.ToInt32(Console.ReadLine());
            setGanados2 += resultado2;
            Console.Clear();

        }
        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return jugador1;
            }
            else if (setGanados2 > setGanados1)
            {
                return jugador2;
            }
            else
            {
                Console.WriteLine("El partido está empatado.");
            }
            return "";
        }
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar jugadores");
            Console.WriteLine("2. Registrar resultados de set");
            Console.WriteLine("3. Determinar ganador");
            Console.WriteLine("4. Salir");
        }
        static void MostrarPantallaSolicitarNombreJugador()
        {

            string nombre1;
            string nombre2;

            Console.WriteLine("Ingrese nombre del jugador 1:");
            nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese nombre del jugador 2:");
            nombre2 = Console.ReadLine();

            RegistrarJugadores(nombre1, nombre2);
            Console.Clear();
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
           RegistrarResultadosSet(setGanados1, setGanados2);
        }
        static void MostrarPantallaMostrarGanador()
        {
            Console.Clear();
            Console.WriteLine("El ganador del partido es:");
            Console.WriteLine(DeterminarGanador());
            
        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                MostrarPantallaSolicitarOpcionMenu();
                
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            MostrarPantallaSolicitarNombreJugador();
                            break;
                        case 2:
                            MostrarPantallaSolicitarResultadoSet();
                            break;
                        case 3:
                            MostrarPantallaMostrarGanador();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                
            } while (opcion != 4);

            Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
