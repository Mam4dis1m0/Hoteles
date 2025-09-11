using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entidades;    
namespace Parcialp3
{
    public class VistaReserva : InterfaReserva
    {
        ServicioReserva servicioReserva = new ServicioReserva();
        Reserva reserva = new Reserva();

        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Reservas");
                Console.WriteLine("1. Agregar Reserva");
                Console.WriteLine("2. Modificar Reserva");
                Console.WriteLine("3. Eliminar Reserva");
                Console.WriteLine("4. Listar Reservas");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarReserva();
                        break;
                    case 2:
                        // Implementacion para Modificar Reserva
                        break;
                    case 3:
                        // Implementacion para Eliminar Reserva
                        break;
                    case 4:
                        ListarReservas();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del menu de Reservas...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 5);
        }

       public void AgregarReserva()
        {
            Console.Clear();
            Console.WriteLine("Agregar Reserva");
            Console.Write("Ingrese Numero de Habitacion: ");
            reserva.NumeroHabitacion = Console.ReadLine();
            Console.Write("Ingrese Fecha de Entrada (yyyy-MM-dd): ");
            reserva.FechaEntrada = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese Fecha de Salida (yyyy-MM-dd): ");
            reserva.FechaSalida = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese Tipo de Habitacion: ");
            reserva.TipoHabitacion = Console.ReadLine();
            Console.Write("Ingrese Precio: ");
            reserva.Precio = decimal.Parse(Console.ReadLine());
            servicioReserva.AgregarReserva(reserva);
            Console.WriteLine("Reserva agregada exitosamente.");
        }

        public void ListarReservas()
        {
            Console.Clear();
            Console.WriteLine("Listar Reservas");
            var reservas = servicioReserva.ListarReservas();
            foreach (var res in reservas)
            {
                Console.WriteLine($"Habitacion: {res.NumeroHabitacion}, Entrada: {res.FechaEntrada.ToShortDateString()}, Salida: {res.FechaSalida.ToShortDateString()}, Tipo: {res.TipoHabitacion}, Precio: {res.Precio}");
            }
        }
    }
}
