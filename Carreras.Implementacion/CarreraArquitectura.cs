using System.Collections.Generic;
using Carreras.Interface;
 

namespace Carreras.Implementacion 
{
    public class CarreraArquitectura : ICarrera

    {
        private string nombre;
        private List<string> carrerasUniversitarias;


        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> CarrerasUniversitarias { get { return carrerasUniversitarias; } set { carrerasUniversitarias = value; } }


        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return $"Estoy aprendiendo {nombre} y estoy estudiando {carrerasUniversitarias[0]} ";
        }
        public string Estudiar()
        {
            return "Estoy estudiando los diferentes elementos de acero  ";
        }
        public string Enseñar()
        {
            return "Estoy enseñando los tipos de materiales Ingenieros ";
        }
        public string Trabajar()
        {
            return "Estoy trabajando en la nueva carretera vía Samborondón ";
        }
        public string Leer()
        {
            return "Estoy leyendo los folletos de Construcción en Concreto y Acero ";
        }
        
    }
}
