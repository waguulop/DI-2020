using System;

namespace Ejercicio4
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
            Console.WriteLine("Introduce el primer numero : ");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero : ");
            Num2 = int.Parse(Console.ReadLine());
            comprobarPares(Num1, Num2);
        }

        public static void comprobarPares(int Num1, int Num2)
        {
            if (Num1 % 2 == 0 && Num2 % 2 == 0)
            {
                Console.WriteLine("Ambos son pares");
            }
            else
            {
                Console.WriteLine("No son pares ambos o alguno de ellos");
            }
        }
    }
}
