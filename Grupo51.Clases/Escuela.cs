using System.Collections.Generic;

namespace Grupo51.Clases
{
    public class Escuela
    {
        public int IdEscuela { get; set; }
        public string Nombre { get; set; }
        public List<Alumno>  Alumnos{ get; set; }
        public List<Maestro> Maestros { get; set; }
        public Estado Estado { get; set; }

    }
}
