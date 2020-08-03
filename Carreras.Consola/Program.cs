using System;
using Carreras.Interface; 

namespace Carreras.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarreraProfesional MiCarrera = new CarreraProfesional();

            

            var carrera1 = new CarreraDesarrolloDeSoftware();

            Console.ReadKey();
        }
    }
}
