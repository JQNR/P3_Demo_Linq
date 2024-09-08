using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_linq
{
    public class Socio
    {
        public static int _ultimoId { get; set; } = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaUltimoPago { get; set; }

        public List<Mascota> Mascotas = new List<Mascota>();

        public Socio(string nombre, string apellido, DateTime fechaUltimoPago)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            FechaUltimoPago = fechaUltimoPago;
        }
    }
}
