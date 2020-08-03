using System.Collections.Generic;
using Carreras.Interface; 

namespace Carreras.Implementacion
{
    public class CarreraDesarrolloDeSoftware : ICarrera
    {
        private string nombre;
        private List<string> carrerasUniversitarias;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> CarrerasUniversitarias { get { return carrerasUniversitarias; } set { carrerasUniversitarias = value; } }


        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return "Estoy aprendiendo Base de Datos en SQLServer ";
        }
        public string Estudiar()
        {
            return "Estoy estudiante C# .NET";
        }
        public string Enseñar()
        {
            return "Estoy enseñando los comandos básicos de la consola Linux ";
        }
        public string Trabajar()
        {
            return "Estoy trabajando en las nuevas disposiciones de trabajo del trabajo SCRUM ";
        }
        public string Leer()
        {
            return "Estoy leyendo los tipos de hackers";
        }


    }
}
