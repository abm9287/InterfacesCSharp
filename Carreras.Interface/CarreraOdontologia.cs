using System.Collections.Generic;


namespace Carreras.Interface
{
    public class CarreraOdontologia : ICarrera
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
            return "Estoy estudiando los músculos del abdomen ";
        }
        public string Enseñar()
        {
            return "Estoy enseñando lo componentes bioquímicos que componen la hemoglobina";
        }
        public string Trabajar()
        {
            return "Estoy trabajando en la invstigación de COVID- efectos secundarios después de la enfermedad";
        }
        public string Leer()
        {
            return "Estoy leyenedo los componentes de cura contra el COVID";
        }
        
    }
}
