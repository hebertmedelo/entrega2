using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFor
{
    //Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.

    class Program
    {
        static void Main(string[] args)
        {
            int n, con2 = 0, con3 = 0;
            float num = 0;
            Console.WriteLine("digite catidad de numeros: ");
            n = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= n; contador++)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("---------------------------------------");
                Console.Write("digite numeros " + contador+" =====> ");
                num = float.Parse(Console.ReadLine());
               

                Console.WriteLine("el numero " + contador + " es=   " + num);
                if (num >= 1000)
                {
                    con2 = con2 + 1;
                }
                else
                {
                    con3 = con3 + 1;
                }



            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("numeros mayores a 1000: " + con2);
            Console.WriteLine("numeros menores a 1000: " + con3);

            Console.ReadKey();
        }
    }
}
