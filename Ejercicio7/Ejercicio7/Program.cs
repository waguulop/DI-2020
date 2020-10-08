using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0, anio = 0;
            pedirNumeros(mes, anio);
        }

        public static void pedirNumeros(int Num2, int Num3)
        {
            Boolean bisiesto;
            Console.WriteLine("Introduce el mes (#/##) : ");
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el año (####) : ");
            Num3 = int.Parse(Console.ReadLine());
            bisiesto = comprobarBisiesto(Num3);
            imprimirResultado(bisiesto, Num3, Num2);
        }

        public static void imprimirResultado(Boolean bisiesto, int num3, int num2)
        {
            imprimirMes(num2);
            Console.Write(" del año " + num3);
            if (bisiesto == true)
            {
                if (num2 == 2)
                {
                    Console.Write(" es bisiesto y tiene 29 dias");
                }
            }
            else
            {
                Console.WriteLine(" tiene 31 dias");
            }


        }

        public static Boolean comprobarBisiesto(int Num3)
        {
            Boolean bisiesto = false;
            if (Convert.ToInt32(Num3) % 4 == 0 && Convert.ToInt32(Num3) % 100 != 0 || Convert.ToInt32(Num3) % 400 == 0)
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }

            return bisiesto;
        }

        public static void imprimirMes(int Num3)
        {
            switch (Num3)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;


                default:
                    Console.WriteLine("El mes introducido no existe");
                    break;
            }
        }
    }
}
