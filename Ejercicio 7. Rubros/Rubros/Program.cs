using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubros
{
    internal class Program
    {
        static int cantidad1;
        static int cantidad2;
        static int cantidad3;
        static int cantidad4;
        static int cantidad5;
        static int numeroTransaccionMayor;
        static int contadorDeTransacciones;

        static double montoTranaccionMayor;
        static double porcentajeCantidadRubro1;
        static double porcentajeCantidadRubro2;
        static double porcentajeCantidadRubro3;
        static double porcentajeCantidadRubro4;
        static double porcentajeCantidadRubro5;
        static double RecaudacionTotal;
        
        static void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            numeroTransaccionMayor = 0;
            contadorDeTransacciones = 0;
            montoTranaccionMayor = 0;
            porcentajeCantidadRubro1 = 0;
            porcentajeCantidadRubro2 = 0;
            porcentajeCantidadRubro3 = 0;
            porcentajeCantidadRubro4 = 0;
            porcentajeCantidadRubro5 = 0;
            RecaudacionTotal = 0;
        }
        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto) 
        {
            switch (rubro) 
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                    case 2:
                    cantidad2 += cantidad;
                    break;
                    case 3:
                    cantidad3 += cantidad;
                    break;
                    case 4:
                    cantidad4 += cantidad;
                    break;
                    case 5:
                    cantidad5 += cantidad;
                    break;
                    default:
                    Console.WriteLine("Opcion invalida.");
                    Console.WriteLine("Vuelva a ingresar todos los datos nuevamente..");
                    break;
            }
                if (monto > montoTranaccionMayor)
                { 
                    montoTranaccionMayor = monto;
                numeroTransaccionMayor = nroTransaccion;
                }
                RecaudacionTotal += monto;
        }
        static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int totalCantidad = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            porcentajeCantidadRubro1 = (double)cantidad1 / totalCantidad * 100;
            porcentajeCantidadRubro2 = (double)cantidad2 / totalCantidad * 100;
            porcentajeCantidadRubro3 = (double)cantidad3 / totalCantidad * 100;
            porcentajeCantidadRubro4 = (double)cantidad4 / totalCantidad * 100;
            porcentajeCantidadRubro5 = (double)cantidad5 / totalCantidad * 100;
        }
        static int MostrarPantallaOpcionMenu()
        {
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1.Ingresar un resumen de venta");
            Console.WriteLine("2.Mostrar Numero de transaccion registrado con el mayor monto total.");
            Console.WriteLine("3.Mostrar porcentaje de cantidad de ventas por rubro.");
            Console.WriteLine("4.Mostrar recaudacion total.");
            Console.WriteLine("5.Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de transaccion: ");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el rubro: [1 - 5] ");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto:");
            double monto = Convert.ToDouble(Console.ReadLine());
            EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
        }
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro() 
        {
            Console.Clear();
            CalcularPorcentajesCantidadVentasPorRubro();
            Console.WriteLine($"Rubro 1: {porcentajeCantidadRubro1:F2} %");
            Console.WriteLine($"Rubro 2: {porcentajeCantidadRubro2:F2} %");
            Console.WriteLine($"Rubro 3: {porcentajeCantidadRubro3:F2} %");
            Console.WriteLine($"Rubro 4: {porcentajeCantidadRubro4:F2} %");
            Console.WriteLine($"Rubro 5: {porcentajeCantidadRubro5:F2} %");
        }
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();
            Console.WriteLine("Numero de transaccion: " + numeroTransaccionMayor);
            Console.WriteLine("Monto Mayor: " + montoTranaccionMayor);
        }
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();
            Console.WriteLine($"Recaudacion total: ${RecaudacionTotal:F2}");
        }
        static void Main(string[] args)
        {
            InicializarVariables();
            int opcion;

            do
            {
                opcion = MostrarPantallaOpcionMenu();

                switch (opcion)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break; 
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.."); 
                        break;
                }
            }while (opcion != 5);
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
