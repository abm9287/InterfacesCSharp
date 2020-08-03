using System.Collections.Generic;


namespace Carreras.Interface
{
    public class CarreraDesarrolloDeSoftware : ICarrera
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
            return "Estoy estudiando Matematicás Fundamental para Ingenieros";
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
