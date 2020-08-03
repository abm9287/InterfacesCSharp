using System.Collections.Generic;
using Carreras.Interface; 

namespace Carreras.Implementacion
{
    public class CarreraProfesional : ICarrera
    {
      

       
        
        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return "Estoy aprendiendo y estoy estudiando" ;
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
