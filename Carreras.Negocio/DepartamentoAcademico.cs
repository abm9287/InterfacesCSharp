using Carreras.Entidad;

namespace Carreras.Negocio
{
    public class DepartamentoAcademico 
    {
        public ICarrera Carrera { get; set; }
        public string AdministrarCarrera(ICarrera carrera)
        {
            Carrera = carrera;
            return "Contraté nuevos prfesionales que se encargarán en la administración académica de Sistemas";
        }

        public string ProgramarTareas()
        {
            return Carrera.Estudiar() + "tarea" + Carrera.Enseñar() + "tarea" + Carrera.Trabajar() + "tarea" + Carrera.Leer() + "tarea" + Carrera.Aprender() + "tarea";
        }
       
        public string ProgramarActividadesSistemas()
        {
            //Carrera = new CarreraSistemas(); ToDo
            return "Configuré pensum actual 2020-2021";
        }


    }
}
