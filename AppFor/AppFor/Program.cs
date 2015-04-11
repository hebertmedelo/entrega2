using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas, con2=0, con3=0;
            float nota = 0;
            Console.WriteLine("digite numero de notas: ");
            notas = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= notas; contador++)
            {
                Console.WriteLine("digites notas " + contador);
                nota=float.Parse(Console.ReadLine());
               
               
                Console.WriteLine("la nota del estudiante " + contador + " es: " + nota);
                if (nota >= 7)
                {
                    con2 = con2 + 1;
                }
                else
                {
                    con3 = con3 + 1;
                }
 


            }
            Console.WriteLine("las notas mayores a 7 con: " +con2 );
            Console.WriteLine("las notas menores a 7 con: " + con3);
            Console.ReadKey();
        }
    }
}
