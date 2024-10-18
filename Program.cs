// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos de la clase SuperPoder
            SuperPoder poder1 = new SuperPoder("Fuerza Sobrehumana", "Capacidad de levantar objetos muy pesados", 5);
            SuperPoder poder2 = new SuperPoder("Invisibilidad", "Puede volverse invisible a voluntad", 4);
            SuperPoder poder3 = new SuperPoder("Velocidad", "Corre a velocidades extremas", 5);

            // Crear objetos de la clase SuperHeroe
            SuperHeroe heroe1 = new SuperHeroe("Superman", "Clark Kent", "Metrópolis", true, poder1);
            SuperHeroe heroe2 = new SuperHeroe("Invisible Woman", "Sue Storm", "Nueva York", false, poder2);
            SuperHeroe heroe3 = new SuperHeroe("Flash", "Barry Allen", "Central City", true, poder3);

            // Mostrar la información de los superhéroes
            heroe1.MostrarHeroe();
            Console.WriteLine();
            heroe2.MostrarHeroe();
            Console.WriteLine();
            heroe3.MostrarHeroe();
        }
    }
}

