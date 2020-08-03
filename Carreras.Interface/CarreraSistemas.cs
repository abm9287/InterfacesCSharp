using System.Collections.Generic;

namespace Carreras.Interface
{
    public class CarreraSistemas : ICarrera
    {
        //los sustantivos definen atributos
        private List<string> carrerasUniversitarias;
        private string nombre;

        public string Nombre { get { return nombre; } set { value = nombre; } }
        public List<string> CarrerasUniversitarias { get { return carrerasUniversitarias; } set { value = carrerasUniversitarias; } }

        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return $"Estoy aprendiendo {nombre} y estoy estudiando {carrerasUniversitarias[0]} ";
        }
        public string Estudiar()
        {
            return "Estoy estudiando los ataques cibernéticos ' Ethical Hacking, un enfoque metodológico para profesionales'   ";
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
