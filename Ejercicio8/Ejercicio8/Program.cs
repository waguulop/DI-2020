using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            pedirDatos();
        }

        public static void pedirDatos()
        {
            Console.WriteLine("Introduce el numero en horizontal: ");
            int num1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Introduce el numero en vertical: ");
            int num2 = System.Convert.ToInt32(System.Console.ReadLine());
            generarTablero(num1, num2);
        }

        public static void generarTablero(int num1, int num2)
        {
            int contador = 0;
            for (int i = 0; i < 8; i++)
            {
                if (i < 2)
                {
                    contador++;
                }
                for (int j = 0; j < 8; j++)
                {
                    if ((num1 == i && num2 == j) || (i == num1 - contador && j == num2 - contador) || (i == num1 + contador && j == num2 + contador) || (i == num1 + contador && j == num2 - contador) || (i == num1 - contador && j == num2 + contador))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write(" N ");
                            }
                            else
                            {
                                Console.Write(" B ");
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write(" B ");
                            }
                            else
                            {
                                Console.Write(" N ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
   
