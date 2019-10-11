using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    class Program
    {
        public static int PrimerNumero;
        public static int SegundoNumero;
        public static int Resultado;
        public static string TablaFinal;
        public static int Numero;
        static string Tabla(int Numero)
        {
            TablaFinal = "";
            PrimerNumero = 0;
            SegundoNumero = Numero;
            Resultado = 0;
            for (int i = 1; i <= 10; i++)
            {
                PrimerNumero = PrimerNumero + 1;
                Resultado = PrimerNumero * SegundoNumero;
                Console.WriteLine(" {0} * {1} = {2}", SegundoNumero, PrimerNumero, Resultado);
            }
            return TablaFinal;
        }

        static string Tabla(int Numero, int color)
        {
            TablaFinal = "";
            PrimerNumero = 0;
            SegundoNumero = Numero;
            Resultado = 0;

            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            for (int i = 1; i <= 10; i++)
            {
                PrimerNumero = PrimerNumero + 1;
                Resultado = PrimerNumero * SegundoNumero;
                Console.WriteLine(" {0} * {1} = {2}", SegundoNumero, PrimerNumero, Resultado);
            }
            return TablaFinal;
        }

        static void Main(string[] args)
        {
            int color;
            Console.WriteLine("Ingrese el numero de la tabla a generar: ");
            Console.WriteLine("");
            Numero = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            Console.WriteLine("Ingrese el color de la tabla a generar: ");
            Console.WriteLine("\n1). Rojo");
            Console.WriteLine("\n2). Azul");
            Console.WriteLine("\n3). Amarillo");
            Console.WriteLine("\n4). Verde");
            Console.WriteLine("\n5). Predeterminado");
            Console.WriteLine("");
            color = Convert.ToInt32(Console.ReadLine());
            

            Console.Clear();
            Console.WriteLine(Tabla(Numero, color));
            Console.ReadKey();

        }
    }
}

