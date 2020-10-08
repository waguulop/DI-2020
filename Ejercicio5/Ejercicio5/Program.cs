using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            pedirNumeros(num1, num2);
        }

        public static void pedirNumeros(int Num1, int Num2)
        {
            Boolean comprueba = false;
            Console.WriteLine("Introduce un numero entre 0 y 20: ");
            Num1 = int.Parse(Console.ReadLine());
            int contador = 0;
            while (comprueba == false && contador < 5)
            {
                Console.WriteLine("Introduce el segundo numero (intentos restantes " + (5 - contador) + ") : ");
                Num2 = int.Parse(Console.ReadLine());
                comprueba = comprobarNumeros(Num1, Num2);
                contador++;
            }
        }

        public static bool comprobarNumeros(int Num1, int Num2)
        {
            bool comprueba = false;
            if (Num1 == Num2)
            {
                Console.WriteLine("Has acertado el número");
                comprueba = true;
            }
            else
            {
                Console.WriteLine("Intentalo de nuevo");
                comprueba = false;
            }

            return comprueba;
        }
    }
}
