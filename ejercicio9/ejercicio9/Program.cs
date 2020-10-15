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
            try
            {
                int res = division(num1, num2);
                Console.WriteLine("El resultado es " + res);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Has intentado dividir con 0");
            }
        }

        public static int division(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new System.DivideByZeroException();
            }
            return num1/num2;
        }
    }
}
