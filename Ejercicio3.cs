using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    class Ejercicio3
    {
        static int Potenciasion(int Numero, int Exponente)
        {
            if (Exponente == 0)
            {
                return 1;
            }

            else
            {
                return Numero * Potenciasion(Numero, Exponente - 1);

            }
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la base: ");
            Console.WriteLine("----------------");
           int Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el exponente: ");
            Console.WriteLine("--------------------");
           int Exponente = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("La base elevado al exponente es: " + Potenciasion(Numero, Exponente));

            Console.ReadKey();
        }


    }
}

