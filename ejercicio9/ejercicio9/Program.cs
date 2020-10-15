using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            pedirDatos();
        }

        public static void pedirDatos()
        {
            Console.WriteLine("Introduce el primer numero: ");
            int num1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero: ");
            int num2 = System.Convert.ToInt32(System.Console.ReadLine());
            int res = 0;
            try
            {
                res = division(num1, num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Has intentado dividir con 0");
            }
            imprimirResultado(res);
        }

        public static int division(int num1, int num2)
        {
            return num1/num2;
        }

        public static void imprimirResultado(int res)
        {
            if (res != 0)
            {
                Console.WriteLine("El resultado es " + res);
            }
        }
    }
}
