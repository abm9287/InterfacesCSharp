using System;
using System.Collections.Generic;
using System.Text;

namespace Carreras.Interface
{
    public class CarreraDesarrolloDeSoftware : ICarrera
    {
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
        public string Aprender()
        {
            return "Estoy aprendiendo las Leyes fundamentales de la robótica";
        }
    }
}
