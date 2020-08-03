using System.Collections.Generic;


namespace Carreras.Interface
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido {get; set; }

        public List<string> CarrerasUniversitarias { get; set; }


    }
}
