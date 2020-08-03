using System.Collections.Generic;
using Carreras.Interface;

namespace Carreras.Implementacion
{
    public class CarreraOdontologia : ICarrera
    {
        private string nombre;
        private List<string> carrerasUniversitarias;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> CarrerasUniversitarias { get { return carrerasUniversitarias; } set { carrerasUniversitarias = value; } }


        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return "Estoy aprendiendo Ortondoncia y los instrumentos médicos que se usan ";
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
