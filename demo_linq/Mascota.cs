using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_linq
{
    public class Mascota
    {
        public static int _ultimoId { get; set; } = 1;
        public  int Id { get; set; }
        public  string Nombre { get; set; }
        public string Tipo { get; set; }
        public int AnioNacimiento { get; set; }

        public Mascota(string nombre, string tipo, int anioNacimiento)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Tipo = tipo;
            AnioNacimiento = anioNacimiento;
        }
    }
}
