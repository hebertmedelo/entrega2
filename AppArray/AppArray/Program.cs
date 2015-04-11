using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa que solicite la carga de números por teclado, obtener su promedio. 
//Finalizar la carga de valores cuando se cargue el valor 0.

namespace AppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0,contador=0;
            int[] Vector;
            Console.WriteLine("digete numero de elementos ");
            num = int.Parse(Console.ReadLine());
            Vector = new int[num];
            for (int con = 0; con < num; con++)
            {
                Console.WriteLine("digete elemento del vector ");
                Vector[con] = int.Parse(Console.ReadLine());
            }
            foreach (int recorrido in Vector)
            {
                if (recorrido > 100)
                {
                    contador++;
                }
            }

            Console.WriteLine("lo numeros superiose a 100 son:   "+contador);
            Console.ReadKey();
        }
    }
}
