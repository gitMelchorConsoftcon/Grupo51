using System.ComponentModel.DataAnnotations;

namespace Grupo51.Listas
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        public string Nombre { get; set; }

       public decimal Cla { get; set; }

    }
}
