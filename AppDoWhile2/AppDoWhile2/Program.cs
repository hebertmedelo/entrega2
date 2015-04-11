using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
    //Escribir un programa que solicite la carga de números por teclado, obtener su promedio.
        // Finalizar la carga de valores cuando se cargue el valor 0.

        static void Main(string[] args)
        {
            int num = 0, sum = 0, con=0;
            float p;
            do
            {
                Console.WriteLine("Digite Numero: ");
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                sum += num;
                con++;
            }
            while (num != 0);
            p = sum /con ;
            Console.WriteLine("el promedio es : " + p);
           
            Console.ReadLine();

        }
    }
}
