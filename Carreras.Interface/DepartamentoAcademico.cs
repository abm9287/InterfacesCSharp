

namespace Carreras.Interface
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
            Carrera = new CarreraSistemas();
            return "Configuré pensum actual 2020-2021";
        }
        public string ProgramarActividadesVarias()
        {
            Carrera = new CarreraDesarrolloDeSoftware;
            return "Se integró un nuevo Ingeniero para que enseñe BDD"; 
        }
        public string ProgramarOtrasActividades()
        {
            return "Organice y plantee nuevas actividades académicas que fortalecerán los concocimientos académicos que corresponde a cada materia  ";
        }

    }
}
