using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_niñas
{
    internal class Program
    {
        static int edad, edad0, edad1, edad2, edad3;
        static double monto, monto0 = 0, monto1 = 0, monto2 = 0, monto3 = 0;
        static double porcentaje0, porcentaje1, porcentaje2, porcentaje3;

        static void RegistrarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir: ");
            monto = Convert.ToDouble(Console.ReadLine());
           

        }
        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0:
                    edad0 = edad;
                    break;

                case 1:
                    edad1 = edad;
                    break;

                case 2:
                    edad2 = edad;
                    break;

                case 3:
                    edad3 = edad;
                    break;
            }
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la edades de las niñas ");
                edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, i);
            }
        }

        static void CalcularMontosYPorcentajes()
        {
            int totalEdades = edad0 + edad1 + edad2 + edad3;

            porcentaje0 = (double)edad0 / totalEdades * 100;
            porcentaje1 = (double)edad1 / totalEdades * 100;
            porcentaje2 = (double)edad2 / totalEdades * 100;
            porcentaje3 = (double)edad3 / totalEdades * 100;

            monto0 = monto * (porcentaje0 / 100);
            monto1 = monto * (porcentaje1 / 100);
            monto2 = monto * (porcentaje2 / 100);
            monto3 = monto * (porcentaje3 / 100);
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
             
            Console.WriteLine("1- Ingresar Monto ");
            Console.WriteLine("2- Ingresar Edades ");
            Console.WriteLine("3- Mostrar monto a repartir ");
            Console.WriteLine("0- Salir ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
        static void MostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine($"Monto a repartir para Ana Paula: {monto0:F2} " + $" - Porcentaje: {porcentaje0:F2}  " + "%");
            Console.WriteLine($"Monto a repartir para Lucia: {monto1:F2} " + $" - Porcentaje: {porcentaje1:F2}  " + "%");
            Console.WriteLine($"Monto a repartir para Milena: {monto2:F2} " + $" - Porcentaje: {porcentaje2:F2}  " + "%");
            Console.WriteLine($"Monto a repartir para Jazmin: {monto3:F2} " + $" - Porcentaje: {porcentaje3:F2}  " + "%");

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
                        RegistrarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        CalcularMontosYPorcentajes();
                        MostrarMontoYPorcentajePorNiña();
                        break;
                }
                Console.WriteLine("Presione una tecla para salir...");
                
            } while (opcion != 0);
            
        }  
    }
}
