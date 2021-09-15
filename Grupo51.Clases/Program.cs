using System;

namespace Grupo51.Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno();

            al.IdAlumno = 1;
            al.Calificacion1 = 10;
            al.Calificacion2 = 10;
            al.Calificacion3 = 5;
            al.Nombre = "Melchor";
            al.ApellidoMaterno = "Castro";
            al.Fecha = DateTime.Now;
            al.EstadoNacimiento.Nombre = "Sinaloa";


            var promedio = al.Promedio;
            Console.WriteLine(promedio);

            Alumno al2 = new Alumno(3, "Juan", "Olivas");

            Maestro ma = new Maestro();

            ma.Nombre = "";
            ma.ApellidoPaterno = "";
            ma.ApellidoMaterno = ";";
            ma.EstadoNacimiento.Nombre = "Sinaloa";



            Escuela escuela = new Escuela();

            escuela.IdEscuela = 1;
            escuela.Alumnos.Add(al);
            escuela.Alumnos.Add(new Alumno (1,"Pedro","Perez"));

            escuela.Maestros.Add(ma);
            escuela.Estado.Nombre = "Sinaloa";



        }
    }
}
