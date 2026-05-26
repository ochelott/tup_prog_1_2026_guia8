using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema_de_introducción
{
    static public class Calculos
    {
        static int acum;
        static int cont;
        static int ValorMaximo;
        static int ValorMinimo;

        static public void RegistrarValor(int valor)
        {
            if (cont == 0)
            {
                ValorMaximo = valor;
                ValorMinimo = valor;
            }
            else
            {
                if (valor > ValorMaximo)
                {
                    ValorMaximo = valor;
                }
                if (valor < ValorMinimo)
                {
                    ValorMinimo = valor;
                }
            }
            cont++;
            acum += valor;
        }
        static public double CalcularPromedio()
        {
            if (cont == 0)
            {
                return 0; // Evitar división por cero
            }
            return acum / cont;
        }
        static public int MostrarPantallaSolicitarOpcionMenu()
        {

            
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo");
            Console.WriteLine("4- Mostrar promedio");
            Console.WriteLine("5- Mostrar cantidad");
            Console.WriteLine("6- Reiniciar variables");
            Console.WriteLine("0- Salir");
            
            return Convert.ToInt32(Console.ReadLine());
            
        }
        static public void ReiniciarVariables()
        {
            acum = 0;
            cont = 0;
            ValorMaximo = 0;
            ValorMinimo = 0;
        }
        static public void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(num);
            Console.Clear();
        }
        static public void CalcularYMostrarPromedio()
        {
            Console.Clear();
            if (cont != 0)
            {
                Console.WriteLine("Promedio: " + CalcularPromedio().ToString("F2"));
                Console.WriteLine("Presione cualquier tecla para continuar...");
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
            }
            
        }
        static public void MostrarMaximoMinimo()
        {
            Console.Clear();
            if (cont != 0)
            {
                Console.WriteLine("Máximo: " + ValorMaximo);
                Console.WriteLine("Mínimo: " + ValorMinimo);
                Console.WriteLine("Presione cualquier tecla para continuar...");
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
            }
            
        }
        static public void MostrarCantidad()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de números ingresados: " + cont);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            

        }
        static public void MostrarPantallaSolicitarVariosNumeros()
        {

            Console.WriteLine("¿Cuántos números desea ingresar? ");
            Console.WriteLine("Ingrese la cantidad: ");
            int cantN = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantN; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                RegistrarValor(num);
            }
            Console.Clear();
        }
          
        }
    }
