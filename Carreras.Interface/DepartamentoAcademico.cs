using System;
using System.Collections.Generic;
using System.Text;

namespace Carreras.Interface
{
    public class DepartamentoAcademico
    {
        public ICarrera Carrera { get; set; }
        public string AdministrarCarrera ( ICarrera carrera)
        {
            Carrera = carrera;
            return "Configuré nuevas tareas en el pensum ";
        }

        public string ProgramarActividades()
        {
            return Carrera.Estudiar() + "tarea"+ Carrera.Enseñar()+"tarea" + Carrera.Trabajar()+"tarea"+ Carrera.Leer()+"tarea"+ Carrera.Aprender()+"tarea";
        }

        public string ProgramarOtrasActividades()
        {
            return "Organice y plantee nuevas actividades académicas que fortalecerán los concocimientos académicos que corresponde a cada materia ";
        }
    }
}
