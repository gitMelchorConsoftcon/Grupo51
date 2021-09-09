using System;

namespace Grupo51.EstructurasControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control
            // for , while , do while , foreach

            // for(inicio;condicion;incremento)

            //for(int i=100; i<200; i+=5) 
            //    Console.WriteLine(i);
            // break, continue , goto;
            //while( condicion) { ejecucion; opcion para el romper el ciclo }

            //int i=0;
            //while ( i < 10)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}


            // do while 
            //  do { ejecucion; opcion para romper el ciclo;}while(condicion)  

            int  i = 20;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 10);


            // foreach(tipodato x in colecion de dato){ejecucion}

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(int numeros in a)
            {
                Console.WriteLine(numeros);
            }



        }
    }
}
