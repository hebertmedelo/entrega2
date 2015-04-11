using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        //Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 
        //(no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e informar 
        //si dicho valor es cero, mayor a cero o menor a cero.

        static void Main(string[] args)
        {
            int num = 0, sum=0;
            do
            {
                Console.WriteLine("Digite Numero: ");
                num = int.Parse(Console.ReadLine());
                if (num == 9999)
                {
                    break;
                }
                sum += num;

            }
            while (num != 9999);
            Console.WriteLine("La Suma es : "+sum);
            if (sum == 0)
            {
                Console.WriteLine("la suma es igual a 0 ");
            }
            else if (sum>0)
            {
                Console.WriteLine("la suma es mayor a 0 " );
            }
            else 
            {
                Console.WriteLine("la suma es menor a 0 ");
            }
            Console.ReadLine();

        }
    }
}
