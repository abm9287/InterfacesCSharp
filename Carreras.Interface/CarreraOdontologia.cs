using System;
using System.Collections.Generic;
using System.Text;

namespace Carreras.Interface
{
    public class CarreraOdontologia : ICarrera
    {
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
        public string Aprender()
        {
            return "Estoy aprendiendo medidas de seguridad ";
        }

    }
}
