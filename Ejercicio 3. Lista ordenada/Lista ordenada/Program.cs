using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_ordenada
{
    internal class Program
    {
        static string nombre0;
        static string nombre1;
        static string nombre2;
        static int numeroLibreta0 = 0;
        static int numeroLibreta1 = 0;
        static int numeroLibreta2 = 0;
        static int orden = 0;

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta, int i)
        {
            switch (i)
            {
                case 0:
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                    break;
                case 1:
                    nombre1 = nombre;
                    numeroLibreta1 = numeroLibreta;
                    break;
                case 2:
                    nombre2 = nombre;
                    numeroLibreta2 = numeroLibreta;
                    break;
            }
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            
            Console.WriteLine("Ingrese el numero de la opcion que desea realizar: ");
            Console.WriteLine("1. Registrar nombre y numero de libreta del alumno");
            Console.WriteLine("2. Mostrar lista ordenada por numero de libreta");
            Console.WriteLine("3. Salir");
            int opcionMenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return opcionMenu;


        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de libreta:");
                int numeroLibreta = Convert.ToInt32(Console.ReadLine());

                RegistrarNombreYNumeroLibreta(nombre, numeroLibreta, i);
            }
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Lista ordenada por numero de libreta: ");
            if (numeroLibreta0 < numeroLibreta1 && numeroLibreta0 < numeroLibreta2)
            {
                Console.WriteLine(nombre0 + " - " + numeroLibreta0);
                if (numeroLibreta1 < numeroLibreta2)
                {
                    Console.WriteLine(nombre1 + " - " + numeroLibreta1);
                    Console.WriteLine(nombre2 + " - " + numeroLibreta2);
                }
                else
                {
                    Console.WriteLine(nombre2 + " - " + numeroLibreta2);
                    Console.WriteLine(nombre1 + " - " + numeroLibreta1);
                }
            }
            else if (numeroLibreta1 < numeroLibreta0 && numeroLibreta1 < numeroLibreta2)
            {
                Console.WriteLine(nombre1 + " - " + numeroLibreta1);
                if (numeroLibreta0 < numeroLibreta2)
                {
                    Console.WriteLine(nombre0 + " - " + numeroLibreta0);
                    Console.WriteLine(nombre2 + " - " + numeroLibreta2);
                }
                else
                {
                    Console.WriteLine(nombre2 + " - " + numeroLibreta2);
                    Console.WriteLine(nombre0 + " - " + numeroLibreta0);
                }
            }
            else
            {
                Console.WriteLine(nombre2 + " - " + numeroLibreta2);
                if (numeroLibreta0 < numeroLibreta1)
                {
                    Console.WriteLine(nombre0 + " - " + numeroLibreta0);
                    Console.WriteLine(nombre1 + " - " + numeroLibreta1);
                }
                else
                {
                    Console.WriteLine(nombre1 + " - " + numeroLibreta1);
                    Console.WriteLine(nombre0 + " - " + numeroLibreta0);
                }
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
                            MostrarPantallaSolicitarAlumnos();
                            break;
                        case 2:
                            MostrarPantallaMostrarListaOrdenada();
                            break;
                        case 3:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida, por favor ingrese una opcion del menu.");
                            break;
                    }
               
            } while (opcion != 3);
            
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        

        }
    }
}
