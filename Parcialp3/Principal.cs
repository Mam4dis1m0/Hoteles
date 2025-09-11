using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcialp3
{
    internal class Principal
    {
        public static void Menu_Hotel()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Hotel");
                Console.WriteLine("1. Gestion de Huespedes");
                Console.WriteLine("2. Gestion de Habitaciones");
                Console.WriteLine("3. Gestion de Reservas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        VistaHuesped vistaHuesped = new VistaHuesped();
                        vistaHuesped.menu();
                        break;
                    case 2:
                       VistaReserva reserva = new VistaReserva();
                          reserva.menu();
                        break;
                    case 3:
                        // Implementacion para Gestion de Habitaciones
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
                if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }
    }
}
