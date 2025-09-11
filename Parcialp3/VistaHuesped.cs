using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entidades;

namespace Parcialp3
{
    
    public class VistaHuesped : InterfaHusped
    {
       
            ServicioHuespedes servicioHuespedes = new ServicioHuespedes();
            Huespedes huespedes = new Huespedes();

        public void menu()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Huespedes");
                Console.WriteLine("1. Agregar Huesped");
                Console.WriteLine("2. Modificar Huesped");
                Console.WriteLine("3. Eliminar Huesped");
                Console.WriteLine("4. Listar Huespedes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarHuesped();
                        break;
                    case 2:
                        ModificarHuesped();
                        break;
                    case 3:
                        EliminarHuesped();
                        break;
                    case 4:
                        ListarHuespedes();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del menu de Huespedes...");
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


            public void AgregarHuesped()
            {
                Console.Clear();
                Console.WriteLine("Agregar Huesped");
                Console.Write("Ingrese Nombre: ");
                huespedes.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido: ");
                huespedes.Apellido = Console.ReadLine();
                servicioHuespedes.AgregarHuesped(huespedes);
                Console.WriteLine("Huesped agregado exitosamente.");
        }

        public void ModificarHuesped()
        {
            Console.Clear();
            Console.WriteLine("Modificar Huesped");
            // Implementacion para modificar huesped
            Console.WriteLine("Funcionalidad no implementada.");
        }

        public void EliminarHuesped()
        {
            Console.Clear();
            Console.WriteLine("Eliminar Huesped");
            // Implementacion para eliminar huesped
            Console.WriteLine("Funcionalidad no implementada.");
        }

       public void ListarHuespedes()
        {
            Console.Clear();
            Console.WriteLine("Listar Huespedes");
            List<Huespedes> lista = servicioHuespedes.ListarHuespedes();
            foreach (var huesped in lista)
            {
                Console.WriteLine($"ID: {huesped.Id}, Nombre: {huesped.Nombre}, Apellido: {huesped.Apellido}");
            }
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay huespedes registrados.");
            }
        }   

    }
}
