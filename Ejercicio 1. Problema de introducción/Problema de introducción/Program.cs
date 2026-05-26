using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_de_introducción
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                opcion = Calculos.MostrarPantallaSolicitarOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        Calculos.MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        Calculos.MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        Calculos.MostrarMaximoMinimo();
                        break;
                    case 4:
                        Calculos.CalcularYMostrarPromedio();
                        break;
                    case 5:
                        Calculos.MostrarCantidad();
                        break;
                    case 6:
                        Calculos.ReiniciarVariables();
                        break;      
                }
                
            } while (opcion != 0);
            Console.WriteLine("Ingrese cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
