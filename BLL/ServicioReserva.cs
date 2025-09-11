using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioReserva
    {
        List<Entidades.Reserva> listaReservas;
        public ServicioReserva()
        {
            listaReservas = new List<Entidades.Reserva>();
        }
        public void AgregarReserva(Entidades.Reserva reserva)
        {
           if (reserva != null)
            {
                listaReservas.Add(reserva);
                Console.WriteLine("Reserva agregada exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: La reserva no puede ser nula.");
            }
        }
        public List<Entidades.Reserva> ListarReservas()
        {
            return listaReservas;
        }
    }
}
