using System;

namespace Grupo51.Clases
{
    public class Alumno : Persona
    {
        private DateTime _fecha;

        public int IdAlumno { get; set; }


        public int Calificacion1 { get; set; }

        public int Calificacion2 { get; set; }

        public int Calificacion3 { get; set; }


        public int Promedio { get { return (Calificacion1 + Calificacion2 + Calificacion3) / 3; } } // solo lectura

        public DateTime Fecha { set { _fecha = value; } } // solo escritura

        public Alumno()
        {

        }

        public Alumno( int idAlumno ,string nombre, string apellidoPaterno)
        {
            IdAlumno = idAlumno;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;

        }

    }
}
