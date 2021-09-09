using System;

namespace Grupo51.Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos
            // + - / * %   ++ -- += *= -= 
            /*
            var suma = 4 + 1;
            var suma2 = suma + 20.36;

            var resta = 4 - 1;
            var multiplicacion = 4 * 2;
            var divicion = 10 / 2;  

            var modulo = 10 % 3; // 1

            suma++;
            suma--;


            suma += 10; // suma =suma +10;

            suma -= 10; //suma =suma -10;

            suma *= 10; //suma =suma *10;

            suma /= 10; //suma =suma / 10;
            */
            // =

            // operadores de comparacion
            // ==   >   <   >=    <=   !=
            // === !==
            /*
            Console.WriteLine( 10 == 20);
            Console.WriteLine(10 == 10);
            Console.WriteLine(10> 5 );
            Console.WriteLine(10 > 15);
            Console.WriteLine(10 > 10);
            Console.WriteLine(10 >= 10);

            Console.WriteLine(10 != 10);
            Console.WriteLine(10 != 11);
            */

            //operadores logicos

            // &&   ||   !

               
            

              //                   V           F
            Console.WriteLine(10 != 11 && 10 != 10);

                  //              1          0  
            Console.WriteLine(10 != 11 || 10 != 10);

                      //         V              V
            Console.WriteLine(10 != 11 &&  !(10 != 10));

                  //             V             V
            Console.WriteLine(!(10 != 11 || !(10 != 10)));


        }
    }
}
