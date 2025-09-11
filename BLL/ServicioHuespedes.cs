using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL
{
    public class ServicioHuespedes
    {
        List<Huespedes> listaHuespedes;

        public ServicioHuespedes()
        {
            listaHuespedes = new List<Huespedes>();
        }
        public void AgregarHuesped(Huespedes huespedes)
        {
           if (huespedes != null)
            {
                listaHuespedes.Add(huespedes);
                Console.WriteLine("Huesped agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: El huesped no puede ser nulo.");
            }
        }

        public List<Huespedes> ListarHuespedes()
        {
            return listaHuespedes;
        }
    }
}
