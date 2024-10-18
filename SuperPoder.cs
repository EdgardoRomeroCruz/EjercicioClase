using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperPoder
    {
        //
        public string Nombre    { get; set; }
        public string Descripcion { get; set; }
        public int  Nivel { get; set; }

        public SuperPoder(string nombre, string descrpcion,int  nivel)
        {
            Nombre = nombre;
            Descripcion = descrpcion;
            Nivel = nivel;
        }
        public void MostrarPoder()
        {
            Console.WriteLine($"Poder:{Nombre},Descripcion:{Descripcion},Nivel:{Nivel}");
        }
    }
}
