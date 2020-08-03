using System.Collections.Generic;
using Carreras.Interface; 

namespace Carreras.Implementacion
{
    public class CarreraSistemas : ICarrera
    {
        //los sustantivos definen atributos
        private string nombre;
        private List<string> carrerasUniversitarias;
      

        public string Nombre { get { return nombre; } set { nombre = value; } }
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
            return "Estoy enseñando los parámetros de bioseguridad de alimentos";
        }
        public string Trabajar()
        {
            return "Estoy trabajando en la Tesis de Seguridad Informática";
        }
        public string Leer()
        {
            return "Estoy leyenedo los objetivos de la Universidad ";
        }

    }
}
