using Carreras.Interface; 

namespace Carreras.Negocio 
{
    public class Constructora 
    {
        public ICarrera Carrera { get; set; }
        public string AdministrarCarrera(ICarrera carrera)
        {
            Carrera = carrera;
            return "Contraté nuevos profesionales que se encargarán en la administración académica de Sistemas";
        }

        public string ProgramarTareas()
        {
            return Carrera.Estudiar() + "tarea" + Carrera.Enseñar() + "tarea" + Carrera.Trabajar() + "tarea" + Carrera.Leer() + "tarea" + Carrera.Aprender() + "tarea";
        }
        public string ProgramarOtrasActividades()
        {
            return "Organice y plantee nuevas actividades académicas que fortalecerán los concocimientos académicos que corresponde a cada materia  ";
        }

    }
}
