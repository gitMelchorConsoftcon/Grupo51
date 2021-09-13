using System;

namespace Grupo51.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglos

            // tipodaro[] variable 


            int[] valores1;
            int[] valores2 = new int[10];
            valores2[0] = 1;

            int[,] valores3 = new int[5, 3];
            valores3[4, 2] = 20;
            int[,,] valores4 = new int[5, 3, 10];

            //        Console.WriteLine(valores2[0]);
            //Console.WriteLine(valores2[1]);
            //Console.WriteLine(valores3[4,2]);
            //      Console.WriteLine(valores3[3, 0]);

            valores2[0] = 30;
            valores2[1] = 55;
            valores2[2] = 36;
            valores2[3] = 75;
            valores2[4] = 69;
            valores2[5] = 18;
            valores2[6] = 67;
            valores2[7] = 52;
            valores2[8] = 12;
            valores2[9] = 11;


            /*
            for (int i=0; i<10; i++)
                Console.WriteLine(valores2[i]);
            *//*
            var x = 0;
            while (x < 10)
            {
                Console.WriteLine(valores2[x]);
                x++;
            }

             x = 0;
            do
            {
                Console.WriteLine(valores2[x]);
                x++;
            } while (x < 10);
            */

            foreach(int valor in valores2)
                Console.WriteLine(valor);
            

        }
    }
}
