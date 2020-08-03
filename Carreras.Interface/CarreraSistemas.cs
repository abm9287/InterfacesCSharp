using System;
using System.Collections.Generic;
using System.Text;

namespace Carreras.Interface
{
    public class CarreraSistemas : ICarrera
    {
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
        public string Aprender()
        {
            return "Estoy aprendiendo a crear un Sistema Web con .NET ";
        }
    }
}
