
using System;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace demo_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Socio> Socios = new List<Socio>();
            List<Mascota> Mascotas = new List<Mascota>();
            Precarga(Socios, Mascotas);

            /*LINQ SOBRE LISTAS EN MEMORIA*/

            // 1.Where
            //Uso: Filtra una secuencia de valores en función de un predicado(una condición).
            //Ejemplo
            List<Socio> sociosConNombreJuan = Socios.Where(s => s.Nombre == "Juan").ToList();

            // 2.FirstOrDefault
            //Uso: Devuelve el primer elemento de una secuencia, o un valor predeterminado(generalmente null) si la secuencia no contiene elementos.
            //Ejemplo:

            var primerSocioConApellidoPerez = Socios.FirstOrDefault(s => s.Apellido == "Pérez");


            // 3.SingleOrDefault
            //Uso: Devuelve el único elemento de una secuencia que cumple una condición específica, o un valor predeterminado si no existe tal elemento. Lanza una excepción si hay más de un elemento que cumple la condición.
            // Ejemplo:

            var socioConId3 = Socios.SingleOrDefault(s => s.Id == 3);

            //4.Select
            //Uso: Proyecta cada elemento de una secuencia en una nueva forma(transforma los elementos).
            //Ejemplo:
            var nombresDeSocios = Socios.Select(s => s.Nombre).ToList();

            // 5.SelectMany
            //Uso: Proyecta cada elemento de una secuencia en una secuencia IEnumerable y combina las secuencias resultantes en una sola secuencia.
            //Ejemplo:
            var todasLasMascotas = Socios.SelectMany(s => s.Mascotas).ToList();

            // 6.OrderBy y OrderByDescending
            //Uso: Ordena los elementos de una secuencia en orden ascendente(OrderBy) o descendente(OrderByDescending).
            //Ejemplo:
            var sociosOrdenadosPorNombre = Socios.OrderBy(s => s.Nombre).ToList();

            //  7.GroupBy
            //Uso: Agrupa los elementos de una secuencia según una clave especificada.
            //Ejemplo:
            var sociosPorApellido = Socios.GroupBy(s => s.Apellido);

            // 8.Count
            //Uso: Cuenta el número de elementos en una secuencia que cumplen una condición.
            //Ejemplo:

            var numeroDeSocios = Socios.Count();


            //9.Any
            //Uso: Determina si alguna parte de los elementos en una secuencia cumple con una condición específica.
            //Ejemplo:

            var haySociosConNombreJuan = Socios.Any(s => s.Nombre == "Juan");


            // 10.All
            //Uso: Determina si todos los elementos en una secuencia cumplen una condición.
            //Ejemplo:
            var todosLosSociosTienenMascotas = Socios.All(s => s.Mascotas.Count > 0);

            // 11.Distinct
            //Uso: Elimina los valores duplicados de una secuencia.
            //Ejemplo:

            var apellidosUnicos = Socios.Select(s => s.Apellido).Distinct().ToList();











            Console.WriteLine("Poner un punto de corte aquí y debuggear");
        }

        private static void Precarga(List<Socio> socios, List<Mascota> mascotas)
        {
            Mascota m1 = new Mascota("Tobi", "Perro", 2018);
            Mascota m2 = new Mascota("Mimi", "Gato", 2020);
            Mascota m3 = new Mascota("Rex", "Perro", 2015);
            Mascota m4 = new Mascota("Luna", "Conejo", 2019);
            Mascota m5 = new Mascota("Bella", "Gato", 2017);
            Mascota m6 = new Mascota("Max", "Perro", 2021);
            Mascota m7 = new Mascota("Coco", "Loro", 2013);
            Mascota m8 = new Mascota("Simba", "Gato", 2016);
            Mascota m9 = new Mascota("Rocky", "Perro", 2019);
            Mascota m10 = new Mascota("Lola", "Hámster", 2022);
            Mascota m11 = new Mascota("Duke", "Perro", 2014);
            Mascota m12 = new Mascota("Nala", "Gato", 2018);
            Mascota m13 = new Mascota("Bobby", "Conejo", 2020);
            Mascota m14 = new Mascota("Felix", "Gato", 2015);
            Mascota m15 = new Mascota("Charlie", "Perro", 2021);
            Mascota m16 = new Mascota("Kiwi", "Loro", 2017);
            Mascota m17 = new Mascota("Molly", "Gato", 2016);
            Mascota m18 = new Mascota("Buddy", "Perro", 2020);
            Mascota m19 = new Mascota("Tina", "Hámster", 2019);
            Mascota m20 = new Mascota("Bruno", "Perro", 2013);
            mascotas.Add(m1);
            mascotas.Add(m2);
            mascotas.Add(m3);
            mascotas.Add(m4);
            mascotas.Add(m5);
            mascotas.Add(m6);
            mascotas.Add(m7);
            mascotas.Add(m8);
            mascotas.Add(m9);
            mascotas.Add(m10);
            mascotas.Add(m11);
            mascotas.Add(m12);
            mascotas.Add(m13);
            mascotas.Add(m14);
            mascotas.Add(m15);
            mascotas.Add(m16);
            mascotas.Add(m17);
            mascotas.Add(m18);
            mascotas.Add(m19);
            mascotas.Add(m20);

            Socio s1 = new Socio("Juan", "Pérez", new DateTime(2024, 07, 12));
            Socio s2 = new Socio("Ana", "Gómez", new DateTime(2024, 06, 23));
            Socio s3 = new Socio("Juan", "Rodríguez", new DateTime(2024, 05, 18));
            Socio s4 = new Socio("María", "Rodríguez", new DateTime(2024, 08, 10));
            Socio s5 = new Socio("Pedro", "Rodríguez", new DateTime(2024, 09, 01));
            socios.Add(s1);
            socios.Add(s2);
            socios.Add(s3);
            socios.Add(s4);
            socios.Add(s5);
            s1.Mascotas.Add(m1);
            s1.Mascotas.Add(m2);
            s2.Mascotas.Add(m3);
            s2.Mascotas.Add(m4);
            s3.Mascotas.Add(m5);
            s3.Mascotas.Add(m6);
            s4.Mascotas.Add(m7);
            s4.Mascotas.Add(m8);
            s5.Mascotas.Add(m9);
            s5.Mascotas.Add(m10);
            s1.Mascotas.Add(m11);
            s1.Mascotas.Add(m12);
            s2.Mascotas.Add(m13);
            s2.Mascotas.Add(m14);
            s3.Mascotas.Add(m15);
            s3.Mascotas.Add(m16);
            s4.Mascotas.Add(m17);
            s4.Mascotas.Add(m18);
            s5.Mascotas.Add(m19);
            s5.Mascotas.Add(m20);

        }
    }
}
