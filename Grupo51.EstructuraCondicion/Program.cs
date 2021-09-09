using System;

namespace Grupo51.EstructuraCondicion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Codiciones  If else   else if , switch ,  condiciones ternarias


            //  if (condicione o codiciones ){ ejecucion de intruciones }
            /*  int numero= int.Parse(Console.ReadLine());  

              if (numero == 10)
                  Console.WriteLine("Son iguales");      
              else if (numero > 10)
              {
                  Console.WriteLine("el numero :");
                  Console.WriteLine("Es mayor");
              }
              else
                  Console.WriteLine("Es menor");



              if (!(11 > 20 || 25 < 11) && 18 == 18)
                  Console.WriteLine("Se cumple la condicion");
              else
                  Console.WriteLine("No se cumple la condicion");

            */
            int opcion = int.Parse(Console.ReadLine());
            /*
            switch(opcion)
            {
                case 0:
                    Console.WriteLine("Opcion 0");
                    break;
                case 1:
                    Console.WriteLine("Opcion 1");
                    break;
                case 1000:
                    Console.WriteLine("Opcion 1000");
                    break;
                default:
                    Console.WriteLine("No exista la opcion requerida");
                    break;
            }
            */

            if(opcion==10) Console.WriteLine("Igual"); else Console.WriteLine("No es Igual");

            Console.WriteLine(opcion == 10 ? "Igual" : "No es igual");

        }
    }
}
