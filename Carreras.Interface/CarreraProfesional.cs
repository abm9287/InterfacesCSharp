using System.Collections.Generic;

namespace Carreras.Interface
{
    public class CarreraProfesional
    {
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
            return "Estoy estudiando ";
        }
        public string Enseñar()
        {
            return "Estoy enseñando  ";
        }
        public string Trabajar()
        {
            return "Estoy trabajando  ";
        }
        public string Leer()
        {
            return "Estoy leyendo  ";
        }
       
    }
}
