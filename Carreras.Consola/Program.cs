using System;
using Carreras.Implementacion;
using Carreras.Negocio;


namespace Carreras.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Constructora MiCarrera = new Constructora();

            MiCarrera.AdministrarCarrera(new CarreraOdontologia());
            MiCarrera.ProgramarTareas();

            var carrera1 = new CarreraSistemas();
            carrera1.Nombre = "Klever";

            
            MiCarrera.ProgramarOtrasActividades();
            MiCarrera.ProgramarTareas();

            Console.ReadKey();
        }
    }
}
