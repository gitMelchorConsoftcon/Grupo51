using System;
using System.Collections.Generic;
using System.Linq;

namespace Grupo51.Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //listas 
            // List<tipodedato> variable = new List<tipodato>();
            /*
            List<int> numero= new List<int>();

            numero.Add(1);
            numero.Add(200);
            numero.Add(25);
            numero.Add(35);
            numero.Add(35);
            numero.Add(30);
            numero.Add(80);
            numero.Add(9);
            numero.Add(35);
            numero.Add(35);
            numero.Add(35);
            numero.Add(101);
            numero.Add(35);
            numero.Add(35);

            var x = numero.Count;

            //Console.WriteLine(x);
            
            foreach (var item in numero)
                Console.WriteLine(item);

            //var busqueda=  numero.Find(101);
            Console.WriteLine("-----------------------");
            numero.Remove(101);

            foreach (var item in numero)
                Console.WriteLine(item);
            */


            List<Alumno> alumnos = new List<Alumno>();

            alumnos.Add(new Alumno {
            IdAlumno=1,
            Nombre="Pedro perez",
            Cla=10
                        });
            alumnos.Add(new Alumno
            {
                IdAlumno = 2,
                Nombre = "Gaudalue Lopez",
                Cla = 8

            }) ;


            /*
            foreach(Alumno item in alumnos)
            {
                Console.WriteLine(item.IdAlumno);
                Console.WriteLine(item.Nombre);
            }
            */

            var a1 = alumnos.Where(x=> x.IdAlumno == 2).FirstOrDefault();

            Console.WriteLine(a1.IdAlumno);
            Console.WriteLine(a1.Nombre);
        }








    }
    }

