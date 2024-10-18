using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }



        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoder = superPoder;
        }

        public void MostrarHeroe()
        {
            Console.WriteLine($"Nombre: {Nombre}, Identidad Secreta: {IdentidadSecreta}, Ciudad: {Ciudad}, " +
                              $"Puede Volar: {(PuedeVolar ? "Sí" : "No")}");
            SuperPoder.MostrarPoder();
        }
    }
}
