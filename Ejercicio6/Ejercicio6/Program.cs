using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            solucionDoWhile();
            solucionForEach();
        }

        public static void solucionDoWhile()
        {
            int num = 0;
            int contador = 0;
            int cuentasietes = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num == 7)
                {
                    cuentasietes++;
                }
                contador++;
            } while (contador < 5);

            Console.WriteLine("Hay en total " + cuentasietes + " sietes");
        }

        public static void solucionForEach()
        {
            string[] cadenaNumeros = new string[] { "2","4","7", "3", "7" , "1"};
            int contador = 0;
            foreach (string element in cadenaNumeros)
            {
                if(element == "7")
                {
                    contador++;
                }
            }

            Console.WriteLine("Hay en total " + contador + " sietes");
        }
    }
}
