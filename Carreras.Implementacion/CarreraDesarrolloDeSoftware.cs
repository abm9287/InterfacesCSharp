using System.Collections.Generic;
using Carreras.Interface; 

namespace Carreras.Implementacion
{
    public class CarreraDesarrolloDeSoftware : ICarrera
    {

        //Utilizamos verbos para los nombres de los métodos 
       

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
